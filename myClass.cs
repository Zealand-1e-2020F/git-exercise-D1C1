namespace GitExercise
{
    class myClass
    {
        private string navn;
        private string adresse;
        private int postnr;
        public myClass(string navn)
        {
            this.Navn = navn;
        }
        public string Navn { get => navn; set => navn = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Postnr { get => postnr; set => postnr = value; }

        public override string ToString(){
            return $"{Navn} bor på {Adresse},{Postnr}";
        }
    }
}