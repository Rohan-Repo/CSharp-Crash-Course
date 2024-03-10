using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Async_Await_Tasks
{
    internal class Linq_Vs_Nrml_Eg
    {
        public record Book_List(Guid bookID, string bookTitle, double bookPrice);

        //static void Main(string[] args)
        //{
        //    var bookList = new List<Book_List>()
        //    {
        //        new Book_List( Guid.NewGuid(), "Advanced C#", 9.99 ),
        //        new Book_List( Guid.NewGuid(), "ASP.NET MVC Core", 89.99 ),
        //        new Book_List( Guid.NewGuid(), "OOP with C#", 19.99 ),
        //        new Book_List( Guid.NewGuid(), "C# for Beginners", 12.99 )
        //    };

        //    //Finding and Sorting Books containing C#

        //    Console.WriteLine("\n Without Linq : ");

        //    Console.WriteLine("\t Book List Initially : ");
        //    foreach (var book in bookList)
        //        Console.WriteLine("\t" + book.bookID + " : " + book.bookTitle + "\t - $" + book.bookPrice);

        //    Console.WriteLine("\n\t Book List After Sort: ");
        //    bookList.Sort(new BookPriceComparer());

        //    foreach (var book in bookList)
        //        Console.WriteLine("\t" + book.bookID + " : " + book.bookTitle + "\t - $" + book.bookPrice);

        //    Console.WriteLine("\n\t Books With C# : ");
        //    foreach (var book in bookList)
        //    {
        //        if (book.bookTitle.Contains("C#"))
        //        {
        //            Console.WriteLine("\t\t" + book.bookTitle);
        //        }
        //    }

        //    Console.WriteLine("\n With the help of Linq No Comparer nothing just like SQL, sorting, filtering is faster: ");
        //    Console.WriteLine("\t Books with C# ordered by Price!");
        //    var linqBookList = bookList
        //                               .Where(b => b.bookTitle.Contains("C#"))
        //                               .OrderBy(b => b.bookPrice);

        //    foreach (var book in linqBookList)
        //        Console.WriteLine("\t\t" + book.bookID + " : " + book.bookTitle + "\t - $" + book.bookPrice);


        //}

        private class BookPriceComparer : Comparer<Book_List>
        {
            public override int Compare(Book_List x, Book_List y)
            {
                return x.bookPrice.CompareTo(y.bookPrice);
            }
        }
    }
}
