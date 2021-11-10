using System;
using System.Collections.Generic;
using System.Text;

namespace DictionariesTest
{
    class Country
    {
        public string Name { get; set; }
        public string capital { get; set; }
        public string code { get; set; }

        public Country(string _name, string _capital, string _code)
        {
            this.Name = _name;
            this.capital = _capital;
            this.code = _code;
        }
    }
}
