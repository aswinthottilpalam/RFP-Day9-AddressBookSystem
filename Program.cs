using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Welcome to the  Address Book System  **********");

            while (true)
            {
                //Console.WriteLine("*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*");
                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        UC_1CreateAddressBook.AddMember();
                        break;
                    case 2:
                        UC_1CreateAddressBook.ViewContacts();
                        break;

                    case 3:
                        // to exit from main method
                        Console.WriteLine("Exited");
                        return;

                }
            }

        }
    }
}
