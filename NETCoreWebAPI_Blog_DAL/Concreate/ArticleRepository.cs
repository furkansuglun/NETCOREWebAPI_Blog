using NETCoreWebAPI_Blog_Core.Concreate;
using NETCoreWebAPI_Blog_DAL.Abstract;
using NETCoreWebAPI_Blog_DB.Concreate;
using NETCoreWebAPI_Blog_DB.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCoreWebAPI_Blog_DAL.Concreate
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(BlogContext context) : base(context)
        {
        }
    }
}
