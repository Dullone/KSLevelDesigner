using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Microsoft.Xna.Framework;

namespace KSlevelDesigner
{
    public class Level
    {
        String name;
        List<Room> roomList;
        Room startRoom;
        TileNode startNode;
        Vector2 startLocation;

        //Constructor
        public Level(String levelName, bool LEVELNAME)
        {
            name = levelName;
            Initialize();
        }

        public Level(string filename)
        {
            Initialize();
            this.OpenFromXML(filename);
        }

        private void Initialize()
        {
            roomList = new List<Room>();
        }

        //Properties
        public Room StartRoom
        {
            get { return startRoom; }
        }

        public int NumberOfRooms
        {
            get { return roomList.Count; }
        }

        public Vector2 StartLocation
        {
            get { return startLocation ;}
        }

        //iterator
        public System.Collections.IEnumerator GetEnumerator()
        {
            foreach (Room r in roomList)
            {
                yield return r;
            }
        }

        //Methods
        public Room GetRoomByName(string name)
        {
            Room room = null;
            foreach (Room r in roomList)
            {
                if (r.Name == name)
                {
                    room = r;
                    break;
                }
            }
            return room;
        }

        public bool SetStartNode(Room room, TileNode node)
        {
            if(node.Hit == true) //can't start on a tile with hit
                return false;
            node.HitChanged += new TileNode.HitChangedEventHandler(node_HitChanged);
            return true;
        }

        public void SetStartLocation(Room room, float x, float y)
        {
            startRoom = room;
            startLocation = new Vector2(x, y);
        }

        public void AddRoom(Room room)
        {
            roomList.Add(room);
            if (startRoom == null)
            {
                startRoom = room;
                startNode = room.getFirstNode();
            }
        }

        public void SaveLevelToXML(string filename)
        {
            XmlDocument xml = new XmlDocument();
            XmlNode LevelNode = xml.CreateNode(XmlNodeType.Element, "level", "");
            xml.AppendChild(LevelNode);
            //level info  //name
            XmlElement levelname = xml.CreateElement("name");
            levelname.InnerText = name;
            LevelNode.AppendChild(levelname);
            //startroom
            XmlElement startRoomEl = xml.CreateElement("startroom");
            startRoomEl.InnerText = startRoom.Name;
            LevelNode.AppendChild(startRoomEl);
            //start location
            XmlElement startlocx = xml.CreateElement("startlocationx");
            startlocx.InnerText = startLocation.X.ToString();
            XmlElement startlocy = xml.CreateElement("startlocationy");
            startlocy.InnerText = startLocation.Y.ToString();
            LevelNode.AppendChild(startlocx);
            LevelNode.AppendChild(startlocy);

            XmlElement roomsElement = xml.CreateElement("rooms");
            LevelNode.AppendChild(roomsElement);
            foreach (Room room in roomList)
            {
                roomsElement.AppendChild(room.saveRoomToXMLDocument(xml));
            }

            xml.Save(filename);
        }

        private void OpenFromXML(string filename)
        {
            //clear current room
            name = "";
            startRoom = null;
            startNode = null;

            XmlDocument xml = new XmlDocument();
            xml.Load(filename);

            XmlNode levelNode = xml.SelectSingleNode("level");
            name = levelNode.SelectSingleNode("name").InnerText;
            startLocation.X = (float)Convert.ToDouble(levelNode.SelectSingleNode("startlocationx").InnerText);
            startLocation.Y = (float)Convert.ToDouble(levelNode.SelectSingleNode("startlocationy").InnerText);
            XmlNode roomListNode = levelNode.SelectSingleNode("rooms");
            XmlNodeList rooms = roomListNode.SelectNodes("room");

            //add rooms
            List<RoomExitsQueueItem> ExitQueue = new List<RoomExitsQueueItem>(); ;
            foreach (XmlNode room in rooms)
            {                
                this.AddRoom(new Room(room, ExitQueue));
            }

            //add start room
            string startRoomName = levelNode.SelectSingleNode("startroom").InnerText;
            //find start room and assign it & assign exits to nodes
            foreach (Room room in roomList)
            {
                if (room.Name == startRoomName)
                {
                    startRoom = room;
                }
                foreach (RoomExitsQueueItem exit in ExitQueue)
                {
                    if (room.Name == exit.toRoom) //room exit found by name, add exit to node
                    {
                        exit.fromNode.AddRoomExit(room, room.GetTileByLocation(exit.toLocation));
                    }
                }
            }
            if(startRoom == null)
                throw new InvalidStartLocationException("No start room found.");

        }

        //Event callbacks
        void node_HitChanged(object sender, EventArgs e)
        {
            if(startNode.Hit == true)
                throw new InvalidStartLocationException("Starting locations cannot have hit detection.");
        }
    }
    public class RoomExitsQueueItem
    {
        public TileNode fromNode;
        public string toRoom;
        public Vector2 toLocation;
    }

public class InvalidStartLocationException : Exception
{
  public InvalidStartLocationException() { }
  public InvalidStartLocationException( string message ) : base( message ) { }
  public InvalidStartLocationException( string message, Exception inner ) : base( message, inner ) { }
  protected InvalidStartLocationException( 
	System.Runtime.Serialization.SerializationInfo info, 
	System.Runtime.Serialization.StreamingContext context ) : base( info, context ) { }
}
}
