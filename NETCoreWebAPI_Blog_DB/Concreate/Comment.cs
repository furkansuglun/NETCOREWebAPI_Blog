using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreWebAPI_Blog_DB.Concreate
{
    public class Comment: Entity
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }

        public string Name { get; set; }
         
    }
}
