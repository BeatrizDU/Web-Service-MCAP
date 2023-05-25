using WebService.Models;

namespace WebService.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSQLContext _context;
        
        public DataAccessProvider(PostgreSQLContext context)
        {
            _context = context;
        }
        public List<catalumno> GetAlumnos()
        {
            return _context.catalumno.ToList();
        }

        public catalumno GetAlumno(int id)
        {
            return _context.catalumno.Find(id);
        }

        public void CreateAlumno(catalumno alumno)
        {
            /*var alumnodata = new catalumno
            {
                id = alumno.id,
                nombre = alumno.nombre
            };*/
            _context.catalumno.Add(alumno);
            _context.SaveChanges();
        }
    }
}
