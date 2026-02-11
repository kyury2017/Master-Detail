using Data;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Numerics;

namespace WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        Data.IContext _context;
        public MasterController(IContext context)
        {
            _context = context;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<MasterView>))]
        public async Task<IEnumerable<MasterView>> GetMasters()
        {
            return await _context.MastersLoadAsync();
        }
        [HttpGet("{id}", Name = nameof(GetMaster))]
        [ProducesResponseType(200, Type = typeof(MasterView))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetMaster(int? id)
        {
            MasterView? m = await _context.MastersLoadAsync(id);
            if (m == null)
            {
                return NotFound();//404
            }
            return Ok(m);
        }

        [HttpPost()]
        [ProducesResponseType(201, Type = typeof(MasterView))]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Create([FromBody] MasterView m)
        {
            try
            {
                if (m is null)
                    return BadRequest();//400
                MasterView? createdMaster = await _context.CreateAsync(m);
                if (createdMaster is null)
                {
                    return BadRequest("Не удалось создать документ.");
                }
                else
                {
                    return CreatedAtRoute(//201
                        routeName: nameof(GetMaster),
                        routeValues: new { id = createdMaster.Id },
                        value: createdMaster);
                }
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Update(int id, [FromBody] MasterView m)
        {
            try
            {

                if (m == null || m.Id != id)
                {
                    return BadRequest(); // 400 Bad request
                }

                MasterView? existing = await _context.MastersLoadAsync(id);
                if (existing == null)
                {
                    return NotFound(); // 404 Resource not found
                }

                await _context.UpdateAsync(m);

                return new NoContentResult(); // 204 No content
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                MasterView? existing = await _context.MastersLoadAsync(id);
                if (existing == null)
                {
                    return NotFound();//404
                }

                bool? deleted = await _context.MasterDeleteAsync(id);

                if (deleted.HasValue && deleted.Value)
                {
                    return new NoContentResult(); //204
                }
                else
                {
                    return BadRequest(//400
                      $"Спецификация {id} была найдена, но ее не удалось удалить.");
                }
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
