using Note_Taking_ConsoleApplication.Models;
using Note_Taking_ConsoleApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Taking_ConsoleApplication
{
    using System;

    public class NoteManager
    {
        private readonly NoteRepository _repository;
        private readonly Logger _logger;

        public NoteManager(string connectionString, Logger logger)
        {
            _repository = new NoteRepository(connectionString);
            _logger = logger;
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
                _logger.Log($"Note created: {note.Title}");
            }
            catch (Exception ex)
            {
                _logger.Log($"Error: {ex.Message}");
            }
        }

        public void ViewNotes()
        {
            try
            {
                var notes = _repository.GetAll();
                foreach (var note in notes)
                {
                    Console.WriteLine($"ID: {note.NoteId}, Title: {note.Title}, Created At: {note.CreatedAt}, Content: {note.Content.Substring(0, Math.Min(note.Content.Length, 30))}...");
                }
                _logger.Log("Viewed all notes");
            }
            catch (Exception ex)
            {
                _logger.Log($"Error: {ex.Message}");
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
                _logger.Log($"Note updated: {note.Title}");
            }
            catch (Exception ex)
            {
                _logger.Log($"Error: {ex.Message}");
            }
        }

        public void DeleteNote(int id)
        {
            try
            {
                _repository.Delete(id);
                _logger.Log($"Note deleted: ID {id}");
            }
            catch (Exception ex)
            {
                _logger.Log($"Error: {ex.Message}");
            }
        }
    }
}