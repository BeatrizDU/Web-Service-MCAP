using WebService.Models;

namespace WebService.DataAccess
{
    /// <summary>
    /// BDOMINGUEZ 06/05/2023
    /// Interface de acceso a métodos de persistencia
    /// </summary>
    public interface IDataAccessProvider
    {
        List<catalumno> GetAlumnos();
        catalumno GetAlumno(int id);
        void CreateAlumno(catalumno alumno);
    }
}
