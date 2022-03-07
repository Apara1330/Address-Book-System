using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    public class AddressBookDetails
    {
        public char x;
        public char y;
        ArrayList allContacts = new ArrayList();

        public void AddDetails()//taking input from address details
        {
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
           
            Console.WriteLine("Enter State Name: ");
            string state = Console.ReadLine();
            
            Console.WriteLine("Enter City Name: ");
            string city = Console.ReadLine();
            
            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();
            
            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();
            
            Console.WriteLine("Enter Zip Code: ");
            int zipCode =int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Mobile Number: ");
            long mobileNumber = Convert.ToInt64(Console.ReadLine());

            Address_Book contacts = new Address_Book(firstName, lastName, state, city, address, email, zipCode, mobileNumber);
            allContacts.Add(contacts);
        }

        public void view()
        {
            foreach (Address_Book contactList in allContacts)
            {
                Console.WriteLine(contactList);
            }
        }
    }
}
