using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NETCoreWebAPI_Blog_DAL.Abstract;
using NETCoreWebAPI_Blog_DB.Concreate;

namespace NETCOREWebAPI_Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        //private IArticleRepository _repo;

        //public ArticleController(IArticleRepository repo)
        //{
        //    _repo = repo;
        //}

        //[HttpGet("All")]
        //public IQueryable GetAll()
        //{
        //    return _repo.GetAll();
        //}

        //[HttpGet("GetById/{id}")]
        //public Task<Article> GetById(int id)
        //{
        //    return _repo.GetById(id);
        //}

    }
}