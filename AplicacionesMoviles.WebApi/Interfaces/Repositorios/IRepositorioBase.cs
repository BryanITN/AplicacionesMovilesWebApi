using System.Linq.Expressions;

namespace AplicacionesMoviles.WebApi.Interfaces.Repositorios
{
    public interface IRepositorioBase<T> where T : class
    {
        IEnumerable<T> ObtenerTodo();
        T ObtenerPorId(object id);
        void Insertar(T obj);
        void Actualizar(T obj);
        void Eliminar(object id);
        void Guardar();
        IEnumerable<T> ObtenerPor(Expression<Func<T, bool>> filtro);
        IEnumerable<T> ObtenerConInclusiones(Expression<Func<T, bool>> filtro, params Expression<Func<T, object>>[] incluirExpresiones);
        void ActualizarPor(Expression<Func<T, bool>> filtro, Action<T> actualizar);
        void EliminarPor(Expression<Func<T, bool>> filtro);
    }
}
