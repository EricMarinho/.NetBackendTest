using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WFConFin.Data;
using WFConFin.Models;

namespace WFConFin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatesController : Controller
    {
        private readonly WFConFinDbContext _context;

        public StatesController(WFConFinDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetStates()
        {
            try
            {
                var result = await _context.States.ToListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStates(Guid id)
        {
            try
            {
                var result = await _context.States.FindAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostState([FromBody] State state)
        {
            try
            {
                _context.States.Add(state);
                await _context.SaveChangesAsync();
                return Ok(state);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> PutState([FromBody] State state)
        {
            try
            {
                _context.States.Update(state);
                await _context.SaveChangesAsync();
                return Ok(state);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteState(Guid id)
        {
            try
            {
                var state = await _context.States.FindAsync(id);
                if (state == null)
                {
                    return NotFound();
                }
                _context.States.Remove(state);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
