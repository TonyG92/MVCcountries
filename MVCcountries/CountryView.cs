using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCcountries
{
    class CountryView
    {
        private Country displaycountry;

        public  Country DisplayCountry
        {
            set { displaycountry = value; }
            get { return displaycountry; }
        }


        public CountryView(Country _displaycountry)
        {
            displaycountry = _displaycountry;
        }

        public void Display()
        {
            Console.WriteLine($"This countries name is {displaycountry.Name}" +
                $" and is from the continent of {displaycountry.Continent}" +
                $"and countries colors are: {string.Join("," , displaycountry.Colors)}");
            
            //Rich showed me the string.Join above
            //How i originally did it below
            //foreach(string Color in displaycountry.Colors)
            //{
            //    Console.WriteLine($"Display colors of the country: {Color}");
            //}


 
        }



         



    }
}
