using AplicacionesMoviles.WebApi.Dtos.Reporte;
using AplicacionesMoviles.WebApi.Entidades;
using AplicacionesMoviles.WebApi.Interfaces.Repositorios;
using AplicacionesMoviles.WebApi.Interfaces.Servicios;
using AutoMapper;

namespace AplicacionesMoviles.WebApi.Implementaciones.Servicios
{
    public class ServicioReporte:IServicioReporte
    {
        private readonly IRepositorioBase<Prueba> _repositorio;
        private readonly IMapper _mapper;

        public ServicioReporte(IRepositorioBase<Prueba> repositorio, IMapper mapper)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }

        public DtoReporte ObtenerResultados()
        {
            var objResultado = new DtoReporte();
            var listaPruebas = _repositorio.ObtenerTodo();
            objResultado.CantidadAprobada = listaPruebas.Where(p => p.Bandera!.ToLower().Equals("paso")).Count();
            objResultado.CantidadFallida = listaPruebas.Where(p => p.Bandera!.ToLower().Equals("no paso")).Count();
            objResultado.CantidadPruebasRealizadas = listaPruebas.Count();
            objResultado.CantidadAprobadaPorcentaje = objResultado.CantidadAprobada / objResultado.CantidadPruebasRealizadas;
            objResultado.CantidadFallidaPorcentaje = objResultado.CantidadFallida /objResultado.CantidadPruebasRealizadas;
            return objResultado;
        }
    }
}
