using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Xml;

namespace KSlevelDesigner
{
    public partial class Main : Form
    {
        //Level & current room
        Level level;
        Room currentRoom;
        TileNode newRoomExit = null;

        int defaultTileHeight = 30;
        int defaultTileWidth = 30;

        //edit modes
        public const String Locked = "Locked (no edits)";
        public const String EditTiles = "Edit Tiles & Overlays";
        public const String EditHit = "Edit Hit";
        public const String EditEnemies = "Edit Enemies";
        public const String EditLevelExits = "Edit Level Exits";
        public const String EditLevelStart = "Edit level Start Location";
        public const String EditRoomExits = "Edit Room Exits";

        private bool enemyPathsMode = false;
        private Enemy enemySettingPathFor;

        //tile sets
        public const string TilesLevel = "Level tiles";
        public const string TilesOverlays = "Overlays";
        public const string TilesEnemies = "Enemies";

        //different tile lists
        List<ListViewItem> floorCollection;
        ImageList floorImages;
        List<ListViewItem> overlayCollection;
        ImageList overlayImages;
        List<ListViewItem> enemyCollection;
        ImageList enemyImages;

        String SaveFileName = null;

        //content
        public ContentManager content;
        ContentBuilder contentBuilder;
        
        //selected enemy
        Enemy prevSelectedEnemy;

        public Main(String fileName)
        {
            iniMain();
            OpenLevel(fileName);
        }

        public Main()
        {
            iniMain();
            NewLevel newLevel = new NewLevel();
            newLevel.RoomCreated += new NewLevel.RommCreatedEventHandler(newLevel_RoomCreated);
            newLevel.ShowDialog(this);
        }

        private void iniMain()
        {
            //initialize lists
            floorCollection = new List<ListViewItem>();
            floorImages = new ImageList();
            floorImages.ImageSize = new Size(30, 30);
            overlayCollection = new List<ListViewItem>();
            overlayImages = new ImageList();
            overlayImages.ImageSize = new Size(30, 30);
            enemyCollection = new List<ListViewItem>();
            enemyImages = new ImageList();
            enemyImages.ImageSize = new Size(30, 30);
            //Initialize form controls
            InitializeComponent();

            //Initialize edit modes
            cmbEditMode.Items.Add(EditTiles);
            cmbEditMode.Items.Add(EditHit);
            cmbEditMode.Items.Add(EditEnemies);
            cmbEditMode.Items.Add(EditLevelStart);
            cmbEditMode.Items.Add(EditRoomExits);
            cmbEditMode.Items.Add(EditLevelExits);
            cmbEditMode.Items.Add(Locked);
            cmbEditMode.SelectedItem = EditTiles;
            //Initialize tile sets box
            cmbTileType.Items.Add(TilesLevel);
            cmbTileType.Items.Add(TilesOverlays);
            cmbTileType.Items.Add(TilesEnemies);
            cmbTileType.SelectedItem = TilesLevel;
            //initialize imagelist in listview
            listTiles.View = View.SmallIcon;
            spriteGraphicsControl1.NodeClicked += new SpriteGraphicsControl.NodeClickedEventHandler(spriteGraphicsControl1_NodeClicked);
            spriteGraphicsControl1.NodeRightClicked += new SpriteGraphicsControl.NodeClickedEventHandler(spriteGraphicsControl1_NodeRightClicked);

            //Content
            //contentBuilder = new ContentBuilder();
            content = new ContentManager(spriteGraphicsControl1.Services, "Content");
            spriteGraphicsControl1.content = content;
            //contentBuilder.Add(@"C:\Users\Rory\Documents\Visual Studio 2010\Projects\KSlevelDesigner\KSlevelDesigner\Text.spritefont", "Text", null, null);
            //string buildError = contentBuilder.Build();

            try
            {
                openFileDialogRoom.InitialDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not set initial directory", "Error");
            }

            timer1.Start();
        }

        void spriteGraphicsControl1_NodeRightClicked(object sender, NodeClickedEventArgs e)
        {
            NodeInfo nodeInfo = new NodeInfo(e.node);
            nodeInfo.ShowDialog();
        }

