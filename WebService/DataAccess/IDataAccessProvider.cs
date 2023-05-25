using WebService.Models;

namespace WebService.DataAccess
{
    /// <summary>
    /// BDOMINGUEZ 06/05/2023
    /// Interface de acceso a métodos de persistencia
    /// </summary>
    public interface IDataAccessProvider
    {
        /// <summary>
        /// BDOMINGUEZ 24/05/2023
        /// Interface para obtener todos los registros
        /// </summary>
        /// <returns>List<catalumno></returns>
        List<catalumno> GetAlumnos();

        /// <summary>
        /// BDOMINGUEZ 24/05/2023
        /// Interface para obtener solo un registro con su respectivo id
        /// </summary>
        /// <param name="id">Id a consultar</param>
        /// <returns>catalumno</returns>
        catalumno GetAlumno(int id);

        /// <summary>
        /// BDOMINGUEZ 24/05/2023
        /// Interface para agregar un registro
        /// </summary>
        /// <param name="alumno"></param>
        void CreateAlumno(catalumno alumno);
    }
}
