using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Async_Await_Tasks
{
    internal class Linq_Eg
    {
        //static void Main(string[] args)
        //{
        //    Random random = new Random();

        //    var numList = new List<int>();

        //    for (int i = 0; i < 10; i++)
        //    {
        //        int num = random.Next(10 * i, 20 * i);
        //        //Console.WriteLine( num );
        //        numList.Add( num );
        //    }
                
        //    Console.WriteLine( "Original List = " );
        //    printList(numList);

        //    Console.WriteLine("\n Even Numbers = ");

        //    var evenNums = from num in numList
        //                   where num % 2 == 0
        //                   select num;

        //    printList(evenNums.ToList());

        //    Console.WriteLine("\n Odd Numbers = ");

        //    var oddNums = from num in numList
        //                   where num % 2 != 0
        //                   select num;

        //    printList(oddNums.ToList());

        //    int[] arr_1 = { 10, 20, 30, 50, 60 };
        //    int[] arr_2 = { 1, 2, 3, 5, 6 };

        //    int dotProduct = arr_1.Zip( arr_2, (a, b) => a * b).Sum();
        //    Console.WriteLine( "\n \n Dot Product = " + dotProduct );

        //}

        static void printList(  List<int> list)
        {
            foreach (var item in list)
                Console.Write(item + "\t");
        }
    }
}
