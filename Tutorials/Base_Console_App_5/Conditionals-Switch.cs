using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Console_App_5
{
    internal class Conditionals_Switch
    {
        //static void Main(string[] args)
        //{
            
        //    Random rand = new Random();
        //    int[] ageArray = new int[10];

        //    for (int i = 0; i < 10; i++)
        //        ageArray[i] = rand.Next(1, 50);

        //    foreach (int i in ageArray)
        //        Console.WriteLine("If-Else: " + i);

        //    Console.WriteLine( "Len: " + ageArray.Count() ) ;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        int age = ageArray[i];

        //        if ( age >= 18 )
        //            Console.WriteLine($"\t User with {age} is eligible to vote");
        //        else if (age >= 10 && age <= 17)
        //            Console.WriteLine($"\t User with {age} is NOT eligible to vote");
        //        else
        //            Console.WriteLine($"\t User with {age} is very young! ");
        //    }

        //    var ageArray2 = new List<int>();

        //    for (int i = 1; i <= 10; i++)
        //        ageArray2.Add(rand.Next(1, 50));

        //    foreach (int i in ageArray2)
        //        Console.WriteLine("Switch: " + i);

        //    Console.WriteLine( "Switch Case!");
        //    for (int i = 0; i < 10; i++)
        //    {
        //        int age = ageArray2.ElementAt(i);

        //        Console.WriteLine( "\t " + getAgeSwitch(age));
        //        Console.WriteLine("\t \t" + getAgeSwitch_2(age));
        //    }
        //}

        static string getAgeSwitch(int age)
        {
            switch (age)
            {
                case (>= 18): return $"User with {age} is eligible to vote";
                case (>= 10 and <= 17): return $"User with {age} is NOT eligible to vote";
                default: return $"User with {age} is very young! ";
            }
        }

        //Functional Language Style
        static string getAgeSwitch_2(int age) =>
            age switch
            {
                >= 18 => $"User with {age} is eligible to vote",
                ( >= 10 and <= 17) => $"User with {age} is NOT eligible to vote",
                _ => $"User with {age} is very young! "
            };
    }
}
