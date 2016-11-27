namespace KSlevelDesigner
{
    partial class NodeInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveOverlay = new System.Windows.Forms.Button();
            this.txtOverlay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFloorTexture = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHitToggle = new System.Windows.Forms.Button();
            this.txtHit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxEnemy = new System.Windows.Forms.GroupBox();
            this.btnRemoveEnemy = new System.Windows.Forms.Button();
            this.txtEnemyTexture = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnemyType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.boxExitInfo = new System.Windows.Forms.GroupBox();
            this.btnRemoveExit = new System.Windows.Forms.Button();
            this.txtExitLocation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExitToRoom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.boxEnemy.SuspendLayout();
            this.boxExitInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveOverlay);
            this.groupBox1.Controls.Add(this.txtOverlay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFloorTexture);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnHitToggle);
            this.groupBox1.Controls.Add(this.txtHit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtXY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Node";
            // 
            // btnRemoveOverlay
            // 
            this.btnRemoveOverlay.Location = new System.Drawing.Point(139, 122);
            this.btnRemoveOverlay.Name = "btnRemoveOverlay";
            this.btnRemoveOverlay.Size = new System.Drawing.Size(100, 22);
            this.btnRemoveOverlay.TabIndex = 9;
            this.btnRemoveOverlay.Text = "Remove Overlay";
            this.btnRemoveOverlay.UseVisualStyleBackColor = true;
            this.btnRemoveOverlay.Click += new System.EventHandler(this.btnRemoveOverlay_Click);
            // 
            // txtOverlay
            // 
            this.txtOverlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOverlay.Location = new System.Drawing.Point(81, 99);
            this.txtOverlay.Name = "txtOverlay";
            this.txtOverlay.ReadOnly = true;
            this.txtOverlay.Size = new System.Drawing.Size(158, 20);
            this.txtOverlay.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Overlay";
            // 
            // txtFloorTexture
            // 
            this.txtFloorTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFloorTexture.Location = new System.Drawing.Point(81, 73);
            this.txtFloorTexture.Name = "txtFloorTexture";
            this.txtFloorTexture.ReadOnly = true;
            this.txtFloorTexture.Size = new System.Drawing.Size(158, 20);
            this.txtFloorTexture.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Floor Texture";
            // 
            // btnHitToggle
            // 
            this.btnHitToggle.Location = new System.Drawing.Point(165, 47);
            this.btnHitToggle.Name = "btnHitToggle";
            this.btnHitToggle.Size = new System.Drawing.Size(74, 23);
            this.btnHitToggle.TabIndex = 4;
            this.btnHitToggle.Text = "Toggle hit";
            this.btnHitToggle.UseVisualStyleBackColor = true;
            this.btnHitToggle.Click += new System.EventHandler(this.btnHitToggle_Click);
            // 
            // txtHit
            // 
            this.txtHit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHit.Location = new System.Drawing.Point(81, 48);
            this.txtHit.Name = "txtHit";
            this.txtHit.ReadOnly = true;
            this.txtHit.Size = new System.Drawing.Size(78, 20);
            this.txtHit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hit";
            // 
            // txtXY
            // 
            this.txtXY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXY.Location = new System.Drawing.Point(81, 23);
            this.txtXY.Name = "txtXY";
            this.txtXY.ReadOnly = true;
            this.txtXY.Size = new System.Drawing.Size(78, 20);
            this.txtXY.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // boxEnemy
            // 
            this.boxEnemy.Controls.Add(this.button1);
            this.boxEnemy.Controls.Add(this.btnRemoveEnemy);
            this.boxEnemy.Controls.Add(this.txtEnemyTexture);
            this.boxEnemy.Controls.Add(this.label6);
            this.boxEnemy.Controls.Add(this.txtEnemyType);
            this.boxEnemy.Controls.Add(this.label5);
            this.boxEnemy.Location = new System.Drawing.Point(14, 173);
            this.boxEnemy.Name = "boxEnemy";
            this.boxEnemy.Size = new System.Drawing.Size(259, 94);
            this.boxEnemy.TabIndex = 1;
            this.boxEnemy.TabStop = false;
            this.boxEnemy.Text = "Enemy";
            // 
            // btnRemoveEnemy
            // 
            this.btnRemoveEnemy.Location = new System.Drawing.Point(6, 65);
            this.btnRemoveEnemy.Name = "btnRemoveEnemy";
            this.btnRemoveEnemy.Size = new System.Drawing.Size(101, 24);
            this.btnRemoveEnemy.TabIndex = 5;
            this.btnRemoveEnemy.Text = "Remove Enemy";
            this.btnRemoveEnemy.UseVisualStyleBackColor = true;
            this.btnRemoveEnemy.Click += new System.EventHandler(this.btnRemoveEnemy_Click);
            // 
            // txtEnemyTexture
            // 
            this.txtEnemyTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnemyTexture.Location = new System.Drawing.Point(90, 39);
            this.txtEnemyTexture.Name = "txtEnemyTexture";
            this.txtEnemyTexture.ReadOnly = true;
            this.txtEnemyTexture.Size = new System.Drawing.Size(161, 20);
            this.txtEnemyTexture.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Enemy Texture";
            // 
            // txtEnemyType
            // 
            this.txtEnemyType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnemyType.Location = new System.Drawing.Point(90, 13);
            this.txtEnemyType.Name = "txtEnemyType";
            this.txtEnemyType.ReadOnly = true;
            this.txtEnemyType.Size = new System.Drawing.Size(161, 20);
            this.txtEnemyType.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Type";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(93, 387);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 22);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // boxExitInfo
            // 
            this.boxExitInfo.Controls.Add(this.btnRemoveExit);
            this.boxExitInfo.Controls.Add(this.txtExitLocation);
            this.boxExitInfo.Controls.Add(this.label8);
            this.boxExitInfo.Controls.Add(this.txtExitToRoom);
            this.boxExitInfo.Controls.Add(this.label7);
            this.boxExitInfo.Location = new System.Drawing.Point(12, 272);
            this.boxExitInfo.Name = "boxExitInfo";
            this.boxExitInfo.Size = new System.Drawing.Size(261, 107);
            this.boxExitInfo.TabIndex = 3;
            this.boxExitInfo.TabStop = false;
            this.boxExitInfo.Text = "Exit info";
            // 
            // btnRemoveExit
            // 
            this.btnRemoveExit.Location = new System.Drawing.Point(93, 74);
            this.btnRemoveExit.Name = "btnRemoveExit";
            this.btnRemoveExit.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveExit.TabIndex = 8;
            this.btnRemoveExit.Text = "Remove Exit";
            this.btnRemoveExit.UseVisualStyleBackColor = true;
            this.btnRemoveExit.Click += new System.EventHandler(this.btnRemoveExit_Click);
            // 
            // txtExitLocation
            // 
            this.txtExitLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExitLocation.Location = new System.Drawing.Point(92, 45);
            this.txtExitLocation.Name = "txtExitLocation";
            this.txtExitLocation.ReadOnly = true;
            this.txtExitLocation.Size = new System.Drawing.Size(161, 20);
            this.txtExitLocation.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Exit Location";
            // 
            // txtExitToRoom
            // 
            this.txtExitToRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExitToRoom.Location = new System.Drawing.Point(92, 19);
            this.txtExitToRoom.Name = "txtExitToRoom";
            this.txtExitToRoom.ReadOnly = true;
            this.txtExitToRoom.Size = new System.Drawing.Size(161, 20);
            this.txtExitToRoom.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Leads to Room";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NodeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 421);
            this.Controls.Add(this.boxExitInfo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.boxEnemy);
            this.Controls.Add(this.groupBox1);
            this.Name = "NodeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NodeInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.boxEnemy.ResumeLayout(false);
            this.boxEnemy.PerformLayout();
            this.boxExitInfo.ResumeLayout(false);
            this.boxExitInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveOverlay;
        private System.Windows.Forms.TextBox txtOverlay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFloorTexture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHitToggle;
        private System.Windows.Forms.TextBox txtHit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox boxEnemy;
        private System.Windows.Forms.Button btnRemoveEnemy;
        private System.Windows.Forms.TextBox txtEnemyTexture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEnemyType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox boxExitInfo;
        private System.Windows.Forms.Button btnRemoveExit;
        private System.Windows.Forms.TextBox txtExitLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExitToRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}