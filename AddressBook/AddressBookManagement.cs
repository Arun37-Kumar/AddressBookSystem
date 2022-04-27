using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBookManagement
    {
        //Defining the list
        List<Contacts> contactList;

        //Defining constructor
        public AddressBookManagement()
        {
            contactList = new List<Contacts>();
        }

        public void AddContactDetail(string firstName, string lastName, string address, string city, string state, int zipcode, long phoneNumber, string email)
        {
            Contacts personDetail = new Contacts(firstName, lastName, address, city, state, zipcode, phoneNumber, email);
            contactList.Add(personDetail);
        }

        //Adding New Contact
        public void AddNewContact()
        {
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the State: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter the Zipcode: ");
            int zipcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Phone Number: ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email-ID: ");
            string email = Console.ReadLine();

            AddContactDetail(firstName, lastName, address, city, state, zipcode, phoneNumber, email);
            ViewContact();
        }

        //Viewing Contacts
        public void ViewContact()
        {
            foreach (var contact in contactList)
            {
              //  Console.Write("First Name: " + contact.firstName + "\nLast Name: " + contact.lastName + "\nAddress: " + contact.address + "\nCity: " + contact.city + "\nState: " + contact.state + "\nZipCode: " + contact.zipcode + "\nPhone Number: " + contact.phoneNumber + "\nEmail ID: " + contact.email);

                Console.WriteLine("First Name: " + contact.firstName);
                Console.WriteLine("Last Name: " + contact.lastName);
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("City: " + contact.city);
                Console.WriteLine("State: " + contact.state);
                Console.WriteLine("ZipCode: " + contact.zipcode);
                Console.WriteLine("Phone Number: " + contact.phoneNumber);
                Console.WriteLine("Email ID: " + contact.email);
            }
        }

    }
}
