namespace KSlevelDesigner
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddTile = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStartLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEnemyPathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlySelectedEnemyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allEnemiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enemiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luanchEnemyDesignerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPathToSelectedEnemyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbEditMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogRoom = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbTileType = new System.Windows.Forms.ComboBox();
            this.listTiles = new System.Windows.Forms.ListView();
            this.btnSaveList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCurrentRoom = new System.Windows.Forms.ComboBox();
            this.lblEnemies = new System.Windows.Forms.Label();
            this.cmbEnemies = new System.Windows.Forms.ComboBox();
            this.spriteGraphicsControl1 = new KSlevelDesigner.SpriteGraphicsControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTile
            // 
            this.btnAddTile.Location = new System.Drawing.Point(8, 27);
            this.btnAddTile.Name = "btnAddTile";
            this.btnAddTile.Size = new System.Drawing.Size(50, 21);
            this.btnAddTile.TabIndex = 4;
            this.btnAddTile.Text = "Add..";
            this.btnAddTile.UseVisualStyleBackColor = true;
            this.btnAddTile.Click += new System.EventHandler(this.btnAddTile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLevelToolStripMenuItem,
            this.tileListToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.enemiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newLevelToolStripMenuItem
            // 
            this.newLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenLevel,
            this.menuNewRoom,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newLevelToolStripMenuItem.Name = "newLevelToolStripMenuItem";
            this.newLevelToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.newLevelToolStripMenuItem.Text = "File";
            // 
            // mnuOpenLevel
            // 
            this.mnuOpenLevel.Name = "mnuOpenLevel";
            this.mnuOpenLevel.Size = new System.Drawing.Size(152, 22);
            this.mnuOpenLevel.Text = "Open level...";
            this.mnuOpenLevel.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // menuNewRoom
            // 
            this.menuNewRoom.Name = "menuNewRoom";
            this.menuNewRoom.Size = new System.Drawing.Size(152, 22);
            this.menuNewRoom.Text = "New Room...";
            this.menuNewRoom.Click += new System.EventHandler(this.menuNewRoom_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tileListToolStripMenuItem
            // 
            this.tileListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1});
            this.tileListToolStripMenuItem.Name = "tileListToolStripMenuItem";
            this.tileListToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.tileListToolStripMenuItem.Text = "Tile list";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.openToolStripMenuItem1.Text = "Open..";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.saveToolStripMenuItem1.Text = "Save...";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStartLocationToolStripMenuItem,
            this.showEnemyPathsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // showStartLocationToolStripMenuItem
            // 
            this.showStartLocationToolStripMenuItem.Checked = true;
            this.showStartLocationToolStripMenuItem.CheckOnClick = true;
            this.showStartLocationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showStartLocationToolStripMenuItem.Name = "showStartLocationToolStripMenuItem";
            this.showStartLocationToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.showStartLocationToolStripMenuItem.Text = "Show Start Location";
            this.showStartLocationToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.showStartLocationToolStripMenuItem_CheckStateChanged);
            this.showStartLocationToolStripMenuItem.Click += new System.EventHandler(this.showStartLocationToolStripMenuItem_Click);
            // 
            // showEnemyPathsToolStripMenuItem
            // 
            this.showEnemyPathsToolStripMenuItem.Checked = true;
            this.showEnemyPathsToolStripMenuItem.CheckOnClick = true;
            this.showEnemyPathsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showEnemyPathsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlySelectedEnemyToolStripMenuItem,
            this.allEnemiesToolStripMenuItem});
            this.showEnemyPathsToolStripMenuItem.Name = "showEnemyPathsToolStripMenuItem";
            this.showEnemyPathsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.showEnemyPathsToolStripMenuItem.Text = "Show Enemy Paths";
            this.showEnemyPathsToolStripMenuItem.Click += new System.EventHandler(this.showEnemyPathsToolStripMenuItem_Click);
            // 
            // onlySelectedEnemyToolStripMenuItem
            // 
            this.onlySelectedEnemyToolStripMenuItem.Name = "onlySelectedEnemyToolStripMenuItem";
            this.onlySelectedEnemyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.onlySelectedEnemyToolStripMenuItem.Text = "Only Selected Enemy";
            this.onlySelectedEnemyToolStripMenuItem.Click += new System.EventHandler(this.onlySelectedEnemyToolStripMenuItem_Click);
            // 
            // allEnemiesToolStripMenuItem
            // 
            this.allEnemiesToolStripMenuItem.Checked = true;
            this.allEnemiesToolStripMenuItem.CheckOnClick = true;
            this.allEnemiesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allEnemiesToolStripMenuItem.Name = "allEnemiesToolStripMenuItem";
            this.allEnemiesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.allEnemiesToolStripMenuItem.Text = "All Enemies";
            this.allEnemiesToolStripMenuItem.Click += new System.EventHandler(this.allEnemiesToolStripMenuItem_Click);
            // 
            // enemiesToolStripMenuItem
            // 
            this.enemiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.luanchEnemyDesignerToolStripMenuItem,
            this.addPathToSelectedEnemyToolStripMenuItem});
            this.enemiesToolStripMenuItem.Name = "enemiesToolStripMenuItem";
            this.enemiesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.enemiesToolStripMenuItem.Text = "Enemies";
            // 
            // luanchEnemyDesignerToolStripMenuItem
            // 
            this.luanchEnemyDesignerToolStripMenuItem.Name = "luanchEnemyDesignerToolStripMenuItem";
            this.luanchEnemyDesignerToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.luanchEnemyDesignerToolStripMenuItem.Text = "Launch Enemy Designer";
            this.luanchEnemyDesignerToolStripMenuItem.Click += new System.EventHandler(this.luanchEnemyDesignerToolStripMenuItem_Click);
            // 
            // addPathToSelectedEnemyToolStripMenuItem
            // 
            this.addPathToSelectedEnemyToolStripMenuItem.Name = "addPathToSelectedEnemyToolStripMenuItem";
            this.addPathToSelectedEnemyToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addPathToSelectedEnemyToolStripMenuItem.Text = "Add Path to selected Enemy";
            this.addPathToSelectedEnemyToolStripMenuItem.Click += new System.EventHandler(this.addPathToSelectedEnemyToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "BlackBox.png";
            this.openFileDialog1.Filter = "Tile List (.xml)|*.xml|PNG (.png)|*.png|BMP|*.bmp";
            this.openFileDialog1.FilterIndex = 2;
            // 
            // cmbEditMode
            // 
            this.cmbEditMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEditMode.FormattingEnabled = true;
            this.cmbEditMode.Location = new System.Drawing.Point(684, 27);
            this.cmbEditMode.Name = "cmbEditMode";
            this.cmbEditMode.Size = new System.Drawing.Size(121, 21);
            this.cmbEditMode.TabIndex = 6;
            this.cmbEditMode.SelectionChangeCommitted += new System.EventHandler(this.cmbEditMode_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Edit Mode:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Room1.xml";
            this.saveFileDialog1.Filter = "XML Files (.xml)|*.xml";
            // 
            // openFileDialogRoom
            // 
            this.openFileDialogRoom.FileName = "Room.xml";
            this.openFileDialogRoom.Filter = "XML Files (.xml)|*.xml";
            // 
            // cmbTileType
            // 
            this.cmbTileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTileType.FormattingEnabled = true;
            this.cmbTileType.Location = new System.Drawing.Point(58, 27);
            this.cmbTileType.Name = "cmbTileType";
            this.cmbTileType.Size = new System.Drawing.Size(120, 21);
            this.cmbTileType.TabIndex = 8;
            this.cmbTileType.SelectedIndexChanged += new System.EventHandler(this.cmbTileType_SelectedIndexChanged);
            // 
            // listTiles
            // 
            this.listTiles.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listTiles.FullRowSelect = true;
            this.listTiles.GridLines = true;
            this.listTiles.Location = new System.Drawing.Point(8, 49);
            this.listTiles.MultiSelect = false;
            this.listTiles.Name = "listTiles";
            this.listTiles.Size = new System.Drawing.Size(170, 459);
            this.listTiles.TabIndex = 10;
            this.listTiles.UseCompatibleStateImageBehavior = false;
            // 
            // btnSaveList
            // 
            this.btnSaveList.Location = new System.Drawing.Point(8, 510);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(87, 21);
            this.btnSaveList.TabIndex = 11;
            this.btnSaveList.Text = "Save list...";
            this.btnSaveList.UseVisualStyleBackColor = true;
            this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Current Room:";
            // 
            // cmbCurrentRoom
            // 
            this.cmbCurrentRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrentRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCurrentRoom.FormattingEnabled = true;
            this.cmbCurrentRoom.Location = new System.Drawing.Point(265, 27);
            this.cmbCurrentRoom.Name = "cmbCurrentRoom";
            this.cmbCurrentRoom.Size = new System.Drawing.Size(121, 21);
            this.cmbCurrentRoom.TabIndex = 13;
            this.cmbCurrentRoom.SelectionChangeCommitted += new System.EventHandler(this.cmbCurrentRoom_SelectionChangeCommitted);
            // 
            // lblEnemies
            // 
            this.lblEnemies.AutoSize = true;
            this.lblEnemies.Location = new System.Drawing.Point(406, 30);
            this.lblEnemies.Name = "lblEnemies";
            this.lblEnemies.Size = new System.Drawing.Size(77, 13);
            this.lblEnemies.TabIndex = 14;
            this.lblEnemies.Text = "0000 Enemies:";
            // 
            // cmbEnemies
            // 
            this.cmbEnemies.FormattingEnabled = true;
            this.cmbEnemies.Location = new System.Drawing.Point(479, 27);
            this.cmbEnemies.Name = "cmbEnemies";
            this.cmbEnemies.Size = new System.Drawing.Size(135, 21);
            this.cmbEnemies.TabIndex = 15;
            this.cmbEnemies.SelectionChangeCommitted += new System.EventHandler(this.cmbEnemies_SelectionChangeCommitted);
            // 
            // spriteGraphicsControl1
            // 
            this.spriteGraphicsControl1.Location = new System.Drawing.Point(184, 49);
            this.spriteGraphicsControl1.Name = "spriteGraphicsControl1";
            this.spriteGraphicsControl1.PaintStartLocation = true;
            this.spriteGraphicsControl1.ShowEnemyPaths = true;
            this.spriteGraphicsControl1.ShowEnemyPathSelected = false;
            this.spriteGraphicsControl1.Size = new System.Drawing.Size(621, 459);
            this.spriteGraphicsControl1.TabIndex = 9;
            this.spriteGraphicsControl1.Text = "spriteGraphicsControl1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 543);
            this.Controls.Add(this.cmbEnemies);
            this.Controls.Add(this.lblEnemies);
            this.Controls.Add(this.cmbCurrentRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveList);
            this.Controls.Add(this.listTiles);
            this.Controls.Add(this.spriteGraphicsControl1);
            this.Controls.Add(this.cmbTileType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEditMode);
            this.Controls.Add(this.btnAddTile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "KS level designer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNewRoom;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenLevel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbEditMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialogRoom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbTileType;
        private SpriteGraphicsControl spriteGraphicsControl1;
        private System.Windows.Forms.ListView listTiles;
        private System.Windows.Forms.Button btnSaveList;
        private System.Windows.Forms.ToolStripMenuItem tileListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCurrentRoom;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStartLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enemiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luanchEnemyDesignerToolStripMenuItem;
        private System.Windows.Forms.Label lblEnemies;
        private System.Windows.Forms.ComboBox cmbEnemies;
        private System.Windows.Forms.ToolStripMenuItem addPathToSelectedEnemyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEnemyPathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlySelectedEnemyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allEnemiesToolStripMenuItem;
    }
}

