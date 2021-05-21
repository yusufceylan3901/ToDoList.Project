using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Note
{
    public class pNote
    {
        public int NoteId { get; set; }
        public int UserId { get; set; }
        public string Note { get; set; }
        public string Title { get; set; }
    }
}
