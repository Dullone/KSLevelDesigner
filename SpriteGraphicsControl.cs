using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using WinFormsGraphicsDevice;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Windows.Forms;
using System.IO;

namespace KSlevelDesigner
{
    class SpriteGraphicsControl : GraphicsDeviceControl
    {
        SpriteBatch spriteBatch;
        public SpriteFont spriteFont;

        SortedList<uint,TileNode> drawableObjects;
        Vector2 ViewportOffset;

        TileNode selection;
        TileNode lastToggledNode;

        public ContentManager content;

        //camera
        Camera2d cam;
        //Mouseloc
        System.Drawing.Point prevMouseLoc;
        Texture2D blackPixel;

        //nodeclicke event
        public delegate void NodeClickedEventHandler(Object sender, NodeClickedEventArgs e);
        public event NodeClickedEventHandler NodeClicked;
        public event NodeClickedEventHandler NodeRightClicked;

        //Options
        private bool paintStartLocation = true;
        private bool showEnemyPaths = true;
        private bool showEnemyPathSelected = false;

        /// <summary>
        /// Initializes the control, creating the ContentManager
        /// and using it to load a SpriteFont.
        /// </summary>
        protected override void Initialize()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            drawableObjects = new SortedList<uint,TileNode>(1000);
            ViewportOffset = new Vector2(0, 0);
            cam = new Camera2d();
            cam.Pos = new Vector2(this.Width/2, this.Height/2);
            selection = null;
            using(FileStream fs = new FileStream("BlackPixel.png", FileMode.Open, FileAccess.Read))
            {
                blackPixel = Texture2D.FromStream(GraphicsDevice, fs);
            }
        }

        //Properites
        public SortedList<uint, TileNode> NodeList
        {
            get { return drawableObjects; }
        }

        public SpriteFont Font
        {
            set { spriteFont = value;}
        }

        public bool ShowEnemyPaths
        {
            set 
            { 
                showEnemyPaths=value;
                this.Invalidate();
            }
            get { return showEnemyPaths; }
        }

        public bool ShowEnemyPathSelected
        {
            set
            {
                showEnemyPathSelected = value;
                this.Invalidate();
            }
            get { return showEnemyPathSelected; }
        }

        public TileNode SelectedNode
        {
            get { return selection; }
        }

        public bool PaintStartLocation
        {
            set 
            {
                paintStartLocation = value;
                this.Invalidate();
            }
            get { return paintStartLocation; }
        }

