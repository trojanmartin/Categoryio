using Categoryio.Api.Database;
using Categoryio.Api.Database.Models;
using Categoryio.Api.Models;
using Categoryio.Api.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Categoryio.Api.Controllers
{

    [ApiController]
    [Route("api/room")]
    [Produces("application/json")]
    public class RoomController : ControllerBase
    {
        private readonly CategoryioDbContext _dbContext;
        private readonly ILogger<RoomController> _logger;

        public RoomController(ILogger<RoomController> logger, CategoryioDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("")]
        [ProducesResponseType(statusCode: 200, type: typeof(RoomRequest))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        public async Task<IActionResult> CreateRoom([FromBody] RoomRequest roomRequest)
        {
            var created = _dbContext.Rooms.Add(new Database.Models.Room()
            {
                Id = 0,
                Created = DateTime.Now,
                Description = roomRequest.Description,
                DoorNumber = roomRequest.DoorNumber,
                Floor = roomRequest.Floor,
                Name = roomRequest.Name
            });

            await _dbContext.SaveChangesAsync();
            return Ok(created.Entity);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(statusCode: 200, type: typeof(RoomRequest))]
        [ProducesResponseType(statusCode: 400, type: typeof(ErrorResponse))]
        public async Task<IActionResult> UpdateRoom([FromRoute] int id, [FromBody] RoomRequest roomRequest)
        {
            var item = await _dbContext.FindAsync<Room>(id);
            item.Description = roomRequest.Description;
            item.DoorNumber = roomRequest.DoorNumber;
            item.Floor = roomRequest.Floor;
            item.Name = roomRequest.Name;

            _dbContext.Rooms.Update(item);

            await _dbContext.SaveChangesAsync();
            return Ok(item);
        }       
    }
}
