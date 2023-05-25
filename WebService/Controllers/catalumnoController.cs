using Microsoft.AspNetCore.Mvc;
using WebService.DataAccess;
using WebService.Models;

namespace WebService.Controllers
{
    [Route("api/[controller]")]

    public class catalumnoController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        /// <summary>
        /// BDOMINGUEZ 24/05/2023
        /// Método para inicializar el data provider que realizará operaciones en la base de datos
        /// </summary>
        /// <param name="dataAccessProvider"></param>
        public catalumnoController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        // Posibles respuestas a operaciones HTTP
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(catalumno))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        /// <summary>
        /// BDOMINGUEZ 24/05/2023
        /// Método para ejecutar la operación GET para obtener todos los registros de la base de datos
        /// </summary>
        [HttpGet]
        public IEnumerable<catalumno> Get() 
        {
            return _dataAccessProvider.GetAlumnos();
        }

        /// <summary>
        /// BDOMINGUEZ 24/05/2023
        /// Método para ejecutar la operación GET de un solo registro con su id
        /// </summary>
        /// <param name="id">id que debe coincidir con un registro de la base de datos</param>
        /// <returns>StatusCode</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _dataAccessProvider.GetAlumno(id);
            return result != null ? Ok(result) : NotFound();
        }

        /// <summary>
        /// BDOMINGUEZ 24/05/2023
        /// Método para ejecutar la operación POST para agregar un nuevo registro a la base de datos
        /// </summary>
        /// <param name="alumno">registro a agregar en la base de datos</param>
        /// <returns>StatusCode</returns>
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
