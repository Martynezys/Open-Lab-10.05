using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Book LOTR = new Book("Lord of The Rings", 1028, "Fantasy", "Oliver Krska", 1985);

            Book LOTR2 = new Book();

            Book LOTR3 = new Book("Lord of The Rings 3", 512);

            Book HOBIT = new Book("Hobit", 420, "Fantasy", "Oliver Krska", 1937);

            HOBIT.Category = Book.categoryList[4];  

            
            Console.WriteLine(LOTR.ToString());
            Console.WriteLine(LOTR2.ToString());
            Console.WriteLine(LOTR3.ToString());
            Console.WriteLine(HOBIT.ToString());
            Console.ReadLine();

        }
    }
}