using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreWebAPI_Blog_DB.Concreate
{
    public class Label: Entity
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public string Name { get; set; }
    }
}
