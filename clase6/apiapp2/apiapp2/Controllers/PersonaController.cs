using apiapp2.data;
using apiapp2.model;
using Microsoft.AspNetCore.Mvc;

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
        public async  ActionResult<List<Persona>> GetPersonas()
        {
            var personas = _contexto.Personas.ToListAsync();
            return Ok(personas);
        }

        [HttpGet]
        [Route("api/personas/getPersonasById/{id}")]
        public async Task<ActionResult<Persona>> GetPersonaById(int id)
        {
            var personas = _contexto.Personas.Where(c => c.Id == id).FirstOrDefault();
            return Ok(personas);
        }


    }
}
