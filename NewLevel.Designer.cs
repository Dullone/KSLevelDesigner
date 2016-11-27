namespace KSlevelDesigner
{
    partial class NewLevel
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
            this.txtLevelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateLeve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLevelName
            // 
            this.txtLevelName.Location = new System.Drawing.Point(20, 45);
            this.txtLevelName.Name = "txtLevelName";
            this.txtLevelName.Size = new System.Drawing.Size(251, 20);
            this.txtLevelName.TabIndex = 0;
            this.txtLevelName.Text = "DefaultLevelName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Level Name:";
            // 
            // btnCreateLeve
            // 
            this.btnCreateLeve.Location = new System.Drawing.Point(82, 71);
            this.btnCreateLeve.Name = "btnCreateLeve";
            this.btnCreateLeve.Size = new System.Drawing.Size(83, 29);
            this.btnCreateLeve.TabIndex = 2;
            this.btnCreateLeve.Text = "Create Level";
            this.btnCreateLeve.UseVisualStyleBackColor = true;
            this.btnCreateLeve.Click += new System.EventHandler(this.btnCreateLeve_Click);
            // 
            // NewLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 121);
            this.Controls.Add(this.btnCreateLeve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLevelName);
            this.Name = "NewLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewLevel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewLevel_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLevelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateLeve;
    }
}