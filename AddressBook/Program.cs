using System;
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

            Contacts contact = new Contacts();
            contact.firstName = "Arun";
            Console.WriteLine("First name : "+contact.firstName);
            Console.ReadLine();
        }
    }
}
