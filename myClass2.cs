namespace git_exercise_D1C1
{
    public class myClass2
    {
        private string navn;
        private string adresse;
        private int postnr = 4500;
        private string by;
        public myClass2(string navn, string adresse, string by)
        {
            this.Navn = navn;
            this.Adresse = adresse;
            this.By = by;
        }
        public string Navn { get => navn; set => navn = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Postnr { get => postnr; set => postnr = value; }
        public string By { get => by; set => by = value; }

        public override string ToString()
        {
            return $"{Navn} bor på {Adresse},{Postnr},{By}";
        }
    }
}