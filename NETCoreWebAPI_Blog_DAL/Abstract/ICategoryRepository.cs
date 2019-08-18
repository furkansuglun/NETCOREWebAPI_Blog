using NETCoreWebAPI_Blog_Core.Abstract;
using NETCoreWebAPI_Blog_DB.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreWebAPI_Blog_DAL.Abstract
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {

    }
}
