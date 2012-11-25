using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace LangtonAmeisen
{
    public abstract class Ameise
    {
        private Point position;
        private Bitmap bitmap;
        private Graphics g;
        /// <summary>
        ///       oben
        ///         1 
        /// rechts 4 2 links
        ///         3 
        ///       unten
        /// </summary>
        private int richtung;

        private int schritte;

        /// <summary>
        /// Bestimmt die Pixelbreite eines Kaestchens auf dem Ameisenbild.
        /// </summary>
        private int kaestchenbreite;

        public Ameise(int breite, int hoehe)
        {
            this.position = new Point(breite / 2, hoehe / 2);
            this.richtung = 1;
            this.schritte = 0;
            this.kaestchenbreite = 5;

            // Bitmap erzeugen und weiß färben
            this.bitmap = new Bitmap(breite, hoehe);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);            
        }


        public void GeheVor()
        {
            switch (richtung)
            {
                case 1: position.Y -= kaestchenbreite; break;
                case 2: position.X += kaestchenbreite; break;
                case 3: position.Y += kaestchenbreite; break;
                case 4: position.X -= kaestchenbreite; break;
            }

            schritte++;
        }

        public void DreheLinks()
        {
            if (richtung == 1)
            {
                richtung = 4;
            }
            else
            {
                richtung--;
            }
        }

        public void DreheRechts()
        {
            if (richtung == 4)
            {
                richtung = 1;
            }
            else
            {
                richtung++;
            }
        }

        public Bitmap HoleBild()
        {
            return this.bitmap;
        }

        private Color HoleFarbeUnterAmeise()
        {
            return this.bitmap.GetPixel(position.X, position.Y);
        }

        public bool stehtAufFarbe(Color farbe)
        {
            // Prüfung mit Equals() klappt nicht, da der Name der Farbe nicht stimmt
            if (HoleFarbeUnterAmeise().ToArgb() == farbe.ToArgb())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void FaerbeFeldUnterAmeise(Color farbe)
        {
            Brush pinsel = new SolidBrush(farbe);
            g.FillRectangle(pinsel, position.X, position.Y, kaestchenbreite, kaestchenbreite);
        }


        public int HoleSchritte()
        {
            return this.schritte;
        }

        public Point HolePosition()
        {
            return this.position;
        }

        public bool IstInnerhalbFeld()
        {
            return HolePosition().X < bitmap.Width && HolePosition().X > 0 && HolePosition().Y < bitmap.Height && HolePosition().Y > 0;
        }

        abstract public void Bewegen();
    }
}
