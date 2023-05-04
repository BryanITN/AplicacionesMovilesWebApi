using AplicacionesMoviles.WebApi.Entidades;
using AplicacionesMoviles.WebApi.Interfaces.Repositorios;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AplicacionesMoviles.WebApi.Implementaciones.Repositorios
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        private readonly BaseDatosContext _contexto;

        public RepositorioBase(BaseDatosContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<T> ObtenerTodo()
        {
            return _contexto.Set<T>().ToList();
        }

        public T ObtenerPorId(object id)
        {
            return _contexto.Set<T>().Find(id);
        }

        public void Insertar(T obj)
        {
            _contexto.Set<T>().Add(obj);
        }

        public void Actualizar(T obj)
        {
            _contexto.Set<T>().Update(obj);
        }

        public void Eliminar(object id)
        {
            var entidad = _contexto.Set<T>().Find(id);
            if (entidad != null)
            {
                _contexto.Set<T>().Remove(entidad);
            }
        }

        public void Guardar()
        {
            _contexto.SaveChanges();
        }

        public IEnumerable<T> ObtenerPor(Expression<Func<T, bool>> filtro)
        {
            return _contexto.Set<T>().Where(filtro).ToList();
        }

        public IEnumerable<T> ObtenerConInclusiones(Expression<Func<T, bool>> filtro, params Expression<Func<T, object>>[] incluirExpresiones)
        {
            var consulta = _contexto.Set<T>().AsQueryable();
            foreach (var incluirExpresion in incluirExpresiones)
            {
                consulta = consulta.Include(incluirExpresion);
            }
            return consulta.Where(filtro).ToList();
        }

        public void ActualizarPor(Expression<Func<T, bool>> filtro, Action<T> actualizar)
        {
            _contexto.Set<T>().Where(filtro).ToList().ForEach(actualizar);
        }

        public void EliminarPor(Expression<Func<T, bool>> filtro)
        {
            _contexto.Set<T>().RemoveRange(_contexto.Set<T>().Where(filtro));
        }
    }
}
