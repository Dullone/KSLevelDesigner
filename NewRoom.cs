using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KSlevelDesigner
{
    public partial class NewRoom : Form
    {
        public delegate void NewRoomCreatedEventHandler(Object sender, NewRoomCreatedEventArgs e);
        public event NewRoomCreatedEventHandler NewRoomCreated;

        public string defaultTile = "NullBlock.png";

        public NewRoom()
        {
            InitializeComponent();
            using (FileStream fs = new FileStream(defaultTile, FileMode.Open, FileAccess.Read))
            {
                picTile.Image = new Bitmap(fs);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtRoomName.Text == "")
            {
                MessageBox.Show("Room Name cannot be empty", "Room name empty");
                return;
            }
            newRoomType newRoomType;
            newRoomType.roomName = txtRoomName.Text;
            newRoomType.rows = (int)numRows.Value;
            newRoomType.columns = (int)numColumns.Value;
            newRoomType.X = (int)numX.Value;
            newRoomType.Y = (int)numY.Value;
            newRoomType.defaultTile = defaultTile;

            //set up callback
            if(NewRoomCreated != null)
                NewRoomCreated(this, new NewRoomCreatedEventArgs(newRoomType));
            this.Close();
        }

        private void numRows_Enter(object sender, EventArgs e)
        {
            numRows.Select(0, numRows.ToString().Length);
        }

        private void numColumns_Enter(object sender, EventArgs e)
        {
            numColumns.Select(0, numColumns.ToString().Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    picTile.Image = new Bitmap(fs);
                }
                defaultTile = openFileDialog1.FileName;
            }
        }


    }

    public struct newRoomType
    {
        public string roomName;
        public int rows;
        public int columns;
        public int X;
        public int Y;
        public string defaultTile;
    }

    public class NewRoomCreatedEventArgs : EventArgs
    {
        public newRoomType newroom;
        public NewRoomCreatedEventArgs(newRoomType n)
        {
            newroom = n;
        }
    }
}
