using Microsoft.AspNetCore.Mvc;
using XJSC120230911.Models;


namespace XJSC120230911.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocentesController : ControllerBase
    {
        
        static List<Docentes> docentes = new List<Docentes>();

        [HttpGet]
        public IEnumerable<Docentes> Get()
        {
            return docentes;
        }

        
        

        
        [HttpPost]
        public IActionResult Post([FromBody] Docentes docente)
        {
            docentes.Add(docente);
            return Ok();
        }

        
    }
}
