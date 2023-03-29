using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CLIAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CLIController : ControllerBase
    {

        private readonly DataContext _context;

        public CLIController(DataContext context) {
            _context = context;
        }  


        [HttpGet]
        public async Task<ActionResult<List<Commander>>> Get()
        {
            return Ok(await _context.Commands.ToListAsync()); //creates a object that produce StatusCodes 200 Response
        }

        //returns only one command by database id
        [HttpGet("{id}")]
        public async Task<ActionResult<Commander>> Get(int id)
        {
            var hero = await _context.Commands.FindAsync(id);
            if (hero == null)
                return BadRequest("Hero not found."); //produces a error, StatusCodes 400 Response
            return Ok(hero); 
        }

        [HttpPost]
        public async Task<ActionResult<List<Commander>>> AddCLI(Commander hero)
        {
            _context.Commands.Add(hero);
            await _context.SaveChangesAsync();

            return Ok(await _context.Commands.ToListAsync()); 
        }

        [HttpPut]
        public async Task<ActionResult<List<Commander>>> UpdateCLI(Commander request)
        {
            var dbCommand = await _context.Commands.FindAsync(request.Id);
            if (dbCommand == null)
                return BadRequest("Hero not found."); //produces a error, StatusCodes 400 Response

            dbCommand.Line = request.Line;
            dbCommand.Des = request.Des;
            dbCommand.Platform = request.Platform;

            await _context.SaveChangesAsync();

            return Ok(await _context.Commands.ToListAsync());
        }

        //deletes command by database id
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Commander>>> Delete(int id)
        {
            var hero = await _context.Commands.FindAsync(id);
            if (hero == null)
                return BadRequest("Hero not found."); //produces a error, StatusCodes 400 Response

            _context.Commands.Remove(hero);
            await _context.SaveChangesAsync();

            return Ok(await _context.Commands.ToListAsync());
        }
    }
}
