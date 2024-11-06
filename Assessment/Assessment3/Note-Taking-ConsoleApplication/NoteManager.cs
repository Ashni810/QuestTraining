using Note_Taking_ConsoleApplication.Models;
using Note_Taking_ConsoleApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Taking_ConsoleApplication
{
    public class NoteManager
    {
        private readonly NoteRepository _repository;
       

        public NoteManager(string connectionString)
        {
            _repository = new NoteRepository(connectionString);
           
        }

        public void CreateNote(string title, string content)
        {
            try
            {
                var note = new Note
                {
                    Title = title,
                    Content = content,
                    CreatedAt = DateTime.Now
                };

                _repository.Add(note);
                Console.WriteLine($"Note created: {note.Title}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void ViewNotes()
        {
            try
            {
                var notes = _repository.GetAll();
                foreach (var note in notes)
                {
                    Console.WriteLine($"ID: {note.NoteId}, Title: {note.Title}, Created At: {note.CreatedAt}, Content: {note.Content}...");
                }
              
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void UpdateNote(int id, string title, string content)
        {
            try
            {
                var note = new Note
                {
                    NoteId = id,
                    Title = title,
                    Content = content,
                    UpdatedAt = DateTime.Now
                };

                _repository.Update(note);
                Console.WriteLine($"Note updated: {note.Title}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void DeleteNote(int id)
        {
            try
            {
                _repository.Delete(id);
                Console.WriteLine($"Note deleted: ID {id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}