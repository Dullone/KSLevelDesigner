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
    public partial class NewLevel : Form
    {
        const string DefaultLevelName = "DefaultLevelName";

        public NewLevel()
        {
            InitializeComponent();
        }

        public delegate void RommCreatedEventHandler(object sender, CreateRoomEventArgs e);
        public event RommCreatedEventHandler RoomCreated;

        private void btnCreateLeve_Click(object sender, EventArgs e)
        {
            CreateLevel();
            this.Close();
        }

        private void CreateLevel()
        {
            if (RoomCreated != null)
            {
                if (txtLevelName.Text == "")
                {
                    txtLevelName.Text = DefaultLevelName;
                }
                RoomCreated(this, new CreateRoomEventArgs(txtLevelName.Text));
            }
        }


        private void NewLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            CreateLevel();
        }
    }

    public class CreateRoomEventArgs : EventArgs
    {
        public string levelName;
        public CreateRoomEventArgs(string alevelName) 
            : base()
        {
            levelName = alevelName;
        }
    }
}
