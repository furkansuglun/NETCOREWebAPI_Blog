using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NETCoreWebAPI_Blog_DB.Concreate;
using NETCoreWebAPI_Blog_DB.Context;

namespace NETCOREWebAPI_Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly BlogContext _context;
        public HomeController(BlogContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> Index()
        {
            return _context.Category.ToList();

        }
    }
     
}