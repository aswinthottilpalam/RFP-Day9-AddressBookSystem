using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class UC2AddNewContacts
    {

        private static List<Person> contacts = new List<Person>();
        public static void AddMember()
        {
            //object for person class
            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            person.lastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            person.address = Console.ReadLine();
            Console.Write("Enter City: ");
            person.city = Console.ReadLine();
            Console.Write("Enter State: ");
            person.state = Console.ReadLine();

            while (true)
            {
                Console.Write("Enter zip code: ");
                string zpCode = Console.ReadLine();
                if (zpCode.Length == 6)
                {
                    person.zipCode = zpCode;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Zipcode,It should Contain 6 digits");
                }
            }

            while (true)
            {
                Console.Write("Enter Phone Number: ");
                string phNo = Console.ReadLine();
                if (phNo.Length == 10)
                {
                    person.phoneNumber = phNo;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Phone Number,It should Contain 10 digits");
                }
            }

            while (true)
            {
                Console.Write("Enter Email-id: ");
                string emailId = Console.ReadLine();
                if (emailId.Contains("@"))
                {
                    person.email = emailId;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Email Id, It should Contains @ ");
                }
            }
            contacts.Add(person);

            Console.WriteLine("Added Successfully \n####################################################");
        }

        public static void ViewContacts()
        {
            if (contacts.Count > 0)
            {
                Console.WriteLine("***************Your Contact List Has******************");
                foreach (var x in contacts)
                {
                    PrintValues(x);

                }

            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }
        }

        public static void PrintValues(Person x)
        {
            Console.WriteLine($"First Name : {x.firstName}");
            Console.WriteLine($"Last Name : {x.lastName}");
            Console.WriteLine($"Address : {x.address}");
            Console.WriteLine($"City : {x.city}");
            Console.WriteLine($"State : {x.state}");
            Console.WriteLine($"Zip Code: {x.zipCode}");
            Console.WriteLine($"Phone Number: {x.phoneNumber}");
            Console.WriteLine($"Email: {x.email}");
            Console.WriteLine("****************************************************");

        }
    }
}
