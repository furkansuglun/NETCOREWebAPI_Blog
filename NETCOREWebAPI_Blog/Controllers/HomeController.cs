using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NETCoreWebAPI_Blog_DAL.Abstract;
using NETCoreWebAPI_Blog_DB.Concreate;
using NETCoreWebAPI_Blog_DB.Context;

namespace NETCOREWebAPI_Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private ICategoryRepository _repo;

        public HomeController(ICategoryRepository repo)
        {
            _repo = repo;
        }
       
        [HttpGet("All")]
        public IQueryable GetAll()
        {
            return _repo.GetAll();
        }

        [HttpGet("GetById/{id}")]
        public  Task<Category> GetById(int id)
        {
            return _repo.GetById(id);
        }

       
    }
     
}