        /// <summary>
        /// Disposes the control, unloading the ContentManager.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //content.Unload();
            }

            base.Dispose(disposing);
        }

        public TileNode SelectTile(Vector2 tileLocation)
        {
            uint value = (uint)(tileLocation.X * TileNode.maxWidthAndHeight + tileLocation.Y);
            try
            {
                TileNode tile = drawableObjects[value];
                return tile;
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        public void CenterOn(Vector2 loc)
        {
            ViewportOffset.X = this.Width / 2 - loc.X;
            ViewportOffset.Y = this.Height / 2 - loc.Y;
            this.Invalidate();
        }

        public void AddTileNodeList(SortedList<uint,TileNode> nodeList)
        {
            Dictionary<string, Texture2D> textures = new Dictionary<string, Texture2D>();
            try
            {
                foreach (KeyValuePair<uint, TileNode> node in nodeList)
                {
                    if (textures.ContainsKey(node.Value.floorName) == false)
                        using (FileStream fs = new FileStream(node.Value.floorName, FileMode.Open, FileAccess.Read))
                        {
                            node.Value.floor = Texture2D.FromStream(GraphicsDevice, fs);
                            textures.Add(node.Value.floorName, node.Value.floor);
                        }
                    else
                        node.Value.floor = textures[node.Value.floorName];
                    if (node.Value.overlayName != null && node.Value.overlayName != "" )
                    {
                        if (textures.ContainsKey(node.Value.overlayName) == false)
                        {
                            using (FileStream fs = new FileStream(node.Value.overlayName, FileMode.Open, FileAccess.Read))
                            {
                                node.Value.Overlay = Texture2D.FromStream(GraphicsDevice, fs);
                                textures.Add(node.Value.overlayName, node.Value.Overlay);
                            }
                        }
                        else
                            node.Value.Overlay = textures[node.Value.overlayName];
                    }
                    
                    if (node.Value.enemy != null)
                    {
                        if (textures.ContainsKey(node.Value.enemy.TextureString) == false)
                        {
                            using (FileStream fs = new FileStream(node.Value.enemy.TextureString, FileMode.Open, FileAccess.Read))
                            {
                                node.Value.enemy.Texture = Texture2D.FromStream(GraphicsDevice, fs);
                                textures.Add(node.Value.enemy.TextureString, node.Value.enemy.Texture);
                            }
                        }
                        else
                            node.Value.enemy.Texture = textures[node.Value.enemy.TextureString];
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "  Could not load texture file.  Are they in the correct directory?.", "Error: Could not load");
            }
            drawableObjects = nodeList;
            ViewportOffset.X = ViewportOffset.Y = 0;
            this.Invalidate(); //redraw
        }

        public void AddDrawableObject(TileNode obj)
        {
            drawableObjects.Add(obj.CompareValue, obj);
        }

        public void RemoveDrawableObject(TileNode obj)
        {
            drawableObjects.Remove(obj.CompareValue);
        }

        public void ClearNodes()
        {
            drawableObjects.Clear();
        }

        public void NewList()
        {
            drawableObjects = new SortedList<uint, TileNode>(1000);
        }

        /// <summary>
        /// Draws the control, using SpriteBatch and SpriteFont.
        /// </summary>
        protected override void Draw()
        {         
            GraphicsDevice.Clear(Color.Black);

            //spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.LinearClamp, DepthStencilState.None, RasterizerState.CullCounterClockwise, null, cam.get_transformation(GraphicsDevice));
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            Rectangle rec = new Rectangle(DisplayRectangle.X, DisplayRectangle.Y, DisplayRectangle.Width, DisplayRectangle.Height);
            foreach (KeyValuePair<uint,TileNode> obj in drawableObjects)
            {
                obj.Value.Draw(spriteBatch, ViewportOffset, spriteFont, rec);
                if (obj.Value.enemy != null)
                {
                    if(showEnemyPaths == true)
                    {
                        if (showEnemyPathSelected == true)
                        {
                            if (obj.Value.enemy.selected != true)
                                continue;
                        }
                        if (obj.Value.enemy.IdlePath != null)
                        {
                            for (int i = 0; i < obj.Value.enemy.IdlePath.Count - 1; i++ )
                            {
                                int rgb = (int)(255 * ((float)i / (float)obj.Value.enemy.IdlePath.Count));
                                DrawLine(new Vector2(obj.Value.enemy.IdlePath[i].X + 15, obj.Value.enemy.IdlePath[i].Y + 15), new Vector2(obj.Value.enemy.IdlePath[i + 1].X + 15, obj.Value.enemy.IdlePath[i + 1].Y + 15), spriteBatch, new Color(rgb, 0, 0));
                            }
                        }
                    }
                }
            }
            //draw start location
            Main par = Parent as Main;
            if (PaintStartLocation)
            {
                if (par.LevelOf.StartLocation != null)
                {
                    if (par.CurrentRoom == par.LevelOf.StartRoom && par.CurrentRoom != null)
                    {
                        spriteBatch.DrawString(spriteFont, "START", par.LevelOf.StartLocation + ViewportOffset, Color.Black);
                    }
                }
            }

            spriteBatch.End();
        }

        private void DrawLine(Vector2 start, Vector2 end, SpriteBatch spriteBatch, Color lineColor)
        {
            Vector2 direction = new Vector2(end.X - start.X, end.Y - start.Y);
            float rotation = (float)Math.Atan2(direction.Y, direction.X);
            spriteBatch.Draw(blackPixel, new Rectangle((int)(ViewportOffset.X + start.X), (int)(ViewportOffset.Y + start.Y), (int)Vector2.Distance(start, end), 2), null, lineColor, rotation, new Vector2(0, 0), SpriteEffects.None, 0.1f);
        }

        private void NodeClickedEvent(TileNode node)
        {
            if (NodeClicked != null)
                NodeClicked(this, new NodeClickedEventArgs(node));
        }


#region events
        protected override void OnMouseMove(MouseEventArgs e)
        {

            Vector2 tLoc;
            int mx = e.X; //(int)(e.X * (1/ cam.Zoom));
            int my = e.Y; // (int)(e.X * (1 / cam.Zoom));
            int vx = (int)ViewportOffset.X;
            int vy = (int)ViewportOffset.Y;
            int x = (mx - (int)vx) - (mx - (int)vx) % 30;
            int y = (my - (int)vy) - (my - (int)vy) % 30;
            tLoc = new Vector2(x, y);
            TileNode node = SelectTile(tLoc);
            if (node != lastToggledNode)
            {
                if (node != null)
                {
                    if (selection != node)
                    {
                        if (selection != null)
                            selection.Selected = false;
                        node.Selected = true;
                        selection = node;
                    }
                }
                if (Control.MouseButtons == System.Windows.Forms.MouseButtons.Left)
                {
                    if (node != null)
                        NodeClickedEvent(node);
                }
            }
            if (Control.MouseButtons == System.Windows.Forms.MouseButtons.Middle)
            {
                ViewportOffset.X -= prevMouseLoc.X - e.Location.X;
                ViewportOffset.Y -= prevMouseLoc.Y - e.Location.Y;
            }
            prevMouseLoc = e.Location;
            lastToggledNode = node;
            this.Invalidate(); //redraw
            base.OnMouseMove(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            Vector2 tLoc;
            int x = (e.X - (int)ViewportOffset.X) - (e.X - (int)ViewportOffset.X) % 30;
            int y = (e.Y - (int)ViewportOffset.Y) - (e.Y - (int)ViewportOffset.Y) % 30;
            tLoc = new Vector2(x, y);
            TileNode node = SelectTile(tLoc);
            if (node != null && e.Button == System.Windows.Forms.MouseButtons.Left)
                NodeClickedEvent(node);
            if (node != null && e.Button == System.Windows.Forms.MouseButtons.Right)
                if (NodeRightClicked != null)
                    NodeRightClicked(this, new NodeClickedEventArgs(node));
            base.OnMouseDown(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            prevMouseLoc.X = MousePosition.X;
            prevMouseLoc.Y = MousePosition.Y;
            //this.Focus();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            float zoomplus = .01f * e.Delta / 120;
            cam.Zoom += zoomplus;
            this.Invalidate();
            base.OnMouseWheel(e);
        }

        protected override void OnResize(EventArgs e)
        {
            if (cam != null)
            {
                cam.Pos = new Vector2(this.Width / 2, this.Height / 2);
            }
            base.OnResize(e);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            if (cam != null)
            {
                cam.Zoom = 1f;
            }
            base.OnMouseDoubleClick(e);
        }

#endregion //Events
    }

    class NodeClickedEventArgs : EventArgs
    {
        public TileNode node;
        public NodeClickedEventArgs(TileNode aNode)
            : base()
        {
            node = aNode;
        }
    }
}
