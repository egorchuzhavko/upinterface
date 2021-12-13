using System;
using System.Collections;
using System.Collections.Generic;

namespace zd33
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mas = {"first", "second", "third"};
            var firstarray = new Arr(mas, mas.Length);

            string[] mas2 = {"first", "fourth", "fifth", "second", "sixth"};
            var secondarray = new Arr(mas2, mas2.Length);
            
            Console.WriteLine("First array:");
            firstarray.Show();
            Console.WriteLine("\n\nSecond array:");
            secondarray.Show();
            
            Console.WriteLine("\n\nTry to find 2nd el in first");
            firstarray.Show(1);
            Console.WriteLine("\n\nTry to find 11th el in second");
            secondarray.Show(10);
            
            firstarray.SetDataByIndex(2,"eleventh");
            secondarray.SetDataByIndex(3, "fifteenth");

            Console.WriteLine("\n\nUpdated first array:");
            firstarray.Show();
            Console.WriteLine("\n\nUpdated second array");
            secondarray.Show();

            var third = Arr.NewClWithoutException(firstarray, secondarray);
            Console.WriteLine("\n\nNew third array without exception already existing elements:");
            third.Show();

            var fouth = Arr.NewClWithException(firstarray, secondarray);
            Console.WriteLine("\n\nNew fourth array with exception already existing elements:");
            fouth.Show();

            Arr clon = (Arr) fouth.Clone();
            Console.WriteLine(clon + "\n");

            foreach (var VARIABLE in clon)
            {
                Console.WriteLine(VARIABLE);
            }

            List<Arr> list = new List<Arr>();
            list.Add(firstarray);
            list.Add(third);
            list.Add(secondarray);

            Console.WriteLine();
            foreach (var VARIABLE in list)
            {
                Console.WriteLine(VARIABLE);
            }
            list.Sort(new Arr());
            Console.WriteLine();
            
            foreach (var VARIABLE in list)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}