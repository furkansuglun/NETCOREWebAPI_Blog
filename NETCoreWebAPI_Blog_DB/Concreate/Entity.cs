using NETCoreWebAPI_Blog_DB.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreWebAPI_Blog_DB.Concreate
{
    public class Entity : IEntity
    {

        public int Id { get; set; }
    }
}
