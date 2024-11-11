using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MusicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicApp musicApp = new MusicApp();

            while (true)
            {
                Console.WriteLine("\nMusic App :");
                Console.WriteLine("1. Play Current Track");
                Console.WriteLine("2. Next Track");
                Console.WriteLine("3. Previous Track");
                Console.WriteLine("4. Filter Tracks");
                Console.WriteLine("5. Add Music File");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        musicApp.Play();
                        break;
                    case "2":
                        musicApp.Next();
                        break;
                    case "3":
                        musicApp.Previous();
                        break;
                    case "4":
                        Console.Write("Enter filter text: ");
                        var filter = Console.ReadLine();
                        musicApp.Filter(filter);
                        break;
                    case "5":
                        Console.Write("Enter the full path of the music file to add: ");
                        var filePath = Console.ReadLine();
                        musicApp.AddMusic(filePath);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }

    class MusicApp
    {
        private readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
        private readonly List<string> _musicFiles = new List<string>();
        private List<string> _filteredFiles = new List<string>();
        private const string allowedFileType = "*.mp3";
        private int _currentIndex = 0;

        public MusicApp()
        {
            LoadMusicList();
        }

        private void LoadMusicList()
        {
            try
            {
                var files = Directory.GetFiles(_path, allowedFileType, SearchOption.AllDirectories);
                _musicFiles.AddRange(files);
                _filteredFiles.AddRange(_musicFiles);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Play()
        {
            if (_filteredFiles.Count == 0)
            {
                Console.WriteLine("No music files available.");
                return;
            }
            var fileName = Path.GetFileNameWithoutExtension(_filteredFiles[_currentIndex]);
            Console.WriteLine($"Now playing: {fileName}");
        }

        public void Next()
        {
            if (_filteredFiles.Count == 0) return;

            _currentIndex = _currentIndex < _filteredFiles.Count - 1 ? _currentIndex + 1 : 0;
            Play();
        }

        public void Previous()
        {
            if (_filteredFiles.Count == 0) return;

            _currentIndex = _currentIndex > 0 ? _currentIndex - 1 : _filteredFiles.Count - 1;
            Play();
        }

        public void Filter(string filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            if (filter == "")
            {
                _filteredFiles.Clear();
                _filteredFiles.AddRange(_musicFiles);
                _currentIndex = 0; // Reset index
                return;
            }

            filter = filter.ToLowerInvariant();
            _filteredFiles = _musicFiles.Where(p =>
            {
                var fileName = Path.GetFileNameWithoutExtension(p).ToLowerInvariant();
                return fileName.Contains(filter);
            }).ToList();

            if (_filteredFiles.Count == 0)
            {
                _currentIndex = 0; // No valid index
                Console.WriteLine("No files match the filter.");
            }
            else
            {
                _currentIndex = 0; // Reset to the first item in the filtered list
            }
        }

        public void AddMusic(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                Console.WriteLine("Invalid file path. Please try again.");
                return;
            }
            if (Path.GetExtension(filePath).Equals(".mp3"))
            {
                // Check if the file already exists in the music files list
                if (!_musicFiles.Contains(filePath))
                {
                    _musicFiles.Add(filePath);
                    _filteredFiles.Add(filePath); // Also add to the filtered list
                    Console.WriteLine($"Added music file: {Path.GetFileName(filePath)}");
                }
                else
                {
                    Console.WriteLine("This music file is already in the list.");
                }
            }
            else
            {
                Console.WriteLine("Only MP3 files can be added.");
            }
        }
    }
}