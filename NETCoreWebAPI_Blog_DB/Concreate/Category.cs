using NETCoreWebAPI_Blog_DB.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NETCoreWebAPI_Blog_DB.Concreate
{
    public class Category: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
