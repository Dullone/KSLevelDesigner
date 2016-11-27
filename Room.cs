using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;
using Microsoft.Xna.Framework;

namespace KSlevelDesigner
{
    public class Room
    {
        string name;
        SortedList<uint, TileNode> nodeList;
        List<Enemy> enemies;
        public float locx, locy;

       //Constructors
        public Room(SortedList<uint, TileNode> list)
        {
            nodeList = list;
            enemies = new List<Enemy>();
            foreach(KeyValuePair<uint,TileNode> n in list)
            {
                n.Value.AddedEnemy += new TileNode.EnemyAddedEventHandler(newTileNode_AddedEnemy);
            }
        }

        public Room()
        {
            nodeList = new SortedList<uint, TileNode>();
            enemies = new List<Enemy>();
        }

        //Properties
        public String Name
        {
            set { name = value;}
            get { return name; }
        }

        public SortedList<uint, TileNode> NodeList
        {
            get { return nodeList; }
        }

        public List<Enemy> Enemies
        {
            get { return enemies; }
        }

        //Methods
        public TileNode getFirstNode()
        {
            return nodeList[0u];
        }

        public XmlElement saveRoomToXMLDocument(XmlDocument xml)
        {
            XmlElement roomElement = xml.CreateElement("room");
            //create room info elements
            XmlElement nameElement = xml.CreateElement("name");
            nameElement.InnerText = name;
            XmlElement locatx = xml.CreateElement("x");
            locatx.InnerText = locx.ToString();
            XmlElement locaty = xml.CreateElement("y");
            locaty.InnerText = locy.ToString();
            //append room info elements
            roomElement.AppendChild(nameElement);
            roomElement.AppendChild(locatx);
            roomElement.AppendChild(locaty);

            XmlElement tileNodes = xml.CreateElement("nodelist");
            roomElement.AppendChild(tileNodes);
            foreach (KeyValuePair<uint, TileNode> node in nodeList)
            {
                tileNodes.AppendChild(node.Value.SaveNodeToXML(xml));
            }

            return roomElement;
        }

        public Room (XmlNode roomNode, List<RoomExitsQueueItem> exitsQueue)
        {
            enemies = new List<Enemy>();
            name = roomNode.SelectSingleNode("name").InnerText;
            locx = (float)Convert.ToDouble(roomNode.SelectSingleNode("x").InnerText);
            locy = (float)Convert.ToDouble(roomNode.SelectSingleNode("y").InnerText);

            nodeList = new SortedList<uint, TileNode>();
            XmlNode nodeListNode = roomNode.SelectSingleNode("nodelist");
            XmlNodeList nodes = nodeListNode.SelectNodes("node");
            foreach (XmlNode nodeNode in nodes)
            {
                TileNode newTileNode = new TileNode(nodeNode, exitsQueue);
                nodeList.Add(newTileNode.CompareValue, newTileNode);
                if (newTileNode.enemy != null)
                    enemies.Add(newTileNode.enemy);
                newTileNode.AddedEnemy += new TileNode.EnemyAddedEventHandler(newTileNode_AddedEnemy);
            }

        }

        void newTileNode_AddedEnemy(object sender, Enemy e)
        {
            TileNode node = sender as TileNode;
            enemies.Add(node.enemy);
        }

        public TileNode GetTileByLocation(Vector2 tileLocation)
        {
            uint value = (uint)(tileLocation.X * TileNode.maxWidthAndHeight + tileLocation.Y);
            try
            {
                TileNode tile = nodeList[value];
                return tile;
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }
    }

    public class RoomLoadException : Exception
    {
        public RoomLoadException() : base("Not a valid room file")
        {
        }
    }
}
