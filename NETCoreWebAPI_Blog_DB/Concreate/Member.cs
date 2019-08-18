using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreWebAPI_Blog_DB.Concreate
{
    public class Member: Entity
    {
        public Article Article { get; set; } 
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string PhotoPath { get; set; }
        public bool IsAdmin { get; set; }
        public int CommentId { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
