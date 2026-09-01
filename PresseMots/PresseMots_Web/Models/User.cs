using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresseMots.Models
{
    public class User
    {

        public User()
        {
            Stories = new List<Story>();
            Likes = new List<Like>();
            Shares = new List<Share>();
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual List<Story> Stories { get; set; }
        public virtual List<Like> Likes { get; set; }
        public virtual List<Share> Shares { get; set; }
    }
}
