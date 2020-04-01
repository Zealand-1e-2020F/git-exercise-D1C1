namespace GitExercise
{
    class myClass
    {
        private string navn;
        private string adresse;
        private int postnr = 4500;
        public myClass(string navn,string adresse)
        {
            this.Navn = navn;
            this.Adresse = adresse;
        }
        public string Navn { get => navn; set => navn = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Postnr { get => postnr; set => postnr = value; }

        public override string ToString(){
            return $"{Navn} bor på {Adresse},{Postnr}";
        }
    }
}