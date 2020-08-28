using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    // Purpose: Will handle the task of collecting property data for a list of notes. When a user enter sinformation, we will want them to enter specific data. When we show info   we will want to show specific data in specific views.
    public class NoteListItem
    {
        public int NoteId { get; set; }
        public string Title { get; set; }

        [Display(Name ="Created")]
        public DateTimeOffset CreateUtc { get; set; }

    }
}
