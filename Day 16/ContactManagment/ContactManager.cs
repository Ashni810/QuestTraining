using ContactManagment;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

public class ContactManager
{
    private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashni\OneDrive\Documents\QuestDb.mdf;Integrated Security=True";

    

    public ContactManager(string connStr)
    {
        this.connStr = connStr;
    }

    
        // Add new contact
        public void AddContact(Contact contact)
    {
            var connection = new SqlConnection(connStr);
            var query = "INSERT INTO Contacts (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";
            var command = new SqlCommand(query, connection);
            connection.Open();
            command.Parameters.AddWithValue("@Name", contact.Name);
            command.Parameters.AddWithValue("@Phone", contact.Phone);
            command.Parameters.AddWithValue("@Email", contact.Email);
            command.ExecuteNonQuery();
            connection.Close();
            
        
    }

    // Delete contact
    public void DeleteContact(string name)
    {
            var connection = new SqlConnection(connStr);
            connection.Open();
            var query = "DELETE FROM Contacts WHERE Name = @Name";
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);
            command.ExecuteNonQuery();
            connection.Close();
        
    }

    // Update contact
    public void UpdateContact(string name, Contact updatedContact)
    {
            var connection = new SqlConnection(connStr);
            connection.Open();
            var query = "UPDATE Contacts SET Phone = @Phone, Email = @Email WHERE Name = @Name";
            var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Phone", updatedContact.Phone);
                command.Parameters.AddWithValue("@Email", updatedContact.Email);
                command.ExecuteNonQuery();
           connection.Close();
            
        
    }


    // Display all contacts
    public void DisplayContacts()
    {
            var connection = new SqlConnection(connStr);
            connection.Open();
            var query = "SELECT * FROM Contacts";
            var command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();
                
                    while (reader.Read())
                    {
                        var ContactID = reader.GetInt32(0);
                        var Name = reader.GetString(1);
                        var Phone = reader.GetString(2);
                        var Email = reader.GetString(3);
                        Console.WriteLine($"Name: {Name}, Phone: {Phone}, Email: {Email}");
                    }
            connection.Close( ); 
            
        
    }
}
