using System;
using System.Linq;
using System.Collections.Generic;


public class ComplexType
{  
            var countries = Country.GetCountries();

            var asianCountries = from country in countries
                                 where country.Continent == "Europe"
                                 select country.Name;


            //HW1: List Countries in Europe which has population less than 100k
            //HW2: List countries in Asia which are not ever invaded.
            
            var europeanCountries = from country in countries
                                    where country.Continent == "Europe" && country.Population < 100000
                                    select country;
                                      
                                      
            var nonInvadedAsian = from country in countries
                                  where country.Continent == "Asia" && country.IndependenceDay == default
                                  select country;


            Console.WriteLine("European Countries with population less than 100k");
            foreach(var x in europeanCountries)
            {
                
                Console.WriteLine(x.Name);
            }

            Console.WriteLine("Asian Countries which were never invaded");
            foreach(var x in nonInvadedAsian)
            {
               
                Console.WriteLine(x.Name);
}
            
            //HW - Is there any african country in you country collection
            //HW - Print first 2 largest asian country names



            
            
        