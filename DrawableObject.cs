using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace KSlevelDesigner
{    
    public class DrawableObject
    {
        Texture2D texture;
        TileNode node;

        public DrawableObject(Texture2D tex, TileNode n)
        {
            texture = tex;
            node = n;
        }

        protected DrawableObject()
        {
        }

        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }
    }
}
