using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandelioSistema
{
    class Cart
    {
        public string Pavadinimas { get; set; }
        public int PrekesId { get; set; }
        public int Kiekis { get; set; }
        public double VntKaina { get; set; }
        public double Nuolaida { get; set; }
        public int Likutis { get; set; }
        public int PradinisKiekis { get; set; }
        public double Kaina
        {
            get
            {
                double kaina = Kiekis * VntKaina * (1 - Nuolaida);
                return kaina;
            }
        }

    }
}
