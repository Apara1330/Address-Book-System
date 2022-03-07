using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
     class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("WELCOME TO ADDRESS BOOK SYSTEM");
            AddressBookDetails addressdetails = new AddressBookDetails();//object to call the methods

            string key = "a";

            while(key != "y")//while loop to repeat the process untill the user done with his work of adding and displaying
            {
                Console.WriteLine("Select the options: ");
                Console.WriteLine("1- Add Contact, 2- Display Contact");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1://to add details
                        addressdetails.AddDetails();
                        break;
                    case 2://to view list of all contacts
                        addressdetails.view();
                        break;
                }
                Console.WriteLine("To Add contacts or to list the contacts, press y/n");
                key = Console.ReadLine();

            }
            Console.ReadLine();
        }
    }
}
