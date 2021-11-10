namespace DictionariesTest
{
    class Country
    {
        public string name { get; set; }
        public string capital { get; set; }
        public string code { get; set; }

        public Country(string _name, string _capital, string _code)
        {
            this.name = _name;
            this.capital = _capital;
            this.code = _code;
        }
    }
}
