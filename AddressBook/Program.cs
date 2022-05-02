﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book system!");

            AddressBookManagement addressBook = new AddressBookManagement();


            //Operations on Address Book System
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1.)Add New Contact\n2.)View Contact\n3.)Edit Contact by finding name\n4.)Delete Contact\n5.)Add Address Book\n6.)SearchUser\n7.)View Person\n8.)View Person By state or country\n9.)View Person by name");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("Enter the number of contact list to be added : ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    for (int index = 0; index < number; index++)
                    {
                        addressBook.AddNewContact();
                    }
                    addressBook.ViewContact();
                    break;
                case 2:
                    
                    addressBook.ViewContact();
                    break;
                case 3:
                    Console.WriteLine("Enter the first name : ");
                    string firstName = Console.ReadLine();
                    addressBook.EditContact(firstName);
                    break;
                case 4:
                    Console.WriteLine("Enter the First Name & Last Name : ");
                    string fName = Console.ReadLine();
                    string lName = Console.ReadLine();
                    addressBook.DeletePersonContact(fName, lName);
                    break;
                case 5:
                    addressBook.AddNewAddressBook();
                    addressBook.ViewContact();
                    break;
                case 6:
                    addressBook.AddContactDetail("Arun", "Kumar", "Ranchi", "Ranchi", "Jharkhand", 789456, 7894561230, "xyz@gmail.com");
                    addressBook.AddContactDetail("Ashish", "Jain", "Dhaulpur", "Dhaulpur", "Rajasthan", 789356, 7894561231, "ashish@gmail.com");
                    addressBook.SearchPerson();
                    break;
                case 7:
                    addressBook.AddContactDetail("Arun", "Kumar", "Ranchi", "Ranchi", "Jharkhand", 789456, 7894561230, "xyz@gmail.com");
                    addressBook.ViewPerson();
                    addressBook.ViewContact();
                    break;
                case 8:
                    addressBook.AddNewAddressBook();
                    addressBook.CountByCityOrState();
                    break;
                case 9:
                    addressBook.SortPersonName();
                    addressBook.ViewPerson();
                    addressBook.SortPersonName();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
            Console.ReadLine();
        }

    }
}

