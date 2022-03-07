using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    public class Address_Book//variable declaration
    {
        string firstName, lastName, state, city, address, email;
        int zipCode;
        long mobileNumber;

        public Address_Book(string firstName, string lastName, string state, string city, string address, string email, int zipCode, long mobileNumber)//constructor to initialise variable
        {
            this.firstName = firstName; 
            this.lastName = lastName;
            this.state = state;
            this.city = city;
            this.address = address;
            this.email = email;
            this.zipCode = zipCode;
            this.mobileNumber = mobileNumber;
         }
        public string GetFirstName()
        {
            return firstName;
        }
        public void SetFirstName(string firstName)
        {
            this.firstName=firstName;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public void SetLastName(string lastName)
        {
            this.lastName=lastName;
        }
        public string GetState()
        {
            return state;
        }
        public void SetState(string state)
        {
            this.state = state;
        }
        public string GetCity()
        {
            return city;
        }
        public void SetCity(string city)
        {
            this.city = city;
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public int GetZipCode()
        {
            return zipCode;
        }
        public void SetZipCode(int zipcode)
        {
            this.zipCode = zipCode;
        }
        public long GetMobileNumber()
        {
            return mobileNumber;
        }
        public void SetMobileNumber(long mobilenumber)
        {
            this.mobileNumber = mobilenumber;
        }

        public override string ToString() 

        {
            return ("First Name: " + firstName + " Last Name: " + lastName + " City: " + city + " State: " + state + " Address" + address + " zip: " + zipCode + " Phone Number: " + mobileNumber);
        }

    }
}
