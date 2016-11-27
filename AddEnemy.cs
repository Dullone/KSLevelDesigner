using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.IO;


namespace KSlevelDesigner
{
    public partial class AddEnemy : Form
    {
        const string DefaultTexture = "NullBlock.png";
        string textureName;

        public delegate void AddedEnemyEventHandler(object sender, AddEnemyEventArgs e);
        public event AddedEnemyEventHandler AddedEnemy;

        public AddEnemy()
        {
            InitializeComponent();
            picTexture.Image = Bitmap.FromFile(DefaultTexture);
            textureName = DefaultTexture;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEnemyType.Text == "")
                txtEnemyType.Text = "Default";
            if (AddedEnemy != null)
                AddedEnemy(this, new AddEnemyEventArgs(new EnemyType(textureName, txtEnemyType.Text)));
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectTexture_Click(object sender, EventArgs e)
        {
            if (openFileDialogTexture.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textureName = openFileDialogTexture.FileName;
                using (FileStream fs = new FileStream(openFileDialogTexture.FileName, FileMode.Open, FileAccess.Read))
                {
                    picTexture.Image = new Bitmap(fs);
                }
            }
        }

    }

    public class AddEnemyEventArgs
    {
        public EnemyType enemy;

        public AddEnemyEventArgs(EnemyType enemyType) : base()
        {
            enemy = enemyType;
        }
    }
}
