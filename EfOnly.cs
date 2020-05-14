using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkCorePractice
{
    class EfOnly
    {
        MyDbContext db = new MyDbContext();

        public void EfExecute()
        {
            Option();
            while (true)
            {
                Console.WriteLine("\nPlease Select an Option");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=============================");
                if (option == 1)
                {
                    Insert();
                }
                else if (option == 2)
                {
                    BorrowBook();
                }
                else if (option == 3)
                {
                    ReturnBook();
                }
                else if (option == 4)
                {
                    DisplayBook();
                }
                else if (option == 5)
                {
                    Console.WriteLine("Thanks");
                    break;
                }
                Console.WriteLine("=============================");
            }

        }

        public void Option()
        {
            Console.WriteLine("Welcome to ABC Library System!\n" +
               "1: Add Book\n" +
               "2: Borrow Book\n" +
               "3: Return Book\n" +
               "4: Display List\n" +
               "5: Exit\n" +
               "============================");
        }

        public void Insert()
        {
            Console.Write("Book Name: ");
            string name = Console.ReadLine();
            Console.Write("Book Code: ");
            string code = Console.ReadLine();
            Console.Write("Author Name: ");
            string author = Console.ReadLine();
            Console.Write("Book Stock: ");
            int stock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Successfully Book Added in Library!");

            Book book = new Book() { Id = code, Name = name, Author = author, Stock = stock };

            db.Add(book);
            db.SaveChanges();
        }
        public void BorrowBook()
        {
            Console.Write("Enter book code to Borrow : ");
            string code = Console.ReadLine();
            Console.Write("Enter quantity : ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            var book = db.bookList.Where(x => x.Id == code).FirstOrDefault();

            if(book.Stock < quantity)
            {
                Console.WriteLine("out of stock");
            }
            else
            {
                book.Stock -= quantity;
                db.SaveChanges();
                Console.WriteLine("book borrowed success");
            }
            
        }
        public void ReturnBook()
        {
            Console.Write("Enter book code to return : ");
            string code = Console.ReadLine();
            Console.Write("Enter quantity : ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            var book = db.bookList.Where(x => x.Id == code).FirstOrDefault();

            book.Stock += quantity;
            db.SaveChanges();
            Console.WriteLine("book returned success");
        }
        public void DisplayBook()
        {
            var AllBook = db.bookList;

            foreach (var item in AllBook)
            {
                item.Display();
            }
        }
    }
}