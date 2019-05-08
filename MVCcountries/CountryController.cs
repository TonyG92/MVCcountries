using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCcountries
{
    class CountryController
    {

        private List<Country> countrydB;

        public List<Country> CountrydB
        {
            set { countrydB = value; }
            get { return countrydB; }
        }

        public CountryController(List<Country> _countrydB)
        {
            countrydB = _countrydB;
        }

        public void CountryAction(Country c)
        {
           CountryView view = new CountryView(c);

            view.Display();
 
        }

        public void WelcomeAction()
        {
           

            string response = "y";

            while(response == "y")
            {
                Console.Clear();

                CountryListView listview = new CountryListView(CountrydB);

                Console.WriteLine($"Hello, welcome to the country app. \nPlease select a country from the following list: {listview} ");

                listview.Display();

                string userInput = Console.ReadLine();

                if(int.TryParse(userInput, out int userNumber))
                {
                    if(userNumber >= 0 && userNumber < countrydB.Count)
                    {
                        CountryAction(countrydB[userNumber]);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 0 and 2");
                    }
                   
                }
                else
                {
                    Console.WriteLine("Please enter a number between 0 and 2");
                }
                //for (int i = 0; i < CountrydB.Count; i++)
                //{
                //    if (userInput == i.ToString())
                //    {
                //        CountryAction(CountrydB[i]);
                //        break;
                //    }
                
                //}

                Console.WriteLine("Would you like to learn about another country> (y/n)");
                response = Console.ReadLine();
            }
           


        }




    }
}