        public Level LevelOf
        {
            get { return level; }
        }

        public Room CurrentRoom
        {
            get { return currentRoom; }
        }

        void spriteGraphicsControl1_NodeClicked(object sender, NodeClickedEventArgs e)
        {
            if (enemyPathsMode == true)
            {
                EditPathsModeAddWaypoint(e.node.Location);
                return;
            }
            switch (GetEditState())
            {
                case Main.Locked:
                    return;
                case Main.EditTiles:
                    if (listTiles.Items.Count == 0 || listTiles.SelectedItems.Count == 0)
                        return;
                    string filename = listTiles.SelectedItems[0].SubItems[1].Text;
                    switch (GetTileNodeType())
                    {
                        case Main.TilesLevel:
                            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                            {
                               e.node.floor = Texture2D.FromStream(spriteGraphicsControl1.GraphicsDevice, fs);
                               e.node.floorName = Path.GetFileName(filename);
                            }
                            break;
                        case Main.TilesOverlays:
                            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                            {

                                if (e.node.overlayName != Path.GetFileName(filename))
                                {
                                    e.node.Overlay = Texture2D.FromStream(spriteGraphicsControl1.GraphicsDevice, fs);
                                    e.node.overlayName = Path.GetFileName(filename);
                                }
                                else
                                {
                                    //if already has an overlay and its this one, delete it
                                    if (e.node.Overlay != null)
                                    {
                                        e.node.Overlay = null;
                                        e.node.overlayName = "";
                                    }
                                }
                            }
                            break;
                    }
                    spriteGraphicsControl1.Invalidate(); //redraw
                    break;
                case Main.EditHit:
                    try
                    {
                        e.node.ToggleHit();
                    }
                    catch (InvalidStartLocationException ex)
                    {
                        MessageBox.Show(ex.Message, "Cannot change hit");
                        e.node.ToggleHit(); //set it back to what it was
                    }
                    break;
                case Main.EditEnemies:
                    if (GetTileNodeType() != Main.TilesEnemies)
                        return;
                    if (e.node.enemy != null) //remove enemy
                    {
                        e.node.enemy = null;
                    }
                    else
                    {
                        string efilename = listTiles.SelectedItems[0].SubItems[1].Text;
                        using (FileStream fs = new FileStream(efilename, FileMode.Open, FileAccess.Read))
                        {
                            Enemy enemy = new Enemy(e.node, listTiles.SelectedItems[0].SubItems[0].Text, Texture2D.FromStream(spriteGraphicsControl1.GraphicsDevice, fs), efilename);
                            if (e.node.SetEnemy(enemy) == false)
                                MessageBox.Show("Not a valid spot for an enemy.", "Cannot place enemy");
                        }
                    }
                    break;
                case Main.EditLevelExits:
                    if (level.NumberOfRooms <= 1)
                        MessageBox.Show("Cannot add an exit to a level with only 1 or less rooms.", "Cannot add exit");
                    break;
                case Main.EditLevelStart:
                    if (level.StartLocation == null)
                    {
                        level.SetStartLocation(currentRoom, e.node.Location.X, e.node.Location.Y);
                    }
                    else
                    {
                        if (MessageBox.Show("Delete Current start location and set it here?", "Redefine Start location", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            level.SetStartLocation(currentRoom, e.node.Location.X, e.node.Location.Y);
                        }
                    }
                    break;
                case Main.EditRoomExits:
                    if (newRoomExit == null)
                    {
                        newRoomExit = e.node;
                        MessageBox.Show("Choose the room and click a tile in that room to set exit there.", "Select Exit Location");
                    }
                    else
                    {
                        newRoomExit.AddRoomExit(currentRoom, e.node);
                        newRoomExit = null;
                        MessageBox.Show("Room exit set!", "Room Exit Set");
                    }
                    break;
            }
        }

        private void EditPathsModeAddWaypoint(Vector2 vector2)
        {
            enemySettingPathFor.AddPathNode(vector2);
        }

        private void menuNewRoom_Click(object sender, EventArgs e)
        {
            NewRoom newroom = new NewRoom();
            newroom.NewRoomCreated += newRoomCallback;

            newroom.ShowDialog();
        }

        public void newRoomCallback(Object sender, NewRoomCreatedEventArgs e)
        {
            spriteGraphicsControl1.NewList();
            CreateRoom(e.newroom);
        }

        private void CreateRoom(newRoomType roomType)
        {
            Texture2D tex;
            using (FileStream fs = new FileStream(roomType.defaultTile, FileMode.Open, FileAccess.Read))
            {
                tex = Texture2D.FromStream(spriteGraphicsControl1.GraphicsDevice, fs);
            }
            for (int i = 0; i < roomType.rows; i++)
            {
                for (int j = 0; j < roomType.columns; j++)
                {
                    TileNode node = new TileNode(new Vector2(i * 30, j * 30), tex);
                    node.floorName = Path.GetFileName(roomType.defaultTile);
                    spriteGraphicsControl1.AddDrawableObject(node);
                    node.AddedEnemy += new TileNode.EnemyAddedEventHandler(node_AddedEnemy);
                }
            }
            //Create and add room to level
            Room aRoom = new Room(spriteGraphicsControl1.NodeList);
            aRoom.Name = roomType.roomName;
            currentRoom = aRoom;
            level.AddRoom(aRoom);
            cmbCurrentRoom.Items.Add(aRoom.Name);
            cmbCurrentRoom.SelectedItem = aRoom.Name;

            spriteGraphicsControl1.Invalidate();
        }

        void node_AddedEnemy(object sender, Enemy e)
        {
            cmbEnemies.Items.Add(e);
            lblEnemies.Text = cmbEnemies.Items.Count.ToString("0000") + " Enemies:";
        }

        public void tileClicked(object sender, EventArgs e)
        {
            ////if locked, get out
            //if (cmbEditMode.SelectedItem.ToString() == Locked)
            //    return;

            ////Cast object
            //PictureBox pic = sender as PictureBox;
            //if (pic == null)
            //{
            //    MessageBox.Show("Failed cast as picturebox");
            //    return;
            //}

            ////Change selection
            ////in the case where the selected item is the current one, deselect it
            //if (selectedItemPicture == pic)
            //{
            //    selectedItemPicture = null;
            //    pic.BorderStyle = BorderStyle.None;
            //}
            //pic.BorderStyle = BorderStyle.Fixed3D;
            //if (selectedItemPicture != null)
            //    selectedItemPicture.BorderStyle = BorderStyle.None;
            //selectedItemPicture = pic;

            ////Perform action based on edit mode
            //TileBlock block = RoomOne.FindByPictureBox(pic);
            //switch(cmbEditMode.SelectedItem.ToString())
            //{
            //    case EditTiles:
            //        //change the clicked tile to the currently selected tile
            //        if (selectedItemTileSet != null)
            //        {
            //            //block.Sprite = ;
            //            block.setImage(selectedItemTileSet.Image, selectedItemTileSet.TileImageFileName);
            //        }
            //        break;
            //    case EditHit:
            //        if (block != null)
            //        {
            //            block.hitDetection = !block.hitDetection;
            //            block.Pic.Invalidate();
            //        }
            //        break;
            //}

        }

        private void AddTileToList(string tilename, string filename)
        {
            ListViewItem item = new ListViewItem(tilename, listTiles.SmallImageList.Images.Count);
            item.SubItems.Add(filename);
            switch (cmbTileType.SelectedItem.ToString())
            {
                case TilesLevel:
                    //create
                    floorImages.Images.Add(Bitmap.FromFile(filename));
                    floorCollection.Add(item);
                    listTiles.SmallImageList = floorImages;
                    break;
                case TilesOverlays:
                    //create
                    overlayImages.Images.Add(Bitmap.FromFile(filename));
                    overlayCollection.Add(item);
                    listTiles.SmallImageList = overlayImages;
                    break;
                case TilesEnemies:
                    //create
                    enemyImages.Images.Add(Bitmap.FromFile(filename));
                    enemyCollection.Add(item);
                    listTiles.SmallImageList = enemyImages;
                    break;
            }
            //add item to list
            listTiles.Items.Add(item);
        }

        private void btnAddTile_Click(object sender, EventArgs e)
        {
            if (cmbTileType.SelectedItem.ToString() == TilesEnemies)
            {
                AddEnemy addEnemy = new AddEnemy();
                addEnemy.AddedEnemy += new AddEnemy.AddedEnemyEventHandler(addEnemy_AddedEnemy);
                addEnemy.ShowDialog();
            }
            else if (cmbTileType.SelectedItem.ToString() == TilesLevel || cmbTileType.SelectedItem.ToString() == TilesOverlays)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(openFileDialog1.FileName) == ".xml")
                    {
                        OpenTileList(openFileDialog1.FileName);
                    }
                    else
                    {
                        AddTileToList(Path.GetFileNameWithoutExtension(openFileDialog1.FileName), openFileDialog1.FileName);
                    }
                }
            }
        }

        void addEnemy_AddedEnemy(object sender, AddEnemyEventArgs e)
        {
            ListViewItem item = new ListViewItem(e.enemy.Type, enemyImages.Images.Count);
            item.SubItems.Add(e.enemy.Texture);
            enemyCollection.Add(item);
            enemyImages.Images.Add(Bitmap.FromFile(e.enemy.Texture));
            listTiles.Items.Add(item);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            int horizontalPadding = 25;
            int VerticalPadding = 55;
            spriteGraphicsControl1.Width = this.Width - spriteGraphicsControl1.Location.X - horizontalPadding;
            spriteGraphicsControl1.Height = this.Height - spriteGraphicsControl1.Location.Y - VerticalPadding;
            //tile list
            horizontalPadding = 75;
            listTiles.Height = this.Height - listTiles.Location.Y - horizontalPadding;
            btnSaveList.Location = new System.Drawing.Point(btnSaveList.Location.X, listTiles.Location.Y + listTiles.Height + 3);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getAndSaveFileAs();
        }

        private void getAndSaveFileAs()
        {
            string defaultName = "Level";
            string extension = ".xml";
            int i = 0;
            string Name = defaultName + i.ToString() + extension;
            while (File.Exists(Name) == true)
            {
                Name = defaultName + i.ToString() + extension;
                i++;
            }

            saveFileDialog1.FileName = Name;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                level.SaveLevelToXML(saveFileDialog1.FileName);
                SaveFileName = saveFileDialog1.FileName;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogRoom.InitialDirectory = @"C:\Users\Rory\Documents\Visual Studio 2010\Projects\KSlevelDesigner\KSlevelDesigner\bin\Debug";
            if (openFileDialogRoom.ShowDialog() == DialogResult.Cancel)
                return;
            OpenLevel(openFileDialogRoom.FileName);
        }

        private void OpenLevel(string fileName)
        {
            this.Cursor = Cursors.WaitCursor;
            cmbCurrentRoom.Items.Clear();
            cmbEnemies.Items.Clear();
            enemyPathsMode = false;
            enemySettingPathFor = null;
            try
            {
                level = new Level(fileName);
            }
            catch (Exception e)
            {
                MessageBox.Show("Doesn't seem to be a valid room file.  " + "Error: " + e.Message, "Error opening Level");
                this.Cursor = Cursors.Arrow;
                return;
            }

            spriteGraphicsControl1.AddTileNodeList(level.StartRoom.NodeList);

            currentRoom = level.StartRoom;
            foreach (Room r in level)
            {
                cmbCurrentRoom.Items.Add(r.Name);
                foreach (KeyValuePair<uint, TileNode> t in r.NodeList)
                {
                    t.Value.AddedEnemy += new TileNode.EnemyAddedEventHandler(node_AddedEnemy);
                }
            }
            cmbCurrentRoom.SelectedItem = currentRoom.Name;
            foreach (Enemy en in currentRoom.Enemies)
            {
                cmbEnemies.Items.Add(en);
            }
            lblEnemies.Text = cmbEnemies.Items.Count.ToString("0000") + " Enemies:";
            SaveFileName = fileName;
            enemyPathsMode = false;
            enemySettingPathFor = null;
            this.Cursor = Cursors.Arrow;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileName == null)
            {
                getAndSaveFileAs();
                return;
            }
            level.SaveLevelToXML(SaveFileName);
            MessageBox.Show("Saved to " + SaveFileName);
        }

        public ListView GetTileListView()
        {
            return listTiles;
        }

        public string GetEditState()
        {
            return cmbEditMode.SelectedItem.ToString();
        }

        private void SaveTileNodeLists()
        {
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SaveTileList(saveFileDialog1.FileName);
            }
        }

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            SaveTileNodeLists();
        }

        private void SaveTileList(string filename)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                //base node
                XmlNode nodes = xml.CreateNode(XmlNodeType.Element, "nodes", "");
                xml.AppendChild(nodes);
                //floortiles
                XmlNode floortiles = xml.CreateNode(XmlNodeType.Element, "floornodes", "");
                nodes.AppendChild(floortiles);
                //a floortile
                XmlElement tile;
                XmlElement name;
                XmlElement efilename;
                foreach (ListViewItem i in floorCollection)
                {
                    //base
                    tile = xml.CreateElement("floortile", "");
                    floortiles.AppendChild(tile);
                    //name
                    name = xml.CreateElement("name");
                    name.InnerText = i.SubItems[0].Text;
                    tile.AppendChild(name);
                    //filename
                    efilename = xml.CreateElement("filename");
                    efilename.InnerText = i.SubItems[1].Text;
                    tile.AppendChild(efilename);
                }
                //Overlays
                XmlNode overlaytiles = xml.CreateNode(XmlNodeType.Element, "overlaynodes", "");
                nodes.AppendChild(overlaytiles);
                foreach (ListViewItem i in overlayCollection)
                {
                    //base
                    tile = xml.CreateElement("overlaytile", "");
                    overlaytiles.AppendChild(tile);
                    //name
                    name = xml.CreateElement("name");
                    name.InnerText = i.SubItems[0].Text;
                    tile.AppendChild(name);
                    //filename
                    efilename = xml.CreateElement("filename");
                    efilename.InnerText = i.SubItems[1].Text;
                    tile.AppendChild(efilename);
                }
                //enemies
                XmlNode enemies = xml.CreateNode(XmlNodeType.Element, "enemynodes", "");
                nodes.AppendChild(enemies);
                foreach (ListViewItem i in enemyCollection)
                {
                    //base
                    tile = xml.CreateElement("enemy", "");
                    enemies.AppendChild(tile);
                    //name
                    name = xml.CreateElement("name");
                    name.InnerText = i.SubItems[0].Text;
                    tile.AppendChild(name);
                    //filename
                    efilename = xml.CreateElement("filename");
                    efilename.InnerText = i.SubItems[1].Text;
                    tile.AppendChild(efilename);
                }
                xml.Save(filename);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void OpenTileList(string filename)
        {
            XmlDocument xml = new XmlDocument();
            try
            {
                xml.Load(filename);
                listTiles.Clear();
                //floor tiles
                floorCollection.Clear();
                XmlNodeList nodes = xml.GetElementsByTagName("floortile");
                cmbTileType.SelectedItem = TilesLevel;
                foreach (XmlElement i in nodes)
                {
                    AddTileToList(i.SelectSingleNode("name").InnerText, i.SelectSingleNode("filename").InnerText);
                }
                //overlay tiles
                overlayCollection.Clear();
                nodes = xml.GetElementsByTagName("overlaytile");
                cmbTileType.SelectedItem = TilesOverlays;
                foreach (XmlElement i in nodes)
                {
                    AddTileToList(i.SelectSingleNode("name").InnerText, i.SelectSingleNode("filename").InnerText);
                }
                //enemies
                enemyCollection.Clear();
                nodes = xml.GetElementsByTagName("enemy");
                cmbTileType.SelectedItem = TilesEnemies;
                foreach (XmlElement i in nodes)
                {
                    AddTileToList(i.SelectSingleNode("name").InnerText, i.SelectSingleNode("filename").InnerText);
                }
                cmbTileType.SelectedItem = TilesLevel;
            }
            catch (Exception e)
            {
                MessageBox.Show("Not a valid Tile list.  Did you open a level file by accident?", "Invalid File Format");
            }
        }
        
        private void cmbTileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            listTiles.Items.Clear();
            switch (cmbTileType.SelectedItem.ToString())
            {
                case TilesLevel:
                    listTiles.Items.AddRange(floorCollection.ToArray());
                    listTiles.SmallImageList = floorImages;
                    break;
                case TilesOverlays:
                    listTiles.Items.AddRange(overlayCollection.ToArray());
                    listTiles.SmallImageList = overlayImages;
                    break;
                case TilesEnemies:
                    listTiles.Items.AddRange(enemyCollection.ToArray());
                    listTiles.SmallImageList = enemyImages;
                    break;
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveTileNodeLists();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OpenTileList(openFileDialog1.FileName);
            }
        }

        public string GetTileNodeType()
        {
            return cmbTileType.SelectedItem.ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //load spritefont
            spriteGraphicsControl1.Font = content.Load<SpriteFont>("DamageFont");
        }

        void newLevel_RoomCreated(object sender, CreateRoomEventArgs e)
        {
            level = new Level(e.levelName, true);
        }

        private void cmbCurrentRoom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentRoom = level.GetRoomByName(cmbCurrentRoom.Text);
            spriteGraphicsControl1.AddTileNodeList(currentRoom.NodeList);
            cmbEnemies.Items.Clear();
            foreach (Enemy en in currentRoom.Enemies)
            {
                cmbEnemies.Items.Add(en);
            }
            lblEnemies.Text = cmbEnemies.Items.Count.ToString("0000") + " Enemies:";
        }

        private void showStartLocationToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            spriteGraphicsControl1.PaintStartLocation = showStartLocationToolStripMenuItem.Checked;
        }

        private void cmbEditMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(newRoomExit != null)
            {
                newRoomExit = null;
                MessageBox.Show("Set room exit canceled.", "Set Exit Canceled");
            }
        }

        private void luanchEnemyDesignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnemyDesigner enemyD = new EnemyDesigner();
            enemyD.ShowDialog();
        }

        private void cmbEnemies_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Enemy enemy = cmbEnemies.SelectedItem as Enemy;
            if (enemy != null)
            {
                spriteGraphicsControl1.CenterOn(enemy.onNode.Location);
                enemy.selected = true;
                if (prevSelectedEnemy != null)
                {
                    prevSelectedEnemy.selected = false;
                }
                prevSelectedEnemy = enemy;
            }
        }

        private void showStartLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spriteGraphicsControl1.PaintStartLocation = showStartLocationToolStripMenuItem.Checked;
        }

        private void addPathToSelectedEnemyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (enemyPathsMode == true)
            {
                enemyPathsMode = false;
                addPathToSelectedEnemyToolStripMenuItem.Text = "Add Path to selected Enemy";
                enemySettingPathFor = null;
                return;
            }
            Enemy enemy = cmbEnemies.SelectedItem as Enemy;
            if (enemy != null)
                spriteGraphicsControl1.CenterOn(enemy.onNode.Location);
            //edit mode change
            enemyPathsMode = true;
            enemySettingPathFor = enemy;
            if (enemySettingPathFor == null)
            {
                MessageBox.Show("No enemy selected, select an enemy from the dropdown list and try again.", "No enemy Selected");
                enemyPathsMode = false;
                return;
            }
            addPathToSelectedEnemyToolStripMenuItem.Text = "Finish Enemy Path";
            if (enemy.IdlePath == null)
            {
                EditPathsModeAddWaypoint(enemy.onNode.Location);
            }
        }

        private void showEnemyPathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spriteGraphicsControl1.ShowEnemyPaths = showEnemyPathsToolStripMenuItem.Checked;
        }

        private void allEnemiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allEnemiesToolStripMenuItem.Checked = true;
            onlySelectedEnemyToolStripMenuItem.Checked = false;
            spriteGraphicsControl1.ShowEnemyPathSelected = false;
        }

        private void onlySelectedEnemyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onlySelectedEnemyToolStripMenuItem.Checked = true;
            allEnemiesToolStripMenuItem.Checked = false;
            spriteGraphicsControl1.ShowEnemyPathSelected = true;
        }
    }
}
