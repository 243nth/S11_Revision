
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PresseMots.Models
{
    public class Tags
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual StoryTag StoryTag{ get; set; }



    }
}
