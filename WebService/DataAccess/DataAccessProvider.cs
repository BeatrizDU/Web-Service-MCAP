using WebService.Models;

namespace WebService.DataAccess
{
    /// <summary>
    /// BDOMINGUEZ 24/05/2023
    /// Clase para el manejo de la base de datos
    /// </summary>
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSQLContext _context;
        
        public DataAccessProvider(PostgreSQLContext context)
        {
            _context = context;
        }

        /// <summary>
        /// BDOMINGUEZ 24/05/2023
        /// Método para obtener todos los registros de la base de datos
        /// </summary>
        /// <returns>List<catalumno></returns>
        public List<catalumno> GetAlumnos()
        {
            return _context.catalumno.ToList();
        }

        /// <summary>
        /// BDOMINGUEZ 24/05/2023
        /// Método para obtener el registro que coincida con el id
        /// </summary>
        /// <param name="id">id a consultar</param>
        /// <returns>catalumno</returns>
        public catalumno GetAlumno(int id)
        {
            return _context.catalumno.Find(id);
        }

        /// <summary>
        /// BDOMINGUEZ 24/05/2023
        /// Método para agregar un nuevo registro
        /// </summary>
        /// <param name="alumno">datos a agregar en el registro</param>
        public void CreateAlumno(catalumno alumno)
        {
            _context.catalumno.Add(alumno);
            _context.SaveChanges();
        }
    }
}
