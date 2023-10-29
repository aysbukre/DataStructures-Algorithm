using DataStructures.LinkedList.SinglyLinkedList;
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
            var linkedlist = new SinglyLinkedList<int>();
            linkedlist.AddFirst(1);
            linkedlist.AddFirst(2);
            linkedlist.AddFirst(3);
            //3 2 1  ekleme yapılırken o(1) complexitysine sahip
            linkedlist.AddLast(4);
            linkedlist.AddLast(5);
            //3 2 1 4 5 sona ekleme yapılırken o(n) complexitysine sahip çünkü içinde bir döngü daha var
            Console.ReadKey();
            //var p1 = new DataStructures.Array.Array<int>(1,2,3,4); generic array/ it accepts IEnumarable contrats / bu tüzden parametre olarak bu ifadeyi çalıştırabiliriz.
            //var p2 = new int[] { 8,9,10,11}; classic array / works 
            //var p3 = new List<int>() { 55, 9, 66, 77 }; generic list / collection/ works 
            //var p4 = new ArrayList() { 78,79,81,20}; arraylist / not works/ array list does not convert to int
            // arraylist objecte bağlı çalışır. boxing ve unboxing vs gibi durumlarda tip güvenliğini kaybederiz. bu yüzden arraylist kullanamayız
            // IEnumerable foreach yapısını destekleyecek tip güvenliğini sağlayacak

            // -----------------------------------------------------

            

            //var arr = new DataStructures
            //    .Array
            //    .Array<int>();
            //generic array büyütme ve küçültme
            //for (int i = 0; i <8; i++) 
            //{
            //    arr.Add (i+1);
            //    Console.WriteLine($"{i+1} added");
            //    Console.WriteLine($"{arr.Count}/{arr.Capacity}");
            //}

            //Console.WriteLine("------");

            //// reverse
            //for (int i = arr.Count; i >= 0; i--)
            //{
            //    Console.WriteLine($"{arr.Remove()} removed");
            //}


            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            // artık array üzerinden işlemler yapabiliriz.
            //mesela count ve capacity bilgilerini buradan alabiliriz artık.
            //arr.Add(23);
            //arr.Add(25);
            //arr.Add(27);
            //arr.Add(35);
            //arr.Add(38);
            //arr.Remove();

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------");
            //arr.Where(x => x %2 == 0)
            //    .ToList().ForEach(x => Console.WriteLine(x));

            //Console.WriteLine($"{arr.Count}/{arr.Capacity}");
            //Console.ReadKey();
        }
    }
}
