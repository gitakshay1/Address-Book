using System;
namespace Address_Book
{
    public class Program
    {
        static void Main(string[] args)
        {
            Addresbook book= new Addresbook();
            book.CreateContact();
            while (true)
            {
                Console.WriteLine("1.Create Contact\n2.DisplayContact\n3.EditContact");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        book.CreateContact();
                        break;
                    case 2:
                        book.DisplayContact();
                        break;
                    case 3:
                        book.EditContact();
                        break;
                }

            }
        }
    }
}
