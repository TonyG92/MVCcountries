using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCcountries
{
    class CountryListView
    {
        private List<Country> countries;

        public List<Country> Countries
        {
            set { countries = value; }
            get { return countries; }
        }

        public CountryListView(List<Country> _countries)
        {
            countries = _countries;


        }



        public void Display()
        {
            for(int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"Index: {i} Countries name: {Countries[i].Name}");
            }

        }



    }
}
