using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelationEF.Data;

namespace RelationEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllStudent()
        {
            try
            {
                var Students = await _context.Students.Include(x => x.Grade).Include(i=>i.StudentAddress).ToListAsync();
                //var Students = await _context.Students.ToListAsync();
                return Ok(Students);
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetStudentById(int id)
        {
            try
            {
                var Student = await _context.Students.Include(x => x.Grade).FirstOrDefaultAsync(i => i.StudentId == id);
                return Ok(Student);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
