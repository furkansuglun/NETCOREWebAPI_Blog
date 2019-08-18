using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreWebAPI_Blog_DB.Concreate
{
    public class Article: Entity
    {

        public string Title { get; set; }        
        public string Content { get; set; }
        public string PhotoPath { get; set; }
        public DateTime Date { get; set; }
        public string ReadCount { get; set; }
        public int LabelId { get; set; }
        public ICollection<Label> Labels { get; set; }
        public int MemberId { get; set; }
        public ICollection<Member> Members { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Category> Categories { get; set; }
        public int CommentId { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
