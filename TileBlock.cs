using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace KSlevelDesigner
{
    class TileBlock
    {
        public PictureBox sprite;
        private Image NormalImage;
        private Image HitImage;
        private bool HitDetection;
        public String imageFileName;

        public TileBlock()
        {
            sprite = new TileBox();
            HitDetection = false;
        }

        public bool hitDetection
        {
            get
            {
                return HitDetection;
            }
            set
            {
                HitDetection = value;
                if (sprite != null)
                {
                    UpdateImage();
                }
            }
        }

        private void UpdateImage()
        {
            if (sprite != null)
            {
                if (hitDetection == true)
                    sprite.Image = HitImage;
                else
                    sprite.Image = NormalImage;
            }
        }

        public Image Sprite
        {
            get
            {
                return sprite.Image;
            }
        }

        public void setImage(Image image, String fileName)
        {
            InitializeImages(image);
            UpdateImage();
            imageFileName = fileName;
        }

        public PictureBox Pic
        {
            get
            {
                return sprite;
            }
            set
            {
                sprite = value;
                InitializeImages(value.Image);
            }
        }

        private void InitializeImages(Image img)
        {
            NormalImage = img;
            HitImage = (Image)img.Clone();
            Graphics g = Graphics.FromImage(HitImage);
            Font font = new Font("Tohama", 14);
            g.DrawString("hit", font, Brushes.Black, new Point(3, 3));
            g.DrawString("hit", font, Brushes.White, new Point(3, HitImage.Height - (int)g.MeasureString("hit", font).Height));
        }
    }
}
