using AplicacionesMoviles.WebApi.Dtos.Tecnico;
using AplicacionesMoviles.WebApi.Interfaces.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionesMoviles.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    public class TecnicoController : ControllerBase
    {
        private readonly IServicioTecnico _servicioTecnico;

        public TecnicoController(IServicioTecnico servicioTecnico)
        {
            _servicioTecnico = servicioTecnico;
        }
        /// <summary>
        /// Devuelve listado con informacion de tecnicos
        /// </summary>
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<DtoTecnico> ObtenerTecnicos()
        {
            return _servicioTecnico.Obtener();
        }

        /// <summary>
        /// Metodo que permite a un tecnico iniciar sesion
        /// </summary>
        /// <param name="tecnico">Informacion del tecnico que iniciara sesion</param>
        /// <returns>true si se ingresan las credenciales correctas y se encuentra el registro en base de datos, false en caso contrario</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("iniciarSesion")]
        public bool IniciarSesion([FromBody]DtoLoginTecnico tecnico)
        {
            return _servicioTecnico.IniciarSesion(tecnico);
        }

        /// <summary>
        /// Permite registrar un tecnico nuevo en base de datos
        /// </summary>
        /// <param name="tecnico">Datos del nuevo tecnico</param>

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void AgregarTecnico([FromBody] DtoCreateUpdateTecnico tecnico)
        {
            _servicioTecnico.Crear(tecnico);
        }
    }
}
