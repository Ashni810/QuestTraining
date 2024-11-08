﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Taking_ConsoleApplication.Models
{
    public class Note
    {
        private readonly string tilte;

        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Note(int noteId,string title)
        {
            NoteId = noteId;
            Title = title;

           
        }
        
    }
}
