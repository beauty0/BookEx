using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Book hp = new Book(1234, "Harry Potter", "JK Rowling", 1997, 12.50, BookTypeEnum.SoftCover);
            Console.WriteLine($"The cost of buyin 2 books is {hp.BulkBuying(2)} euro");
            Console.WriteLine($"The book is {hp.GetAge()} years old ");


            //Getting all the information from the user. 
            Book lotr = new Book();
                             
            Console.WriteLine("Please enter the ISBN");
            lotr.ISBN = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title");
            lotr.Title = Console.ReadLine();
            Console.WriteLine("Please enter the Author");
            lotr.Author = Console.ReadLine();
            Console.WriteLine("Please enter year published");
            lotr.YearPub = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the price");
            lotr.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("What type of Book is it?");
            Console.WriteLine("Please enter a number corresponding to the type");
            Console.WriteLine("1. hardback 2. Soft Cover 3. EBook");
            int type = int.Parse(Console.ReadLine());
            if(type == 1)
            {
                lotr.BookType = BookTypeEnum.HardBack;
            }
            else if (type ==  2)
            {
                lotr.BookType = BookTypeEnum.SoftCover;
            }
            else if(type == 3)
            {
                lotr.BookType = BookTypeEnum.Ebook;
            }
            else
                Console.WriteLine("That is not an option ");
            //Would have a loop here until the user enters a correct value for the enum. 
            Console.WriteLine($"The book type is {lotr.BookType} ");


            Console.WriteLine("Please enter how many you bought?");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine($"The cost of buying {amount} books is {lotr.BulkBuying(amount)} euro");
            Console.WriteLine($"The book is {lotr.GetAge()} years old ");


            Console.ReadKey();
                
        }
    }
}
