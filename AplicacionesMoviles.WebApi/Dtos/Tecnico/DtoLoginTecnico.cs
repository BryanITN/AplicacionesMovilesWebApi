namespace AplicacionesMoviles.WebApi.Dtos.Tecnico
{
    public class DtoLoginTecnico
    {
        /// <summary>
        /// Es el nombre del tecnico,solo se toma en cuenta el nombre. No el apellido
        /// </summary>
        /// <example>Bryan</example>
        public string? Nombre { get; set; }
        /// <summary>
        /// Contrasenia del tecnico
        /// </summary>
        public string? Contrasenia { get; set; }
    }
}
