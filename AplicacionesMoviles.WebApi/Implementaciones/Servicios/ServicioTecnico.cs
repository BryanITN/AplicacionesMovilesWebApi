using AplicacionesMoviles.WebApi.Dtos.Tecnico;
using AplicacionesMoviles.WebApi.Entidades;
using AplicacionesMoviles.WebApi.Interfaces.Repositorios;
using AplicacionesMoviles.WebApi.Interfaces.Servicios;
using AutoMapper;
using System.Linq;
using System.Linq.Expressions;

namespace AplicacionesMoviles.WebApi.Implementaciones.Servicios
{
    public class ServicioTecnico : IServicioTecnico
    {
        private readonly IRepositorioBase<Tecnico> _repositorio;
        private readonly IMapper _mapper;

        public ServicioTecnico(IRepositorioBase<Tecnico> repositorio, IMapper mapper)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }

        public void Actualizar(DtoCreateUpdateTecnico empleado)
        {
            throw new NotImplementedException();
        }

        public void Crear(DtoCreateUpdateTecnico empleado)
        {
            _repositorio.Insertar(_mapper.Map<Tecnico>(empleado));
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public bool IniciarSesion(DtoLoginTecnico tecnico)
        {
            var resultado = _repositorio.ObtenerPor(t => t.Nombre!.Equals(tecnico.Nombre) && t.Contrasenia!.Equals(tecnico.Contrasenia)).FirstOrDefault();
            if (resultado != null)
                return true;
            return false;
        }

        public IEnumerable<DtoTecnico> Obtener(Expression<Func<Tecnico, bool>>? filtro = null)
        {
            IEnumerable<Tecnico> lista;
            lista= _repositorio.ObtenerTodo();
            if (filtro != null)
                lista =_repositorio.ObtenerPor(filtro);
           return _mapper.Map<IEnumerable<DtoTecnico>>(lista);
        }

        public IEnumerable<DtoTecnico> ObtenerConInclusiones(Expression<Func<Tecnico, bool>>? filtro = null, params Expression<Func<Tecnico, object>>[] incluirExpresiones)
        {
            throw new NotImplementedException();
        }

        public DtoTecnico ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
