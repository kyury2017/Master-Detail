using Data;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebApp.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class DetailController : ControllerBase
    {
        Data.IContext _context;
        public DetailController(IContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<DetailView>))]
        public async Task<IEnumerable<DetailView>> GetDetails()
        {
            return await _context.DetailsLoadAsync();
        }

        [HttpGet("{id}", Name = nameof(GetDetail))]
        [ProducesResponseType(200, Type = typeof(DetailView))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetDetail(int id)
        {
            DetailView? c = await _context.DetailsLoadAsync(id);
            if (c == null)
            {
                return NotFound();//404
            }
            return Ok(c);//200
        }

        [HttpPost]
        [ProducesResponseType(201, Type = typeof(DetailView))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Create([FromBody] DetailView c)
        {
            try
            {
                if (c == null)
                {
                    return BadRequest();//400
                }
                DetailView? cretedDetail = await _context.CreateAsync(c);
                if (cretedDetail == null)
                {
                    return BadRequest("Не удалось создать спецификацию.");
                }
                else
                {
                    //201
                    return CreatedAtRoute(
                      routeName: nameof(GetDetail),
                      routeValues: new { id = cretedDetail.Id },
                      value: cretedDetail);
                }
            }
            catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Update(int id, [FromBody] DetailView d)
        {
            try
            {
                if (d == null || d.Id != id)
                {
                    return BadRequest();//400
                }
                DetailView? existing = await _context.DetailsLoadAsync(id);
                if (existing == null)
                {
                    return NotFound();//404
                }

                await _context.UpdateAsync(d);

                return new NoContentResult();//204
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
                DetailView? existing = await _context.DetailsLoadAsync(id);
                if (existing == null)
                {
                    return NotFound();//404
                }

                bool? deleted = await _context.DetailDeleteAsync(id);

                if (deleted.HasValue && deleted.Value)
                {
                    return new NoContentResult();//204
                }
                else
                {
                    return BadRequest(//400 Bad request
                      $"Customer {id} was found but failed to delete.");
                }
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    
    }
}
