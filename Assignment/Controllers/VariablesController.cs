
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VariablesController : ControllerBase
    {
        private readonly AssignmentContext _context;

        public VariablesController(AssignmentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Variable>> Get()
        {
            return await _context.Variables.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Variable> Get(int id)
        {
            var product = await _context.Variables.FirstOrDefaultAsync(m => m.Id == id);
             return product;

        }

        [HttpPost]
        public async Task Post(Variable variable)
        {
            _context.Add(variable);
            await _context.SaveChangesAsync();
        }       
    }
}
