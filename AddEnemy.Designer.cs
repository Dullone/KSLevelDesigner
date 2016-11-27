namespace KSlevelDesigner
{
    partial class AddEnemy
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEnemyType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picTexture = new System.Windows.Forms.PictureBox();
            this.btnSelectTexture = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialogTexture = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picTexture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEnemyType
            // 
            this.txtEnemyType.Location = new System.Drawing.Point(21, 31);
            this.txtEnemyType.Name = "txtEnemyType";
            this.txtEnemyType.Size = new System.Drawing.Size(167, 20);
            this.txtEnemyType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enemy Type";
            // 
            // picTexture
            // 
            this.picTexture.Location = new System.Drawing.Point(159, 66);
            this.picTexture.Name = "picTexture";
            this.picTexture.Size = new System.Drawing.Size(30, 30);
            this.picTexture.TabIndex = 3;
            this.picTexture.TabStop = false;
            // 
            // btnSelectTexture
            // 
            this.btnSelectTexture.Location = new System.Drawing.Point(21, 67);
            this.btnSelectTexture.Name = "btnSelectTexture";
            this.btnSelectTexture.Size = new System.Drawing.Size(127, 29);
            this.btnSelectTexture.TabIndex = 4;
            this.btnSelectTexture.Text = "Select Texture...";
            this.btnSelectTexture.UseVisualStyleBackColor = true;
            this.btnSelectTexture.Click += new System.EventHandler(this.btnSelectTexture_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(102, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 24);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddEnemy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 144);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelectTexture);
            this.Controls.Add(this.picTexture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnemyType);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddEnemy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEnemy";
            ((System.ComponentModel.ISupportInitialize)(this.picTexture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEnemyType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picTexture;
        private System.Windows.Forms.Button btnSelectTexture;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialogTexture;
    }
}