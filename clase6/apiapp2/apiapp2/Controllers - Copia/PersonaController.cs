using apiapp2.data;
using apiapp2.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiapp2.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly ContextDB _contexto;
        public PersonaController( ContextDB contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        [Route("api/personas/getPersonas")]
        public async  Task<ActionResult<List<Persona>>> GetPersonas()
        {
            var personas = await _contexto.Personas.ToListAsync();
            return Ok(personas);
        }

        [HttpGet]
        [Route("api/personas/getPersonasById/{id}")]
        public async Task<ActionResult<Persona>> GetPersonaById(int id)
        {
            var personas = await _contexto.Personas.Where(c => c.Id == id).FirstOrDefaultAsync();
            return Ok(personas);
        }


    }
}
