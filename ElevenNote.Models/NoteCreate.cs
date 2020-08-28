using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteCreate
    {

        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters. Thanks.")]
        [MaxLength(100, ErrorMessage = "You have entered too many characters...")]
        public string Title { get; set; }

        [MaxLength(800)]
        public string Content { get; set; }
    }
}
