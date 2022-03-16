using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************Welcome to the Address Book System*************");
            UC6RefractCode abd = new UC6RefractCode();


            while (true)
            {
                Console.WriteLine("*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*");
                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Edit Contact\n4.Delete Contact\n5.Exit");
                Console.WriteLine("Enter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        abd.AddMember();
                        // UC1_AddressBookMain.AddMember();
                        //UC2_AddContact.AddMember();
                        //UC3_EditContact.AddMember();
                        //UC4_DeleteContact.AddMember();
                        //UC5_AddMultipleContacts.AddMember();
                        break;
                    case 2:
                        abd.ViewContacts();
                        // UC1_AddressBookMain.ViewContacts();
                        //UC2_AddContact.ViewContacts();
                        //UC3_EditContact.ViewContacts();
                        //UC4_DeleteContact.ViewContacts();
                        //UC5_AddMultipleContacts.ViewContacts();
                        break;
                    case 3:
                        abd.EditDetails();
                        // UC3_EditContact.EditDetails();
                        //UC4_DeleteContact.EditDetails();
                        //UC5_AddMultipleContacts.EditDetails();
                        break;
                    case 4:
                        abd.DeleteDetails();
                        //  UC4_DeleteContact.DeleteDetails();
                        //UC5_AddMultipleContacts.DeleteDetails();
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
