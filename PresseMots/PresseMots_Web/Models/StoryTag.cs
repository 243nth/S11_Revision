using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PresseMots.Models
{
    public class StoryTag
    {
        [Key]
        public int id { get; set; }

        public int StoryId { get; set; }
        public virtual Story Story { get; set; }

   
        public int TagId { get; set; }

        public virtual Tags Tag { get;set; }

    }
}
