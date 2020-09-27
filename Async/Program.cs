using System;
using System.Net.Http;


namespace Async
{
    class Program
    {
        static async Task Main()
        {
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

            Stopwatch stopwatch = Stopwatch.StartNew();
            HttpClient client = new HttpClient();
            var google = client.GetStringAsync("www.google.com").Result;
            var m = client.GetStringAsync("www.microsoft.com").Result;
            var y = client.GetStringAsync("www.yahoo.com").Result;
            var g = client.GetStringAsync("www.github.com/MBM-SecA.com").Result;
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            var G = await client.GetStringAsync("www.google.com");
            var mM = await client.GetStringAsync("www.microsoft.com");
            var yy = await client.GetStringAsync("www.yahoo.com");
            var gg = await client.GetStringAsync("www.github.com/MBM-SecA.com");
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");





        }
    }
}
