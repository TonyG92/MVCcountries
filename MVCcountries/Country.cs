using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCcountries
{
    class Country
    {
        private string name;
        private string continent;
        private List<string> colors;
        
        //Properties getters and setters (fields)
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Continent
        {
            set { continent = value; }
            get { return continent; }
        }

        public List<string> Colors
        {
            set { colors = value; }
            get { return colors; }
        }

        //Constructors
        public Country(string _name, string _continent, List<string> _colors)
        {
            name = _name;
            continent = _continent;
            colors = _colors;
        }
    

       
    }
}
