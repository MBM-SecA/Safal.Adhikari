using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main1()
        {
            //Task based parallel programming

            Stopwatch stopwatch = new Stopwatch();

            int[] numbers = { 12, 7, 4, 11, 10, 6 };

            //Sequential implementation

            stopwatch.Start();
            Console.WriteLine("Sequential Implementation");
            foreach (var num in numbers)
            {
                var f = Factorial(num);

                Console.WriteLine($"{num}! = {f}");
            }
            Console.WriteLine($"Time Taken: {stopwatch.ElapsedMilliseconds} ms");

            //Parallel Implementation
            stopwatch.Restart();
            Console.WriteLine("Parallel Implementation");
            Parallel.ForEach(numbers, num =>
            {
                var f = Factorial(num);
                Console.WriteLine($"{num}! = {f}");
            });
            Console.WriteLine($"Time Taken: {stopwatch.ElapsedMilliseconds} ms");
        }

        static long Factorial(long number)
        {
            Thread.Sleep(100);
            return 0;
        }


        
        static void Main2()
        {


            //Asynchronous Programming


            /*Making breakfast
                --making tea
                  - turn on the burner : 2 sec
                  - Place kettle on burner: 3 sec
                  - Pour Water : 5 sec
                  - Let it boil : 5 min
                  - Grind Masalas : 1min
                  - put sugar and masalas : 5 sec
                  - Pour milk : 5 sec
                  - Let it boil : 5 min

                
                  - Turn on burner : 2 sec
                  - put pan on and oil it : 30 sec
                  - Crack eggs and whisk it : 3 min
                  - Fry : 3 min
            */

            //Sequential version

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            TurnOnBurner();
            PutOnBurner("Kettle");
            Add("Water");
            Boil("Water");
            GrindTeaMasalas();
            PutSugarAndMasalas();
            Add("Milk");
            Boil("Milk");
            TurnOnBurner();
            PutOnBurner("Pan");
            AddOil();
            WhiskEggs();
            Fry();
            Serve();

            Console.WriteLine($"Time Taken: {stopwatch.ElapsedMilliseconds} ms");


            

            // Async way
        }

        static async Task Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await TurnOnBurner1();
            await PutOnBurner1("Kettle");
            await Add1("Water");
            await Boil1("Water");
            await GrindTeaMasalas1();
            await PutSugarAndMasalas1();
            await Add1("Milk");
            await Boil1("Milk");
            await TurnOnBurner1();
            await PutOnBurner1("Pan");
            await AddOil1();
            await WhiskEggs1();
            await Fry1();
            await Serve1();
 
            Console.WriteLine($"Time Taken: {stopwatch.ElapsedMilliseconds} ms");

        }



        //functions for sequrntioal method
        private static void Serve()
        {
            Console.WriteLine("Serve the breakfast");
            Thread.Sleep(5000);
        }

        private static void Fry()
        {
            Console.WriteLine("Frying eggs");
            Thread.Sleep(10000);
        }

        private static void WhiskEggs()
        {
            Console.WriteLine("Crack and Whisk eggs");
            Thread.Sleep(10000);
        }

        private static void AddOil()
        {
            Console.WriteLine("Adding oil");
            Thread.Sleep(2000);
        }

        private static void PutSugarAndMasalas()
        {
            Console.WriteLine("Adding Sugar and tea masalas");
            Thread.Sleep(2000);
        }

        private static void GrindTeaMasalas()
        {
            Console.WriteLine("Grinding tea masalas");
            Thread.Sleep(5000);
        }

        private static void Boil(string item)
        {
            Console.WriteLine($"Boiling {item}...");
            Thread.Sleep(10000);
        }

        private static void Add(string item)
        {
            Console.WriteLine($"Pouring {item}");
            Thread.Sleep(2000);
        }

        private static void PutOnBurner(string pot)
        {
            Console.WriteLine($"Placing {pot} on burner");
            Thread.Sleep(3000);
        }

        private static void TurnOnBurner()
        {
            Console.WriteLine("Turing on Burner");
            Thread.Sleep(2000);
        }


        //Functions for Asynchronous method

        private static Task Serve1()
        {
            Console.WriteLine("Serve the breakfast");
            Task.Delay(5000);
            return Task.CompletedTask;
        }

        private static Task Fry1()
        {
            Console.WriteLine("Frying eggs");
            Task.Delay(10000);
            return Task.CompletedTask;

        }

        private static Task WhiskEggs1()
        {
            Console.WriteLine("Crack and Whisk eggs");
            Task.Delay(10000);
            return Task.CompletedTask;

        }

        private static Task AddOil1()
        {
            Console.WriteLine("Adding oil");
            Task.Delay(2000);
            return Task.CompletedTask;

        }

        private static Task PutSugarAndMasalas1()
        {
            Console.WriteLine("Adding Sugar and tea masalas");
            Task.Delay(2000);
            return Task.CompletedTask;

        }

        private static Task GrindTeaMasalas1()
        {
            Console.WriteLine("Grinding tea masalas");
            Task.Delay(5000);
            return Task.CompletedTask;

        }

        private static Task Boil1(string item)
        {
            Console.WriteLine($"Boiling {item}...");
            Task.Delay(10000);
            return Task.CompletedTask;

        }

        private static Task Add1(string item)
        {
            Console.WriteLine($"Pouring {item}");
            Task.Delay(2000);
            return Task.CompletedTask;

        }

        private static Task PutOnBurner1(string pot)
        {
            Console.WriteLine($"Placing {pot} on burner");
            Task.Delay(3000);
            return Task.CompletedTask;

        }

        private static Task TurnOnBurner1()
        {
            Console.WriteLine("Turing on Burner");
            Task.Delay(2000);
            return Task.CompletedTask;

        }
    }
}
