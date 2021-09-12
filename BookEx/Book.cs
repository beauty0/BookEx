using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEx
{
    class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPub { get; set; }
        public double Price { get; set; }
        public BookTypeEnum BookType { get; set; }

        public Book()
        { }

        public Book(int isbn, string title, string auth, int yr, double price)
        {
            ISBN = isbn;
            Title = title;
            Author = auth;
            YearPub = yr;
            Price = price;
        }
        public Book(int isbn, string title, string auth, int yr, double price, BookTypeEnum type)
        {
            ISBN = isbn;
            Title = title;
            Author = auth;
            YearPub = yr;
            Price = price;
            BookType = type;
        }

        public double BulkBuying(int noPurchased)
        {
            return Price * noPurchased;

            //Broken down version of line 31
            //double answer;

            //answer = Price * noPurchased;

            //return answer;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - YearPub;
        }

    }
}
