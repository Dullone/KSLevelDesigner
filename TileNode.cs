using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Xml;

namespace KSlevelDesigner
{
    public class TileNode
    {
        public const int width = 30;
        public const int height = 30;
        public const int maxWidthAndHeight = 10000;

        #region Variables
        //Variables
        bool hit = false;
        bool selected = false;
        uint compareValue;

        //drawable stuff
        public Texture2D floor;
        public string floorName;
        public Texture2D Overlay;
        public string overlayName;
        public Enemy enemy;

        //Room exit
        RoomExit roomExit;

        //Coords
        Vector2 location;
        Vector2 screenLocation;

        //Colors
        Color paintColor;
        readonly Color selectedColor;
        Color defaultColor = Color.White;

        //Events
        public delegate void HitChangedEventHandler(object sender, EventArgs e);
        public event HitChangedEventHandler HitChanged;
        public delegate void EnemyAddedEventHandler(object sender, Enemy e);
        public event EnemyAddedEventHandler AddedEnemy;

        #endregion //variables

        public TileNode(Vector2 tileLocation, Texture2D floorTexture)
        {
            location = tileLocation;
            floor = floorTexture;
            screenLocation = new Vector2(tileLocation.X, tileLocation.Y);
            paintColor = Color.White;
            selectedColor = new Color(120,120,120,255);
            Overlay = null;
            //Compare value should be xxx,yyy;  so x:300 y:210 would be 300,210
            compareValue = (uint)(tileLocation.X * maxWidthAndHeight + tileLocation.Y);
            floorName = "";
            overlayName = "";
        }

        public TileNode(XmlNode node, List<RoomExitsQueueItem> exitsQueue)
        {
            paintColor = defaultColor;
            selectedColor = new Color(120, 120, 120, 255);
            hit = Convert.ToBoolean(node.SelectSingleNode("hit").InnerText);
            location.X = (float)Convert.ToDouble(node.SelectSingleNode("x").InnerText);
            location.Y = (float)Convert.ToDouble(node.SelectSingleNode("y").InnerText);
            floorName = node.SelectSingleNode("floortexture").InnerText;
            XmlNode overlayNameElement = node.SelectSingleNode("overlaytexture");
            if (overlayNameElement != null)
            {
                overlayName = overlayNameElement.InnerText;
            }
            compareValue = (uint)(location.X * maxWidthAndHeight + location.Y);
            XmlNode enemyElement = node.SelectSingleNode("enemy");
            if (enemyElement != null)
            {
                string type, tex;
                type = enemyElement.SelectSingleNode("type").InnerText;
                tex = enemyElement.SelectSingleNode("texture").InnerText;
                Enemy = new Enemy(type, tex, this);
                XmlNode idlepath = enemyElement.SelectSingleNode("path");
                if (idlepath != null)
                {
                    XmlNodeList pathX = idlepath.SelectNodes("x");
                    XmlNodeList pathY = idlepath.SelectNodes("y");
                    for (int i = 0; i < pathX.Count; i++)
                    {
                        enemy.AddPathNode(new Vector2(Convert.ToInt32(pathX[i].InnerText), Convert.ToInt32(pathY[i].InnerText)));
                    }
                }
            }
            XmlNode roomExitElement = node.SelectSingleNode("roomexit");
            if (roomExitElement != null)
            {
                RoomExitsQueueItem exit = new RoomExitsQueueItem();
                exit.fromNode = this;
                //to room
                exit.toRoom = roomExitElement.SelectSingleNode("toroom").InnerText;
                //toloc
                XmlNode toLoc = roomExitElement.SelectSingleNode("tolocation");
                XmlNode x = toLoc.SelectSingleNode("x");
                XmlNode y = toLoc.SelectSingleNode("y");
                exit.toLocation = new Vector2((float)Convert.ToDouble(x.InnerText), (float)Convert.ToDouble(y.InnerText));

                //add to queue
                exitsQueue.Add(exit);
            }
        }

        public uint CompareValue
        {
            get { return compareValue;}
        }

        public static int Compare(TileNode x, TileNode y)
        {
            if (x.compareValue < y.compareValue)
                return -1;
            else if (x.compareValue > y.compareValue)
                return 1;
            else //equal
                return 0;
        }

        #region Properties
        //Properties
        public bool Selected
        {
            get { return selected; }
            set 
            {
                selected = value;
                if (selected == true)
                {
                    paintColor = selectedColor;
                }
                else
                {
                    paintColor = defaultColor;
                }
            } 
        }

        private Enemy Enemy
        {
            set
            {
                enemy = value;
                if (AddedEnemy != null)
                    AddedEnemy(this, value);
            }
        }

        public Vector2 Location
        {
            get { return location; }
        }

        public bool Hit
        {
            get { return hit; }
        }

