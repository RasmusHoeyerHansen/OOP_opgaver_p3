namespace ConsoleApp1
{
    class Person
    {
        //Static: Fælles variable der gælder for alle instanser af klassen
        private static int _counter = 0;
        private string _fornavn;
        private int _personID;
        //private string _efternavn;
        //private int _alder;
        private Person _far;

        public Person()
        {
            PersonID = _counter;
            _counter++;
        }

        public Person(Person far)
            : this()
        {
            _far = far;
        }

        public string Fornavn 
        {
            get
            {
                return _fornavn;
            }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _fornavn = value;
            }
        }

        public int PersonID { get; }

        public Person Far
        {
            get
            {
                return _far;
            }
            set
            {
                _far = value;
            }
        }

        public override string ToString()
        {
            return Fornavn;
        }
    }
}
