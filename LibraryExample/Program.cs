using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Decorator Design Pattern.
    /// </summary>
    class Program
    {    
        /// <summary>
         /// Entry point into console application.
         /// </summary>
        static void Main(string[] args)
        {      // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            // Wait for user
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
