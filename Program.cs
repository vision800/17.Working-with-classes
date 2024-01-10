using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Working_with_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book book = new Book();

            //book.title = "Faith Hub";
           // book.author = "Vision";
           // book.pages = 450;

            //Console.WriteLine(book.title);
            //Console.WriteLine(book.author);
           // Console.WriteLine(book.pages);

            List<Book> books = new List<Book>();

          //books.Add(book);


            //adding a book from the user input 
            Console.WriteLine("====how many books do you want to save?====");
            int numOfBooks = int.Parse(Console.ReadLine());

            for(int i=0; i<numOfBooks; i++)
            {
                Console.WriteLine("==========Enter Book" + (i + 1)+"=========");
                Console.WriteLine("Enter a book title");
                string title = Console.ReadLine();
                Console.WriteLine("Enter a book Author");
                string author = Console.ReadLine();
                Console.WriteLine("Enter a book number of pages");
                int pages = int.Parse(Console.ReadLine());

                books.Add(new Book(title,author,pages));
            }


            Console.WriteLine("==========Printing out the results========");
            for  (int i=0;i<books.Count;i++) 
            {
                Console.WriteLine("==Book " + (i + 1) + " ===");
                Console.WriteLine("Book title: "+books[i].title);
                Console.WriteLine("Book author: "+books[i].author);
                Console.WriteLine("Book pages: " + books[i].pages);

            }
        }
    }
}
