using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFinder_Indexer_
{
    class Indexer 
    {
      private string[] cities = new string[5];
      public string this[int i] 
        {
            set { this.cities[i] = value; }
            get { return this.cities[i]; }
        }

        public int Length 
        {
            get { return cities.Length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Indexer indexer = new Indexer();

            indexer[0] = "Dhaka";
            indexer[1] = "Chottogram";
            indexer[2] = "Cumilla";
            indexer[3] = "Shylet";
            indexer[4] = "Rajshahi";

            Console.WriteLine("Enter the city name you want to search: ");
            string city = Console.ReadLine();

            for (int i = 0; i < indexer.Length; i++) 
            {
                if (indexer[i] == city)
                {
                    Console.WriteLine();
                    Console.WriteLine("***City Found***");
                    flag = 1;
                    break;
                }
            }

            if (flag == 0) 
            {
                Console.WriteLine();
                Console.WriteLine("City Not Found!");
            }

        }
    }
}
