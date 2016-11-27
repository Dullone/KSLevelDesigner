using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace KSlevelDesigner
{
    public class EnemyType
    {
        String texture;
        String type;

        public EnemyType(String aTexture, string EnemyType)
        {
            texture = aTexture;
            type = EnemyType;
        }

        public String Texture
        {
            get { return texture; }
        }
        public String Type
        {
            get { return type; }
        }
    }
}
