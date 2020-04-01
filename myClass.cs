namespace GitExercise
{
    class myClass
    {
        private string navn;
        public myClass(string navn)
        {  
            this.Navn=navn;
        }

        public string Navn { get => navn; set => navn = value; }
    }
}