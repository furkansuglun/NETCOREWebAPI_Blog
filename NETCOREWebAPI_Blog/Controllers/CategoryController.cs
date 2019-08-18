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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _repository;

        public CategoryController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public IQueryable GetAll()
        {
            return _repository.GetAll();
        }

        [HttpPost("GetById/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public Task<Category> GetById(int id)
        {
            return  _repository.GetById(id);
        }
    }
}