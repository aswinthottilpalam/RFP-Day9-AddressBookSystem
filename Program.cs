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
                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Edit Contact\n4.Delete Contact\n5.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        UC5AddMultipleContacts.AddMember();
                        break;
                    case 2:
                        UC5AddMultipleContacts.ViewContacts();
                        break;
                    case 3:
                        UC5AddMultipleContacts.EditDetails();
                        break;
                    case 4:
                        UC5AddMultipleContacts.DeleteDetails();
                        break;

                    case 5:
                        // to exit from main method
                        Console.WriteLine("Exited");
                        return;

                }
            }

        }
    }
}
