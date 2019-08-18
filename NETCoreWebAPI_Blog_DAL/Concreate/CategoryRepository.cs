using NETCoreWebAPI_Blog_Core.Concreate;
using NETCoreWebAPI_Blog_DAL.Abstract;
using NETCoreWebAPI_Blog_DB.Concreate;
using NETCoreWebAPI_Blog_DB.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreWebAPI_Blog_DAL.Concreate
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BlogContext context) : base(context)
        {
        }

    }
}
