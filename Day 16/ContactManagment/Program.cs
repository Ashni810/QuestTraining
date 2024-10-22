using ContactManagment;
using System;

class Program
{
    static void Main(string[] args)
    {
        var connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashni\OneDrive\Documents\QuestDb.mdf;Integrated Security=True";
        var contactManager = new ContactManager(connStr);

        // Add contacts
        contactManager.AddContact(new Contact { Name = "Alice", Phone = "830-186-6133", Email = "alice@example.com" });
        contactManager.AddContact(new Contact { Name = "Bob", Phone = "987-654-3210", Email = "bob@example.com" });

        // Display all contacts
        Console.WriteLine("All Contacts:");
        contactManager.DisplayContacts();

        // Update contact
        contactManager.UpdateContact("Alice", new Contact { Phone = "949-704-6614", Email = "alice@newdomain.com" });

        // Delete contact
        contactManager.DeleteContact("Bob");

        // Display all contacts again
        Console.WriteLine("\nAll Contacts after update and delete:");
        contactManager.DisplayContacts();
    }
}
