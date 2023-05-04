using AplicacionesMoviles.WebApi.Dtos.Reporte;
using AplicacionesMoviles.WebApi.Interfaces.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionesMoviles.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ReportesController : ControllerBase
    {
        private readonly IServicioReporte _servicioReporte;

        public ReportesController(IServicioReporte servicioReporte)
        {
            _servicioReporte = servicioReporte;
        }

        [HttpGet]
        public DtoReporte obtenerReporte()
        {
            return _servicioReporte.ObtenerResultados();
        }
    }
}
