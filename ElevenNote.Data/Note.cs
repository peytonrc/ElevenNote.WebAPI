using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key] // Uniquely identifies an entity; primary key
        public int NoteId { get; set; }

        [Required] // User cannot enter a null value
        public Guid OwnerId { get; set; } 
        // Guid: Type that allows us to create unique IDs for our users or items for our users;
        // Globally Unique Identified; 32 digits; very hard to replicate

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
