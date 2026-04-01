using Gurukul.Core.DTOs.Groups;
using Gurukul.Core.Entities;
using Gurukul.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Gurukul.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupRepository _groupRepository;

        public GroupsController(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var groups = await _groupRepository.GetAllAsync();

            var response = groups.Select(MapToResponse);

            return Ok(response);
        }


        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var group = await _groupRepository.GetByIdAsync(id);

            if (group is null)
                return NotFound(new { message = $"Group {id} not found." });

            return Ok(MapToResponse(group));
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateGroupRequest request)
        {
            var creatorId = GetCurrentUserId();
            if (creatorId is null)
                return Unauthorized();

            var group = new Group
            {
                Id        = Guid.NewGuid(),
                Name      = request.Name,
                Description = request.Description,
                Privacy   = request.Privacy,
                CreatorId = creatorId.Value,
                CreatedAt = DateTime.UtcNow
            };

            var created = await _groupRepository.CreateAsync(group);

            return CreatedAtAction(nameof(GetById), new { id = created.Id }, MapToResponse(created));
        }


        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateGroupRequest request)
        {
            var group = await _groupRepository.GetByIdAsync(id);

            if (group is null)
                return NotFound(new { message = $"Group {id} not found." });

            var creatorId = GetCurrentUserId();
            if (group.CreatorId != creatorId)
                return Forbid();

            group.Name        = request.Name;
            group.Description = request.Description;
            group.Privacy     = request.Privacy;

            var updated = await _groupRepository.UpdateAsync(group);

            return Ok(MapToResponse(updated));
        }


        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var group = await _groupRepository.GetByIdAsync(id);

            if (group is null)
                return NotFound(new { message = $"Group {id} not found." });

            var creatorId = GetCurrentUserId();
            if (group.CreatorId != creatorId)
                return Forbid();

            await _groupRepository.DeleteAsync(id);

            return NoContent();
        }

        private Guid? GetCurrentUserId()
        {
            var value = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return Guid.TryParse(value, out var id) ? id : null;
        }

        private static GroupResponse MapToResponse(Group group) => new()
        {
            Id          = group.Id,
            Name        = group.Name,
            Description = group.Description,
            Privacy     = group.Privacy,
            CreatorId   = group.CreatorId,
            CreatedAt   = group.CreatedAt
        };
    }
}
