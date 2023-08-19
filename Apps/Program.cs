using System;
using System.Collections;
using System.Collections.Generic;

namespace Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new DataStructures
                .Array
                .Array<int>();
            // artık array üzerinden işlemler yapabiliriz.
            //mesela count ve capacity bilgilerini buradan alabiliriz artık.
            arr.Add (23);
            arr.Add(25);
            arr.Add(27);
            arr.Add(35);
            Console.WriteLine($"{arr.Count}/{arr.Capacity}");
            Console.ReadKey();
        }
    }
}
