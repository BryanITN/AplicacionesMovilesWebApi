using AplicacionesMoviles.WebApi.Dtos.Tecnico;
using AplicacionesMoviles.WebApi.Interfaces.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionesMoviles.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TecnicoController : ControllerBase
    {
        private readonly IServicioTecnico _servicioTecnico;

        public TecnicoController(IServicioTecnico servicioTecnico)
        {
            _servicioTecnico = servicioTecnico;
        }

        [HttpGet]
        public IEnumerable<DtoTecnico> ObtenerTecnicos()
        {
            return _servicioTecnico.Obtener();
        }

        [HttpPost]
        [Route("iniciarSesion")]
        public bool IniciarSesion([FromBody]DtoLoginTecnico tecnico)
        {
            return _servicioTecnico.IniciarSesion(tecnico);
        }

        [HttpPost]
        public void AgregarTecnico([FromBody] DtoCreateUpdateTecnico tecnico)
        {
            _servicioTecnico.Crear(tecnico);
        }
    }
}
