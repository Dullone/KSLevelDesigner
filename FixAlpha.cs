using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace KSlevelDesigner
{
    class FixAlpha
    {
        // -------------------------------------------------------------------------------------------------------------------------------- 
        // Adobe Photoshop will save a PNG file with all alpha=0 pixels as white, EVEN IF there are colors 
        // associated with them.  Since the GPU USES these colors, this function will re-create the colors for 
        // ALL alpha=0 pixels that are adjacent to alpha!=0 pixels to be the average color, by weight of alpha, 
        // of all alpha!=0 adjacent pixels.  So, the GPU will fade into the proper color while simultaneously 
        // fading into transparency, instead of into white which gives an undesired white glow! 
        public static void FixSpriteZeroAlphaColors(Texture2D textSprite)
        {
            // 1. declare a uint array to hold the pixel data 
            int width = textSprite.Width;
            int height = textSprite.Height;
            Color[] clrPixelData = new Color[width * height];

            // 2. populate the array 
            textSprite.GetData(clrPixelData, 0, width * height);

            // 3. fix up alpha=0 pixels that are adjacent to alpha!=0 pixels 

            // NOTE: it's ok to modify the array IN PLACE, since we're only changing the A = 0 pixels, 
            // which are NOT used in the calculations; they don't affect the outcome.  Only A != 0 pixels 
            // affect the outcome of the A = 0 pixels that reside next to visible pixels. 
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int index = y * width + x;
                    if (clrPixelData[index].A == 0)
                    {
                        float r = 0;
                        float g = 0;
                        float b = 0;
                        int count = 0;
                        // go through all 8 pixels around 
                        // don't look at current pixel, but we ignore A=0, anyway, which the current pixel IS, 
                        // so we can just loop 3x3 around it, including it 
                        for (int yy = y - 1; yy <= y + 1; yy++)
                        {
                            for (int xx = x - 1; xx <= x + 1; xx++)
                            {
                                // don't go out of range 
                                if ((xx >= 0) && (yy >= 0) && (xx < width) && (yy < height))
                                {
                                    // look at only pixels A != 0 
                                    int index2 = yy * width + xx;
                                    byte alpha = clrPixelData[index2].A;
                                    if (alpha != 0)
                                    {
                                        r += clrPixelData[index2].R * alpha;
                                        g += clrPixelData[index2].G * alpha;
                                        b += clrPixelData[index2].B * alpha;
                                        count++;
                                    }
                                }
                            }
                        }
                        // did we get any non-alpha=0 info? 
                        if (count > 0)
                        {
                            // modify the A=0 pixel to be this average color 
                            clrPixelData[index] = new Color(
                                (byte)(r / count / 255.0f),
                                (byte)(g / count / 255.0f),
                                (byte)(b / count / 255.0f),
                                0);
                        }
                    } // if (clrPixelData[index].A == 0) 
                }
            }

            // 4. set back the information to the texture 
            textSprite.SetData(clrPixelData, 0, width * height);
        } 
    }
}
