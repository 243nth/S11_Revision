using PresseMots.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresseMots.Models
{
    public class Comment : IWordCountable
    {
        public int Id { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "EmailRequired")]

        public String Email { get; set; }

        [MaxLength(100, ErrorMessage = "Max100Please")]
        [Required(ErrorMessage = "DisplayNameRequired")]
        public String DisplayName { get; set; }

        [MaxLength(2500, ErrorMessage="Max2500Please")]
        [Required(ErrorMessage = "ContentRequired")]
        public String Content { get; set; }


        public bool Hidden { get; set; }


        public int StoryId { get; set; }
        public virtual Story Story { get; set; }


    }
}
