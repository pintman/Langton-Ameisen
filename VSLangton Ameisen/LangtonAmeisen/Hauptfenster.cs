using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace LangtonAmeisen
{
    public partial class Hauptfenster : Form
    {
        Ameise ameise;
        Thread malThread;

        public Hauptfenster()
        {
            InitializeComponent();

            ameise = new LangtonAmeise(pbFeld.Width, pbFeld.Height);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            malThread = new System.Threading.Thread(BewegeAmeise);
            malThread.Start();
        }

        private void BewegeAmeise()
        {
            lock (this)
            {
                while (ameise.IstInnerhalbFeld())
                {
                    ameise.Bewegen();

                    pbFeld.Invalidate();
                    statusLabel.Text = "Schritte: " + ameise.HoleSchritte();
                }            
            }
        }

        private void pbFeld_Paint(object sender, PaintEventArgs e)
        {
            Bitmap ameisenBild = ameise.HoleBild();
            e.Graphics.DrawImage(ameisenBild, 0, 0);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            malThread.Abort();
        }

        private void btnEinzelschritt_Click(object sender, EventArgs e)
        {
            ameise.Bewegen();
            pbFeld.Invalidate();
            statusLabel.Text = "Schritt : " + ameise.HoleSchritte();
        }
    }
}
