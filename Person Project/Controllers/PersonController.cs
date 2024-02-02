using ClassLibrary.Model.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonProject.DbContexts;

namespace PersonProject.Controllers
{
    [ApiController]
    [Route("api")]
    public class PersonController : ControllerBase
    {
        private readonly PersonContext _dbContext;

        public PersonController(PersonContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }


        // VIEW:
        // GET: api/employees/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonModel>> GetPersonById(int id)
        {
            var person = await _dbContext.People
                .Where(p => p.PersonId == id)
                .Select(p => new PersonModel
                {
                    PersonId = p.PersonId,
                    PersonFirstName = p.PersonFirstName,
                    PersonLastName = p.PersonLastName,
                    PersonEmail = p.PersonEmail,
                    DateOfBirth = p.DateOfBirth,
                    PhoneNumber = p.PhoneNumber,
                    IsActive = p.IsActive
                })
                .FirstOrDefaultAsync();

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

    }
}
