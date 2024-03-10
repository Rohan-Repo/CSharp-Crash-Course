using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Async_Await_Tasks
{
    internal class Linq_Method_Vs_Query_Syntax
    {
        /*
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Student Name: ");
            string name = Console.ReadLine();

            string[] subjectList = { "C", "C++", "Java", "HTML-CSS-JS", "C#", "SQL", "Python", "Excel", "Maths", "English" };
            
            var student_marks = new Dictionary<string, int>();
            Random random = new Random();

            var scoreList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int num = random.Next(10, 100);
                
                student_marks.Add( subjectList[i], num );
            }

            Console.WriteLine( "\n Student Name = " + name );
            Console.WriteLine($"\n Student's Marks: ");
            foreach (var marks in student_marks)
                Console.WriteLine( $"\t {marks.Key} : {marks.Value}" );

            Console.WriteLine( "\n Find Grades which are greater than 50: " );
            var marksList = student_marks.Values.ToList();

            var passedSubjectsList_linq_query =
                                 from marks in marksList // Collection
                                 where marks >= 50 // Filtering
                                 orderby marks descending // Sorting
                                 select marks; // filtered & sorted data

            var passedSubjectsList_linq_method = marksList
                                            .Where(sub => sub >= 50)
                                            .OrderByDescending(sub => sub);

            Console.WriteLine("\n Linq Method Syntax Values : ");
            foreach (var item in passedSubjectsList_linq_method)
                Console.Write(item + "\t");

            Console.WriteLine($"\n\n\t Student has passed in {passedSubjectsList_linq_query.Count()} subjects!");
            foreach (var marks in passedSubjectsList_linq_query)
            {
                var key = student_marks.FirstOrDefault( x => x.Value == marks ).Key;
                Console.WriteLine( "\t\t" + key + " : " + marks);
            }

            var failedSubjectsList_linq_query = 
                                            from marks in marksList // Collection
                                            where marks < 50 // Filtering
                                            orderby marks descending // Sorting
                                            select marks; // filtered & sorted data

            var failedSubjectsList_linq_method =
                                            marksList
                                            .Where(sub => sub < 50)
                                            .OrderByDescending(sub => sub);

            Console.WriteLine("\n Linq Query Syntax Values : ");
            foreach (var item in failedSubjectsList_linq_query)
                Console.Write(item + "\t");

            Console.WriteLine($"\n\n\t Student has failed in {failedSubjectsList_linq_method.Count()} subjects!");
            foreach (var marks in failedSubjectsList_linq_method)
            {
                var key = student_marks.FirstOrDefault(x => x.Value == marks).Key;
                Console.WriteLine("\t\t" + key + " : " + marks);
            }

            var sumOfMarks = student_marks.Sum( stud_marks => stud_marks.Value);
            var avgOfMarks = student_marks.Average(stud_marks => stud_marks.Value);

            Console.WriteLine("\n Total Marks = " + sumOfMarks + "\t Aggregate Percentage = " + avgOfMarks + " %" );
        } 
        */
    }
}
