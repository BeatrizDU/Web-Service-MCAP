using Microsoft.AspNetCore.Mvc;
using WebService.DataAccess;
using WebService.Models;

namespace WebService.Controllers
{
    [Route("api/[controller]")]

    public class catalumnoController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public catalumnoController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(catalumno))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        [HttpGet]

        public IEnumerable<catalumno> Get() 
        {
            return _dataAccessProvider.GetAlumnos();
        }

        [HttpGet("{id}")]
    
        public IActionResult Get(int id)
        {
            var result = _dataAccessProvider.GetAlumno(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody]catalumno alumno) 
        { 
            if (alumno == null)
            {
                return BadRequest();
            }

            _dataAccessProvider.CreateAlumno(alumno);
            return Ok();
        }
    }
}
