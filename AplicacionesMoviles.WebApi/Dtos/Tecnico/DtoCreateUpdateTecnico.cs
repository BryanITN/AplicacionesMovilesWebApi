namespace AplicacionesMoviles.WebApi.Dtos.Tecnico
{
    public class DtoCreateUpdateTecnico
    {
        /// <summary>
        /// Id unico y autoincremental por cada registro de tecnico
        /// </summary>
        /// <example>1</example>
        public int IdTecnico { get; set; }

        /// <summary>
        /// Nombre del tecnico
        /// <example>Bryan</example>
        /// </summary>
        public string? Nombre { get; set; }

        /// <summary>
        /// Apellido del tecnico
        /// </summary>
        /// <example>Gonzalez</example>
        public string? Apellido { get; set; }

        /// Contrasenia del tecnico
        /// </summary>
        public string? Contrasenia { get; set; }
    }
}
