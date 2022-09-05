using AddressBookSystem;

Console.WriteLine("Welcome to AddressBook Program.");
AddressBook addressBook = new AddressBook(); 
int option = 0;
while (option != 4) 
{
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Press 1 for add contact.\nPress 2 for list the contact.\nPress 3  to edit the contact.\nPress 4 to exit.");
    Console.WriteLine("Please enter option number: ");
    option = int.Parse(Console.ReadLine()); 
    switch (option)
    {
        case 1: 
            addressBook.addContact();
            break;
        case 2: 
            addressBook.listContact();
            break;
        case 3:
            addressBook.editContact();
            break;
        case 4:
            Console.WriteLine("Exiting from Program.");
            break;
        default: 
            Console.WriteLine("Wrong option.");
            break;
    }
}
