using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelationEF.Data;

namespace RelationEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GradesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllGrades()
        {
            try
            {
                var grades = await _context.Grades.Include(x=>x.Students).ToListAsync();
                return Ok(grades);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
