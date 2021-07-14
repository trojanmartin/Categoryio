using Categoryio.Api.Database;
using Categoryio.Api.Database.Models;
using Categoryio.Api.Models;
using Categoryio.Api.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Categoryio.Api.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly CategoryioDbContext _dbContext;

        public CategoryController(ILogger<CategoryController> logger, CategoryioDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("")]
        [ProducesResponseType(statusCode: 200, type: typeof(CategoryRequest))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryRequest categoryRequest)
        {
            var created = await _dbContext.Categories.AddAsync(new Database.Models.Category()
            {
                Id = 0,
                Created = DateTime.Now,
                Name = categoryRequest.Name
            });

            await _dbContext.SaveChangesAsync();
            return Ok(created.Entity);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(statusCode: 200, type: typeof(CategoryRequest))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        public async Task<IActionResult> UpdateCategory([FromRoute] int id, [FromBody] CategoryRequest categoryRequest)
        {
            var category = await _dbContext.FindAsync<Category>(id);

            category.Name = categoryRequest.Name;

            _dbContext.Update<Category>(category);
            await _dbContext.SaveChangesAsync();
            return Ok(category);
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(statusCode: 200, type: typeof(IEnumerable<CategoryRequest>))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        public async Task<IActionResult> GetCategory([FromRoute] int id)
        {
            await Task.CompletedTask;
            return Ok();
        }

        [HttpGet]
        [Route("")]
        [ProducesResponseType(statusCode: 200, type: typeof(IEnumerable<CategoryRequest>))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        public async Task<IActionResult> GetCategories()
        {            
            return Ok(_dbContext.Categories);
        }
    }
}
