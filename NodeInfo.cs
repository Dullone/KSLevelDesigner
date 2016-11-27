using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KSlevelDesigner
{
    public partial class NodeInfo : Form
    {
        TileNode Node;
        public NodeInfo(TileNode node)
        {
            Node = node;
            InitializeComponent();
            txtXY.Text = node.Location.X.ToString() + "," + node.Location.Y.ToString();
            txtHit.Text = node.Hit.ToString();
            txtFloorTexture.Text = node.floorName;
            if (node.Overlay != null)
            {
                txtOverlay.Text = node.overlayName;
            }
            else
            {
                txtOverlay.Text = "No overlay";
                btnRemoveOverlay.Enabled = false;
            }
            //enemy
            if (node.enemy != null)
            {
                txtEnemyType.Text = node.enemy.Type;
                txtEnemyTexture.Text = node.enemy.TextureString;
            }
            else
            {
                boxEnemy.Text = "Enemy (no enemies on this node)";
                btnRemoveEnemy.Enabled = false;
            }

            //exit info
            if (node.roomexit != null)
            {
                txtExitToRoom.Text = node.roomexit.leadsToRoom.Name;
                txtExitLocation.Text = node.roomexit.exitLoc.Location.ToString();
            }
            else
            {
                boxExitInfo.Text = "No Exit on this node";
                btnRemoveExit.Enabled = false;
            }
        }

        private void btnHitToggle_Click(object sender, EventArgs e)
        {
            Node.ToggleHit();
        }

        private void btnRemoveOverlay_Click(object sender, EventArgs e)
        {
            Node.Overlay = null;
            Node.overlayName = null;
        }

        private void btnRemoveEnemy_Click(object sender, EventArgs e)
        {
            Node.enemy = null;
        }

        private void btnRemoveExit_Click(object sender, EventArgs e)
        {
            Node.RemoveExit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Node.enemy.RemoveAllPathNodes();
        }
    }
}
