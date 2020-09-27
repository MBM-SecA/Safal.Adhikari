using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //LINQ Language Integrated Query

            int[] numbers = { 34, 56, 23, 67, 73, 20, 78, 56, 45, 34, 27, 89, 57};
            
            // Fetch numbers which are greater the 50

            //using method syntax - lambda expression
            var result1 = numbers.Where(x => x > 50 && x < 70); //declerative programming
        
            //Using SQL query syntax - query expression
            var result2 = from num in numbers
                          where num > 50 && num < 70
                          select num;

            
            string[] names= {"ram","shyam","hari", "Rupesh", "sita","laxman", "ronaldo", "Ramesh"};

            //names with length >3 and initial letter R 
            var result3 = names.Where(x => x.Length > 3 && x.StartsWith("r"));

            var result4 = from x in names
                          where x.Length > 3 && x.ToLower().StartsWith("r")
                          select x;

            /*foreach(var name in result4)
            {
                Console.WriteLine(name);
            }*/

            var countries = Country.GetCountries();

            var asianCountries = from country in countries
                                 where country.Continent == "Europe"
                                 select country.Name;

            
            var countriesPopulation = from population in countries
                                      where population.Population < 100000
                                      select population.Name;
                                      
                                      

            foreach(var population in countriesPopulation)
            {
                Console.WriteLine(population);
            }



            
            //HW1: List Countries in Europe which has population less than 100k
            //HW2: List countries in Asia which are not ever invaded.
        
        }
    }
}
