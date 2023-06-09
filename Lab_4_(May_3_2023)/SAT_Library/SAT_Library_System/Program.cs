using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT_Library_System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>(); // list that stores all of the added books
            char option;
            do
            {
                Console.Clear();
                option = Print_menu(); // prints main menu and gets option from user
                if (option == '1') 
                {
                    Console.Clear();
                    Console.WriteLine("Enter Book Name: ");
                    string Book_name = Console.ReadLine();
                    Console.WriteLine("Enter Books Author Name: ");
                    string Author = Console.ReadLine();
                    Console.WriteLine("Enter Number of pages: ");
                    int Pages = int.Parse(Console.ReadLine());
                    List<string> chapters = Get_Chapters();
                    Console.WriteLine("Enter Price of the Book: ");
                    int Price = int.Parse(Console.ReadLine());
                    Book newbook = new Book(Book_name, Author, Pages, chapters, Price); // creates a new book
                    books.Add(newbook); // adds the book to the list of books
                    Console.WriteLine("Book Added Press any key to continue..");
                    Console.ReadKey();
                }
                else if (option == '2') 
                {
                    Console.Clear();
                    Console.WriteLine("Enter The Name of the Book You want to Borrow");
                    string book_name = Console.ReadLine();
                    Book book = Get_Book(books, book_name); // if book is present in books list then it'll return book else null
                    Borrow_book(book); // borrow book function
                    Console.WriteLine(  "Press Any Key to Exit");
                    Console.ReadKey();
                }
                else if (option == '3') 
                {
                    Console.Clear();
                    Console.WriteLine("Enter The Name of the Book You want to Borrow");
                    string book_name = Console.ReadLine();
                    Book book = Get_Book(books, book_name); 
                    GetsetBookMark(book);
                    Console.WriteLine("Press Any Key to Exit");
                    Console.ReadKey();
                }
                else if (option == '4') 
                {
                    Console.Clear();
                    Console.WriteLine("Enter the Name of the book : ");
                    string book_name = Console.ReadLine();
                    Book book = Get_Book(books, book_name);
                    if (book != null)
                    {
                        Console.WriteLine("Enter The Chapter Number : ");
                        int chapternumber = int.Parse(Console.ReadLine());
                        if (chapternumber <= book.Chapters.Count) // this condition check if user entered chapter number is less or equal to number of chapters in a book
                        {
                            string chapter = book.GetChapter(chapternumber);
                            Console.WriteLine("The Chapter Name is : " + chapter);
                        }
                        else
                        {
                            Console.WriteLine("No Chapter");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Book is not present");
                    }
                    Console.WriteLine("Press Any Key to Exit");
                    Console.ReadKey();
                }
                else if (option == '5') 
                {
                    Console.Clear();
                    Console.WriteLine("Enter the Name of the book : ");
                    string book_name = Console.ReadLine();
                    Book book = Get_Book(books, book_name);
                    if (book != null)
                    {
                        if (book.IsAvailable == false)
                        {
                            book.IsAvailable = true;
                            book.SetBookMark(0);
                            Console.WriteLine("Book is Returned");
                        }
                        else
                        {
                            Console.WriteLine("Book is not borrowed");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Book is not present");
                    }
                    Console.WriteLine("Press Any Key to Exit");
                    Console.ReadKey();
                }
            } while (option != 0);
        }

        static void GetsetBookMark(Book book) // prints the bookmarks of the book and also changes it to new bookmarks
        {
            if (book != null)
            {
                Console.WriteLine("Press the following Options.");
                Console.WriteLine("1. See BookMark");
                Console.WriteLine("2. SetBookMarks");
                char option = char.Parse(Console.ReadLine());
                if (option == '1')
                {
                    Console.WriteLine("The Book " + book.Name + " is bookmarked at " + book.GetBookMark());
                }
                else if (option == '2')
                {
                    Console.WriteLine("The Book " + book.Name + " is bookmarked at " + book.GetBookMark());
                    Console.WriteLine("Enter New bookmarks number: ");
                    int number = int.Parse(Console.ReadLine());
                    if (number <= book.Pages) // validates in case user enteres a bookmark page that is greater than number of pages present in a book
                    {
                        book.SetBookMark(number);
                        Console.WriteLine("BookMarked Succesffully");
                    }
                }
            }
            else
            {
                Console.WriteLine("Book is not present");
            }
        }

        static void Borrow_book(Book book) // borrow book sets the book isavailable attribute to false
        {
            if (book != null)
            {
                if (book.IsAvailable == true)
                {
                    book.IsAvailable = false;
                    Console.WriteLine("Book Borrowed");
                }
                else
                {
                    Console.WriteLine("Book is Not Available");
                }
            }
            else
            {
                Console.WriteLine("Book is not available");
            }
        }
        static char Print_menu() // prints menu option and takes option number input from user
        {
            char option;
            Console.WriteLine("Enter Any of the below option");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. See Bookmark");
            Console.WriteLine("4. See Name of the Chapter");
            Console.WriteLine("5. Return the Book");
            Console.WriteLine("0. Exit");
            option = char.Parse(Console.ReadLine());
            return option;
        }

        static List<string> Get_Chapters() // this function inputs chapters of book from the user
        {
            List<string> chapters = new List<string>();
            Console.WriteLine("Enter How many chapters you want to enter: ");
            int nof_chapters = int.Parse(Console.ReadLine());
            for (int current_chapter = 0; current_chapter < nof_chapters; current_chapter++)
            {
                string chapter = Console.ReadLine();
                chapters.Add(chapter);
            }
            return chapters;
        }

        static Book Get_Book(List<Book> books, string name) // returns the book if book is present in the books list else returns null
        {
            foreach (Book book in books)
            {
                if (book.Name == name)
                {
                    return book;
                }
            }
            return null;
        }
    }
}
