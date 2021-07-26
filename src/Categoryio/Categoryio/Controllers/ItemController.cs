using Categoryio.Api.Database;
using Categoryio.Api.Database.Models;
using Categoryio.Api.Requests;
using Categoryio.Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Categoryio.Api.Controllers
{
    [ApiController]
    [Route("api/item")]
    [Produces("application/json")]
    public class ItemController : ControllerBase
    {
        private readonly ILogger<ItemController> _logger;
        private readonly CategoryioDbContext _dbContext;

        public ItemController(ILogger<ItemController> logger, CategoryioDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("")]
        [ProducesResponseType(statusCode: 200, type: typeof(ItemRequest))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        public async Task<IActionResult> CreateItem([FromBody] ItemRequest itemRequest)
        {
            var created = _dbContext.Items.Add(new Database.Models.Item()
            {
                Id = 0,
                Created = DateTime.Now,
                Description = itemRequest.Description,
                Image = itemRequest.Image,
                Name = itemRequest.Name
            });

            await _dbContext.SaveChangesAsync();
            return Ok(created.Entity);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(statusCode: 200, type: typeof(ItemRequest))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        public async Task<IActionResult> UpdateItem([FromRoute] int id, [FromBody] ItemRequest itemRequest)
        {
            var item = await _dbContext.FindAsync<Item>(id);
            item.Name = itemRequest.Name;
            item.Image = item.Image;
            item.Description = item.Description;

            await _dbContext.SaveChangesAsync();
            return Ok(item);
        }

        [HttpGet]
        [Route("")]
        [ProducesResponseType(statusCode: 200, type: typeof(IEnumerable<ItemRequest>))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        public async Task<IActionResult> GetCategories()
        {
            return Ok(_dbContext.Items);
        }

        [HttpPost]
        [Route("{id}/category/{categoryId}")]
        [ProducesResponseType(statusCode: 200)]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        public async Task<IActionResult> AssignCategoryItem([FromRoute] int id, [FromRoute] int categoryId)
        {
            await Task.CompletedTask;
            return Ok();
        }
    }
}