        public RoomExit roomexit
        {
            get { return roomExit; }
        }
        #endregion //properties
        #region Methods
        //Methods
        /// <summary>
        /// Sets the enemy for the tile.  Only one enemy per tile.  Setting 
        /// will overwrite the current enemy on the tile
        /// </summary>
        /// <param name="aEnemy">Enemy to add</param>
        /// <returns>If enemy add was successful</returns>
        public bool SetEnemy(Enemy aEnemy)
        {
            //can't place an enemy on a tile with hit
            if (hit == true)
                return false;
            Enemy = aEnemy;
            return true;
        }
        /// <summary>
        /// Toggles hit on/off for the tile
        /// </summary>
        /// <returns>Current hit on tile</returns>
        public bool ToggleHit()
        {
            //can't set a tile to hit if it has an enemy
            if (enemy != null)
                return false;
            hit = !hit;
            if (HitChanged != null)
                HitChanged(this, new EventArgs());
            return hit;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 offset, SpriteFont font, Rectangle rec)
        {
            screenLocation = location + offset;
            if (CheckIfOnscreen(screenLocation, width, height, rec) == false)
                return;
            //draw floor
            spriteBatch.Draw(floor, screenLocation, null, paintColor, 0f,new Vector2(0,0), 1f, SpriteEffects.None, 1f);
            //draw overlay
            if (Overlay != null)
            {
                spriteBatch.Draw(Overlay, screenLocation, null, paintColor, 0f, new Vector2(0,0), 1f, SpriteEffects.None, 0.5f);
            }
            if (hit == true)
            {
                spriteBatch.DrawString(font, "HIT", screenLocation, Color.White, 0f, new Vector2(0,0),1f, SpriteEffects.None, 0);
                spriteBatch.DrawString(font, "HIT", new Vector2(screenLocation.X, screenLocation.Y + 15), Color.Black, 0f, new Vector2(0,0),1f, SpriteEffects.None,0);
            }
            if (enemy != null)
            {
                enemy.Draw(spriteBatch, screenLocation, paintColor);
            }
            if (roomExit != null)
            {
                spriteBatch.DrawString(font, "Room",screenLocation, Color.Red);
                spriteBatch.DrawString(font, "Exit",screenLocation + new Vector2(0,10), Color.Red);
            }
        }

        public bool AddRoomExit(Room toRoom, TileNode tilenode)
        {
            if (tilenode.Hit == true) //not a valid exit point
            {
                return false;
            }
            roomExit = new RoomExit();
            roomExit.exitLoc = tilenode;
            roomExit.leadsToRoom = toRoom;
            return true;
        }

        public XmlElement SaveNodeToXML(XmlDocument xml)
        {
            XmlElement TileNodeElement = xml.CreateElement("node");
            //hit
            XmlElement hitElement = xml.CreateElement("hit");
            hitElement.InnerText = hit.ToString();
            TileNodeElement.AppendChild(hitElement);
            //location
            XmlElement locatx = xml.CreateElement("x");
            locatx.InnerText = location.X.ToString();
            TileNodeElement.AppendChild(locatx);
            XmlElement locaty = xml.CreateElement("y");
            locaty.InnerText = location.Y.ToString();
            TileNodeElement.AppendChild(locaty);
            //floor tile
            XmlElement floorElement = xml.CreateElement("floortexture");
            floorElement.InnerText = floorName;
            TileNodeElement.AppendChild(floorElement);
            //overlay
            if (overlayName != null && overlayName != "")
            {
                XmlElement overlayElement = xml.CreateElement("overlaytexture");
                overlayElement.InnerText = overlayName;
                TileNodeElement.AppendChild(overlayElement);
            }

            //enemies
            if (enemy != null)
            {
                XmlElement enemyElement = xml.CreateElement("enemy");
                TileNodeElement.AppendChild(enemyElement);
                XmlElement enemyType = xml.CreateElement("type");
                enemyType.InnerText = enemy.Type;
                enemyElement.AppendChild(enemyType);
                XmlElement enemyTexture = xml.CreateElement("texture");
                enemyTexture.InnerText = enemy.TextureString;
                enemyElement.AppendChild(enemyTexture);

                if (enemy.IdlePath != null)
                {
                    XmlElement idlePath = xml.CreateElement("path");
                    foreach (Vector2 wayP in enemy.IdlePath)
                    {
                        XmlElement x = xml.CreateElement("x");
                        XmlElement y = xml.CreateElement("y");
                        x.InnerText = wayP.X.ToString();
                        y.InnerText = wayP.Y.ToString();
                        idlePath.AppendChild(x);
                        idlePath.AppendChild(y);
                    }
                    enemyElement.AppendChild(idlePath);
                }
            }
            if (roomExit != null)
            {
                XmlElement exitElement = xml.CreateElement("roomexit");
                TileNodeElement.AppendChild(exitElement);
                //To room
                XmlElement toRoom = xml.CreateElement("toroom");
                toRoom.InnerText = roomExit.leadsToRoom.Name;
                exitElement.AppendChild(toRoom);
                //To location
                XmlElement toLocation = xml.CreateElement("tolocation");
                exitElement.AppendChild(toLocation);
                //to location x
                XmlElement toLocationx = xml.CreateElement("x");
                toLocationx.InnerText = roomExit.exitLoc.Location.X.ToString();
                toLocation.AppendChild(toLocationx);
                //to location y
                XmlElement toLocationy = xml.CreateElement("y");
                toLocationy.InnerText = roomExit.exitLoc.Location.Y.ToString();
                toLocation.AppendChild(toLocationy);
            }

            //floating text

            return TileNodeElement;
        }

        public void RemoveExit()
        {
            roomExit = null;
        }

        public static bool CheckIfOnscreen(Vector2 pos, int width, int height, Rectangle screen)
        {
            return
                !(pos.Y + height < screen.Top ||
                pos.Y > screen.Bottom ||
                pos.X > screen.Right ||
                pos.X + width < screen.Left);
        }
        #endregion //methods
    }

    public class RoomExit
    {
        public Room leadsToRoom;
        public TileNode exitLoc;

        public RoomExit()
        {
        }
    }
}
