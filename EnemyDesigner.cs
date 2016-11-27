using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace KSlevelDesigner
{
    public partial class EnemyDesigner : Form
    {
        string saveLocation = @"enemies.xml";

        public EnemyDesigner()
        {
            InitializeComponent();
            cmbAIType.SelectedIndex = 0;
            cmbAim.SelectedIndex = 0;
        }

        private void picColor_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialog1.ShowDialog();
            picColor.BackColor = colorDialog1.Color;
            txtColor.Text = colorDialog1.Color.ToString();
        }

        private void btnChooseTexture_Click(object sender, EventArgs e)
        {
            if (openFileDialogTexture.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picTexture.Image = Bitmap.FromFile(openFileDialogTexture.FileName);
                txtTexture.Text = Path.GetFileName(openFileDialogTexture.FileName);
            }
        }

        private void btnCreateAndSave_Click(object sender, EventArgs e)
        {
            this.SaveEnemyToXML(saveLocation);
            this.Close();
        }

        private void SaveEnemyToXML(string file)
        {
            XmlDocument xml = new XmlDocument();
            
            if (File.Exists(file) == true)
            {
                try
                {
                    xml.Load(file);
                }
                catch (FileLoadException e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                XmlNode enem = xml.CreateNode(XmlNodeType.Element, "enemies", "");
                xml.AppendChild(enem);
            }

            //enemies node to which we want to append
            XmlNode enemies = xml.SelectSingleNode("enemies");
            if (enemies == null)
                MessageBox.Show("Not a valide enemy file");
            
            //create enemy node then append
            XmlElement enemy = xml.CreateElement("enemy");
            enemies.AppendChild(enemy);
            //class
            XmlElement type = xml.CreateElement("class");
            type.InnerText = txtClass.Text;
            enemy.AppendChild(type);
            //texture
            XmlElement tex = xml.CreateElement("texture");
            tex.InnerText = txtTexture.Text;
            enemy.AppendChild(tex);
            //color
            XmlElement color = xml.CreateElement("color");
            enemy.AppendChild(color);
            XmlElement r = xml.CreateElement("r");
            r.InnerText = picColor.BackColor.R.ToString();
            color.AppendChild(r);
            XmlElement g = xml.CreateElement("g");
            g.InnerText = picColor.BackColor.G.ToString();
            color.AppendChild(g);
            XmlElement b = xml.CreateElement("b");
            b.InnerText = picColor.BackColor.B.ToString();
            color.AppendChild(b);
            XmlElement a = xml.CreateElement("a");
            a.InnerText = numAlpha.Value.ToString();
            color.AppendChild(a);

            //AI
            XmlElement AI = xml.CreateElement("ai");
            AI.InnerText = cmbAIType.SelectedItem.ToString();
            enemy.AppendChild(AI);

            //pursue distance
            XmlElement pursue = xml.CreateElement("pursuedistance");
            pursue.InnerText = numPursueDistance.Value.ToString();
            enemy.AppendChild(pursue);
            //movmemnt speed
            XmlElement speed = xml.CreateElement("speed");
            speed.InnerText = numSpeed.Value.ToString();
            enemy.AppendChild(speed);
            //health
            XmlElement health = xml.CreateElement("health");
            health.InnerText = numHealth.Value.ToString();
            enemy.AppendChild(health);
            //xp value
            XmlElement xp = xml.CreateElement("xp");
            xp.InnerText = numXP.Value.ToString();
            enemy.AppendChild(xp);
            
            //Melee attack
            if (radioMeleeAttackYes.Checked == true)
            {
                XmlElement melee = xml.CreateElement("melee");
                enemy.AppendChild(melee);
                XmlElement meleeDamage = xml.CreateElement("damage");
                meleeDamage.InnerText = numMeleeDamage.Value.ToString();
                melee.AppendChild(meleeDamage);
                XmlElement meleeSpeed = xml.CreateElement("speed");
                meleeSpeed.InnerText = numMeleeSpeed.Value.ToString();
                melee.AppendChild(meleeSpeed);
            }

            //ranged attack
            if (radioRangedAttackYes.Checked == true)
            {
                XmlElement ranged = xml.CreateElement("ranged");
                enemy.AppendChild(ranged);
                XmlElement rangedDamage = xml.CreateElement("damage");
                rangedDamage.InnerText = numRangedAttackDamage.Value.ToString();
                ranged.AppendChild(rangedDamage);
                XmlElement rangedSpeed = xml.CreateElement("speed");
                rangedSpeed.InnerText = numRangedAttackSpeed.Value.ToString();
                ranged.AppendChild(rangedSpeed);
                XmlElement rangedRange = xml.CreateElement("range");
                rangedRange.InnerText = numRangedAttackRange.Value.ToString();
                ranged.AppendChild(rangedRange);
            }

            xml.Save(file);
        }
    }
}
