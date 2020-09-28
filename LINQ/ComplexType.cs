using System;
using System.Linq;
using System.Collections.Generic;


public class ComplexType
{
    public void LearnRestrictions()
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
        foreach (var x in europeanCountries)
        {

            Console.WriteLine(x.Name);
        }

        Console.WriteLine("Asian Countries which were never invaded");
        foreach (var x in nonInvadedAsian)
        {
            Console.WriteLine(x.Name);
        }

        
        
        //HW - Is there any african country in you country collection
        //HW - Print first 2 largest asian country names


        var africanCountries = countries.Any( country => country.Continent == "Africa");

        if( africanCountries )
        {
            Console.WriteLine("There is african countries in the country collection \nAnd they are:");


            var african = countries.Where( country => country.Continent == "Africa");

            foreach (var country in african)
            {
                Console.WriteLine(country.Name);
            }

        }
        else
            Console.WriteLine("There is no any african countries in the country collection");

        var largestArea = countries.OrderByDescending(country => country.Area);

        var firstTwoLargestArea = largestArea.Take(2);
        Console.WriteLine("The country with largest area from the collection are:");
        foreach (var country in firstTwoLargestArea)
        {
            Console.WriteLine(country.Name);
        }



    }
}



