using AplicacionesMoviles.WebApi.Dtos.Tecnico;
using AplicacionesMoviles.WebApi.Entidades;
using System.Linq.Expressions;

namespace AplicacionesMoviles.WebApi.Interfaces.Servicios
{
    public interface IServicioTecnico
    {
        IEnumerable<DtoTecnico> Obtener(Expression<Func<Tecnico, bool>>? filtro = null);
        IEnumerable<DtoTecnico> ObtenerConInclusiones(Expression<Func<Tecnico, bool>>? filtro=null, params Expression<Func<Tecnico, object>>[] incluirExpresiones);
        DtoTecnico ObtenerPorId(int id);
        bool IniciarSesion(DtoLoginTecnico tecnico);
        void Crear(DtoCreateUpdateTecnico empleado);
        void Actualizar(DtoCreateUpdateTecnico empleado);
        void Eliminar(int id);
    }
}
