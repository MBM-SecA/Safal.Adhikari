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

            foreach(var name in result4)
            {
                Console.WriteLine(name);
            }

            //Projections

            var result5 = numbers.Select(x => x * x);
            /*foreach(var square in result5)
            {
                Console.WriteLine(square);
            }*/

            //to arrange numbers in ascending
            var result6 = from num in numbers
                          orderby num   
                          select num;
            
            /*foreach(var num in result6)
            {
                Console.WriteLine(num);
            }*/

            /*var result7 = from name in names
                          orderby name descending
                          select name;

            foreach(var name in result7)
            {
                Console.WriteLine(name);
            }*/

            var result7 = numbers.Take(5);

            /*foreach(var num in result7)
            {
                Console.WriteLine(num);
            }*/ 

            //partitioning
            var result8 = numbers.Skip(5).Take(5);

            foreach(var num in result8)
            {
                Console.WriteLine(num);
            }

            //Quantifiers
            var result9 = numbers.Any(x => x % 2 == 0);
            var result10 = numbers.All(x => x % 2 == 0);
            var result11 = numbers.Contains(34);

            var result12 = Enumerable.Range(1, 1000);
            var result13 = Enumerable.Repeat("Hello World!", 10);
            
            foreach(var num in result13)
            {
                Console.WriteLine(num);
            }



            ComplexType complexType = new ComplexType();
            complexType.LearnRestrictions();
        }
    }
}
