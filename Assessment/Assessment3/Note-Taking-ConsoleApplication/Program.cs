using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Note_Taking_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ashni\OneDrive\Documents\NoteTakingApp.mdf; Integrated Security = True";
            string logFilePath = "application_log.txt";
            var logger = new Logger(logFilePath);
            var noteManager = new NoteManager(connectionString, logger);

            while (true)
            {
                Console.WriteLine("1. Create a new note");
                Console.WriteLine("2. View all notes");
                Console.WriteLine("3. Update an existing note");
                Console.WriteLine("4. Delete a note");
                Console.WriteLine("5. Exit");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreateNote();
                        break;
                    case "2":
                        noteManager.ViewNotes();
                        break;
                    case "3":
                        UpdateNote();
                        break;
                    case "4":
                        DeleteNote();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }

            void CreateNote()
            {
                Console.Write("Enter title: ");
                var title = Console.ReadLine();
                Console.Write("Enter content: ");
                var content = Console.ReadLine();

                noteManager.CreateNote(title, content);
            }

            void UpdateNote()
            {
                Console.Write("Enter the ID of the note to update: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter new title: ");
                var title = Console.ReadLine();
                Console.Write("Enter new content: ");
                var content = Console.ReadLine();

                noteManager.UpdateNote(id, title, content);
            }

            void DeleteNote()
            {
                Console.Write("Enter the ID of the note to delete: ");
                int id = int.Parse(Console.ReadLine());

                noteManager.DeleteNote(id);
            }
        }
    }
}

