using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Note_Taking_ConsoleApplication.Models;
namespace Note_Taking_ConsoleApplication.Repositories
{
    public class NoteRepository
    {
        private readonly string _connectionString;

        public NoteRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Note note)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    var command = new SqlCommand("INSERT INTO Notes (Title, Content, CreatedAt) VALUES (@Title, @Content, @CreatedAt)", connection);
                    command.Parameters.AddWithValue("@Title", note.Title);
                    command.Parameters.AddWithValue("@Content", note.Content);
                    command.Parameters.AddWithValue("@CreatedAt", note.CreatedAt);

                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Note added successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public List<Note> GetAll()
        {
            var notes = new List<Note>();
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    var command = new SqlCommand("SELECT * FROM Notes", connection);
                    connection.Open();
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        while (reader.Read())
                        {
                            var note = new Note
                            {
                                NoteId = Convert.ToInt32(reader["NoteId"]),
                                Title = Convert.ToString(reader["Title"]),
                                Content = Convert.ToString(reader["Content"]),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                                UpdatedAt = Convert.ToDateTime(reader["UpdateddAt"]),
                            };

                            notes.Add(note);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return notes;
        }

        public void Update(Note note)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    var command = new SqlCommand("UPDATE Notes SET Title = @Title, Content = @Content, UpdatedAt = @UpdatedAt WHERE NoteId = @NoteId", connection);
                    command.Parameters.AddWithValue("@Title", note.Title);
                    command.Parameters.AddWithValue("@Content", note.Content);
                    command.Parameters.AddWithValue("@UpdatedAt", note.UpdatedAt);
                    command.Parameters.AddWithValue("@NoteId", note.NoteId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Note updated successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void Delete(int noteId)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    var command = new SqlCommand("DELETE FROM Notes WHERE NoteId = @NoteId", connection);
                    command.Parameters.AddWithValue("@NoteId", noteId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Note deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
