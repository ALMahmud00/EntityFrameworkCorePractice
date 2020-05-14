using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCorePractice
{
    class Book
    {
        
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Stock { get; set; }

        public void Display()
        {
            Console.Write("Book Code : " + Id + "\t");
            Console.Write("Book name : " + Name + "\t");
            Console.Write("Author : " + Author + "\t");
            Console.WriteLine("Stock : " + Stock + "\t");
            Console.WriteLine("================================");
        }
       
    }
}
