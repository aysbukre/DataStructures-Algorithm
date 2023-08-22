using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new DataStructures
                .Array
                .Array<int>();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            // artık array üzerinden işlemler yapabiliriz.
            //mesela count ve capacity bilgilerini buradan alabiliriz artık.
            arr.Add(23);
            arr.Add(25);
            arr.Add(27);
            arr.Add(35);
            arr.Add(38);
            //arr.Remove();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");
            arr.Where(x => x %2 == 0)
                .ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine($"{arr.Count}/{arr.Capacity}");
            Console.ReadKey();
        }
    }
}
