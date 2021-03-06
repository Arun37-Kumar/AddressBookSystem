using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace AddressBook
{
    class AddressBookFileIO
    {
        Dictionary<string, List<Contacts>> contactList;
        public string path = @"E:\Assignments RFP\Day 23\AddressBook\AddressBook\FileIO\Sample.txt";
        public string csvpath = @"E:\Assignments RFP\Day 23\AddressBook\AddressBook\FileIO\AddressBook.csv";

        public AddressBookFileIO()
        {
            this.path = path;
            this.contactList = contactList;
        }

        public void WriteAddressBookWithStreamWriter(Dictionary<string, List<Contacts>> AddressBokkDictionary)
        {
            int count = 1;
            foreach (KeyValuePair<string, List<Contacts>> person in AddressBokkDictionary)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                       sw.WriteLine("Name of AddressBook : "+person.Key);
                    foreach (Contacts contact in person.Value)
                    {

                        sw.Write(" FirstName: " + contact.firstName);
                        sw.Write(" LastName: " + contact.lastName);
                        sw.Write(" City: " + contact.city);
                        sw.Write(" State: " + contact.state);
                        sw.Write(" Address: " + contact.address);
                        sw.Write(" zipCode: " + contact.zipcode);
                        sw.Write(" PhoneNo: " + contact.phoneNumber);
                        sw.Write(" Email: " + contact.email);
                        count++;
                    }
                }
            }
            Console.WriteLine("File Written!");
        }

        public void AddressBookReadStream()
        {
            string lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.WriteLine("Files read successfully!");
        }

        public void ReadCsvFile()
        {
            using (StreamReader streamreader = new StreamReader(csvpath))
            using (CsvReader csvReader = new CsvReader(streamreader, CultureInfo.InvariantCulture))
            {
                List<Contacts> records = csvReader.GetRecords<Contacts>().ToList();
                foreach (var contact in records)
                {
                    Console.WriteLine(contact);
                }
            }
            Console.WriteLine("File Read Successfully");
        }
    }
}
