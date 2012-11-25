using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace LangtonAmeisen
{
    public class LangtonAmeise : Ameise
    {
        public LangtonAmeise(int breite, int hoehe)
            : base(breite, hoehe)
        {
        }

        public override void Bewegen()
        {
            if (stehtAufFarbe(Color.White))
            {
                FaerbeFeldUnterAmeise(Color.Red);
                DreheRechts();
            }
            else if (stehtAufFarbe(Color.Red))
            {
                FaerbeFeldUnterAmeise(Color.White);
                DreheLinks();
            }

            GeheVor();
        }
    }
}
