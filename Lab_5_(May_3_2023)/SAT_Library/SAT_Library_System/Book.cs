using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT_Library_System
{
    class Book
    {
        // attributes of the class
        public string Name;
        public string Author;
        public int Pages;
        public List<string> Chapters = new List<string>();
        public int Bookmark = 0;
        public int Price;
        public bool IsAvailable = true;
        
        // constructor
        public Book(string name, string author, int pages, List<string> chapters, int price)
        {
            this.Name = name;
            this.Author = author;
            this.Pages = pages;
            this.Chapters = chapters;
            this.Price = price;
        }

        public string GetChapter(int chapternumber) // returns string chapter from chapter list
        {
            return Chapters[chapternumber];
        }

        public int GetBookMark() // returns bookmark of the book
        {
            return Bookmark;
        }

        public void SetBookMark(int bookmark) // sets the bookmark of the book
        {
            Bookmark = bookmark;
        }

        public int GetBookPrice() // returns the price of the book
        {
            return Price;
        }

        public void SetBookPrice(int price) // sets the book price
        {
            Price = price;
        }
    }

}
