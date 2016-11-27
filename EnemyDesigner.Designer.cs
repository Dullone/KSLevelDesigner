namespace KSlevelDesigner
{
    partial class EnemyDesigner
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTexture = new System.Windows.Forms.TextBox();
            this.picTexture = new System.Windows.Forms.PictureBox();
            this.btnChooseTexture = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.numAlpha = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.cmbAIType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numPursueDistance = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numHealth = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numXP = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numMeleeSpeed = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numMeleeDamage = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.radioMeleeAttackNo = new System.Windows.Forms.RadioButton();
            this.radioMeleeAttackYes = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numRangedAttackRange = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.numRangedAttackSpeed = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numRangedAttackDamage = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.radioRangedAttackYes = new System.Windows.Forms.RadioButton();
            this.radioRangedAttackNo = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCreateAndSave = new System.Windows.Forms.Button();
            this.openFileDialogTexture = new System.Windows.Forms.OpenFileDialog();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbAim = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPursueDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXP)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeleeSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeleeDamage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRangedAttackRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRangedAttackSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRangedAttackDamage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(62, 25);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(125, 20);
            this.txtClass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texture";
            // 
            // txtTexture
            // 
            this.txtTexture.Location = new System.Drawing.Point(63, 51);
            this.txtTexture.Name = "txtTexture";
            this.txtTexture.ReadOnly = true;
            this.txtTexture.Size = new System.Drawing.Size(123, 20);
            this.txtTexture.TabIndex = 3;
            // 
            // picTexture
            // 
            this.picTexture.Location = new System.Drawing.Point(348, 12);
            this.picTexture.Name = "picTexture";
            this.picTexture.Size = new System.Drawing.Size(90, 90);
            this.picTexture.TabIndex = 4;
            this.picTexture.TabStop = false;
            // 
            // btnChooseTexture
            // 
            this.btnChooseTexture.Location = new System.Drawing.Point(192, 51);
            this.btnChooseTexture.Name = "btnChooseTexture";
            this.btnChooseTexture.Size = new System.Drawing.Size(61, 19);
            this.btnChooseTexture.TabIndex = 5;
            this.btnChooseTexture.Text = "Choose...";
            this.btnChooseTexture.UseVisualStyleBackColor = true;
            this.btnChooseTexture.Click += new System.EventHandler(this.btnChooseTexture_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(62, 77);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(123, 20);
            this.txtColor.TabIndex = 7;
            this.txtColor.Text = "|-------------click---------------->";
            // 
            // numAlpha
            // 
            this.numAlpha.Location = new System.Drawing.Point(233, 77);
            this.numAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAlpha.Name = "numAlpha";
            this.numAlpha.Size = new System.Drawing.Size(42, 20);
            this.numAlpha.TabIndex = 9;
            this.numAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "alpha";
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.Color.White;
            this.picColor.Location = new System.Drawing.Point(186, 77);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(41, 20);
            this.picColor.TabIndex = 11;
            this.picColor.TabStop = false;
            this.picColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picColor_MouseClick);
            // 
            // cmbAIType
            // 
            this.cmbAIType.FormattingEnabled = true;
            this.cmbAIType.Items.AddRange(new object[] {
            "[none]",
            "A* pathfind melee",
            "A* pathfind shoot & melee",
            "Move Toward melee",
            "Move Toward shoot & melee",
            "Move Along path & shoot"});
            this.cmbAIType.Location = new System.Drawing.Point(62, 103);
            this.cmbAIType.Name = "cmbAIType";
            this.cmbAIType.Size = new System.Drawing.Size(213, 21);
            this.cmbAIType.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "AI type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pursue distance";
            // 
            // numPursueDistance
            // 
            this.numPursueDistance.Location = new System.Drawing.Point(92, 133);
            this.numPursueDistance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPursueDistance.Name = "numPursueDistance";
            this.numPursueDistance.Size = new System.Drawing.Size(72, 20);
            this.numPursueDistance.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "pixels";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Movement speed";
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(92, 160);
            this.numSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(72, 20);
            this.numSpeed.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "pixels per second";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Health";
            // 
            // numHealth
            // 
            this.numHealth.Location = new System.Drawing.Point(348, 135);
            this.numHealth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHealth.Name = "numHealth";
            this.numHealth.Size = new System.Drawing.Size(72, 20);
            this.numHealth.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(298, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "XP value";
            // 
            // numXP
            // 
            this.numXP.Location = new System.Drawing.Point(348, 161);
            this.numXP.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numXP.Name = "numXP";
            this.numXP.Size = new System.Drawing.Size(72, 20);
            this.numXP.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numMeleeSpeed);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.numMeleeDamage);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.radioMeleeAttackNo);
            this.groupBox1.Controls.Add(this.radioMeleeAttackYes);
            this.groupBox1.Location = new System.Drawing.Point(6, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 148);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Melee Attack";
            // 
            // numMeleeSpeed
            // 
            this.numMeleeSpeed.Location = new System.Drawing.Point(60, 74);
            this.numMeleeSpeed.Name = "numMeleeSpeed";
            this.numMeleeSpeed.Size = new System.Drawing.Size(120, 20);
            this.numMeleeSpeed.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Speed";
            // 
            // numMeleeDamage
            // 
            this.numMeleeDamage.Location = new System.Drawing.Point(60, 51);
            this.numMeleeDamage.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMeleeDamage.Name = "numMeleeDamage";
            this.numMeleeDamage.Size = new System.Drawing.Size(120, 20);
            this.numMeleeDamage.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Damage";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Attack Available";
            // 
            // radioMeleeAttackNo
            // 
            this.radioMeleeAttackNo.AutoSize = true;
            this.radioMeleeAttackNo.Location = new System.Drawing.Point(145, 25);
            this.radioMeleeAttackNo.Name = "radioMeleeAttackNo";
            this.radioMeleeAttackNo.Size = new System.Drawing.Size(39, 17);
            this.radioMeleeAttackNo.TabIndex = 1;
            this.radioMeleeAttackNo.TabStop = true;
            this.radioMeleeAttackNo.Text = "No";
            this.radioMeleeAttackNo.UseVisualStyleBackColor = true;
            // 
            // radioMeleeAttackYes
            // 
            this.radioMeleeAttackYes.AutoSize = true;
            this.radioMeleeAttackYes.Location = new System.Drawing.Point(96, 25);
            this.radioMeleeAttackYes.Name = "radioMeleeAttackYes";
            this.radioMeleeAttackYes.Size = new System.Drawing.Size(43, 17);
            this.radioMeleeAttackYes.TabIndex = 0;
            this.radioMeleeAttackYes.TabStop = true;
            this.radioMeleeAttackYes.Text = "Yes";
            this.radioMeleeAttackYes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbAim);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.numRangedAttackRange);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.numRangedAttackSpeed);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.numRangedAttackDamage);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.radioRangedAttackYes);
            this.groupBox2.Controls.Add(this.radioRangedAttackNo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(223, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 148);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ranged Attack";
            // 
            // numRangedAttackRange
            // 
            this.numRangedAttackRange.Location = new System.Drawing.Point(71, 99);
            this.numRangedAttackRange.Name = "numRangedAttackRange";
            this.numRangedAttackRange.Size = new System.Drawing.Size(120, 20);
            this.numRangedAttackRange.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Range";
            // 
            // numRangedAttackSpeed
            // 
            this.numRangedAttackSpeed.Location = new System.Drawing.Point(71, 74);
            this.numRangedAttackSpeed.Name = "numRangedAttackSpeed";
            this.numRangedAttackSpeed.Size = new System.Drawing.Size(120, 20);
            this.numRangedAttackSpeed.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Speed";
            // 
            // numRangedAttackDamage
            // 
            this.numRangedAttackDamage.Location = new System.Drawing.Point(71, 51);
            this.numRangedAttackDamage.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numRangedAttackDamage.Name = "numRangedAttackDamage";
            this.numRangedAttackDamage.Size = new System.Drawing.Size(120, 20);
            this.numRangedAttackDamage.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Damage";
            // 
            // radioRangedAttackYes
            // 
            this.radioRangedAttackYes.AutoSize = true;
            this.radioRangedAttackYes.Location = new System.Drawing.Point(110, 23);
            this.radioRangedAttackYes.Name = "radioRangedAttackYes";
            this.radioRangedAttackYes.Size = new System.Drawing.Size(43, 17);
            this.radioRangedAttackYes.TabIndex = 2;
            this.radioRangedAttackYes.TabStop = true;
            this.radioRangedAttackYes.Text = "Yes";
            this.radioRangedAttackYes.UseVisualStyleBackColor = true;
            // 
            // radioRangedAttackNo
            // 
            this.radioRangedAttackNo.AutoSize = true;
            this.radioRangedAttackNo.Location = new System.Drawing.Point(159, 23);
            this.radioRangedAttackNo.Name = "radioRangedAttackNo";
            this.radioRangedAttackNo.Size = new System.Drawing.Size(39, 17);
            this.radioRangedAttackNo.TabIndex = 1;
            this.radioRangedAttackNo.TabStop = true;
            this.radioRangedAttackNo.Text = "No";
            this.radioRangedAttackNo.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Attack Available";
            // 
            // btnCreateAndSave
            // 
            this.btnCreateAndSave.Location = new System.Drawing.Point(142, 390);
            this.btnCreateAndSave.Name = "btnCreateAndSave";
            this.btnCreateAndSave.Size = new System.Drawing.Size(137, 23);
            this.btnCreateAndSave.TabIndex = 26;
            this.btnCreateAndSave.Text = "Create and Save";
            this.btnCreateAndSave.UseVisualStyleBackColor = true;
            this.btnCreateAndSave.Click += new System.EventHandler(this.btnCreateAndSave_Click);
            // 
            // openFileDialogTexture
            // 
            this.openFileDialogTexture.Filter = "PNG |*png|JPEG|*.jpg|Bitmap|*.bmp";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(34, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Aim";
            // 
            // cmbAim
            // 
            this.cmbAim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAim.FormattingEnabled = true;
            this.cmbAim.Items.AddRange(new object[] {
            "Predict Location",
            "Current Location",
            "semi-Random",
            "totally Random"});
            this.cmbAim.Location = new System.Drawing.Point(71, 121);
            this.cmbAim.Name = "cmbAim";
            this.cmbAim.Size = new System.Drawing.Size(120, 21);
            this.cmbAim.TabIndex = 14;
            // 
            // EnemyDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 425);
            this.Controls.Add(this.btnCreateAndSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numXP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numHealth);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numSpeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numPursueDistance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAIType);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numAlpha);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChooseTexture);
            this.Controls.Add(this.picTexture);
            this.Controls.Add(this.txtTexture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EnemyDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enemy Designer";
            ((System.ComponentModel.ISupportInitialize)(this.picTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPursueDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeleeSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeleeDamage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRangedAttackRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRangedAttackSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRangedAttackDamage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTexture;
        private System.Windows.Forms.PictureBox picTexture;
        private System.Windows.Forms.Button btnChooseTexture;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.NumericUpDown numAlpha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.ComboBox cmbAIType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPursueDistance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numHealth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numXP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioMeleeAttackNo;
        private System.Windows.Forms.RadioButton radioMeleeAttackYes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numMeleeSpeed;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numMeleeDamage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numRangedAttackRange;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numRangedAttackSpeed;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numRangedAttackDamage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radioRangedAttackYes;
        private System.Windows.Forms.RadioButton radioRangedAttackNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCreateAndSave;
        private System.Windows.Forms.OpenFileDialog openFileDialogTexture;
        private System.Windows.Forms.ComboBox cmbAim;
        private System.Windows.Forms.Label label19;
    }
}