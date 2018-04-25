namespace SandelioSistema
{
    class Cart
    {
        public string Pavadinimas { get; set; }
        public int PrekesId { get; set; }
        public int Kiekis { get; set; }
        public double VntKaina { get; set; }
        public double Nuolaida { get; set; }
        public int PradinisKiekis { get; set; }
        public double Kaina
        {
            get
            {
                return Kiekis * VntKaina * (1 - Nuolaida);
            }
        }
        public int Likutis
        {
            get
            {
                return PradinisKiekis - Kiekis;
            }
        }
    }
}
