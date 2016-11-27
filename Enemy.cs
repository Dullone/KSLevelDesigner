using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.IO;

namespace KSlevelDesigner
{
    public class Enemy : DrawableObject
    {
        String enemyType;
        String textureString;
        TileNode node;
        //Path enemy walks when not in combat
        List<Vector2> idlePath;

        //Selected
        public bool selected = false;

        //Constructors
        public Enemy(TileNode innode, String type, Texture2D tex, String textureLocation)
            :base(tex, innode)
        {
            enemyType = type;
            textureString = textureLocation;
            node = innode;
        }

        public Enemy(string type, string textureloation, TileNode inNode)
        {
            enemyType = type;
            textureString = textureloation;
            node = inNode;
        }

        //Properties
        public TileNode onNode
        {
            get { return node; }
        }

        public String Type
        {
            get { return enemyType; }
        }

        public String TextureString
        {
            get { return textureString; }
        }       

        public List<Vector2> IdlePath
        {
            get { return idlePath; }
        }

        //Methods
        public override string ToString()
        {
            return enemyType;
        }
        public void AddPathNode(Vector2 pathNode)
        {
            if (idlePath == null)
                idlePath = new List<Vector2>();
            idlePath.Add(pathNode);
        }

        public void RemoveAllPathNodes()
        {
            idlePath = null;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 screenLocation, Color paintColor)
        {
            spriteBatch.Draw(Texture, screenLocation, paintColor);
            if (idlePath != null)
            {

            }
        }
    }
}
