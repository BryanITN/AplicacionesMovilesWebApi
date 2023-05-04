namespace AplicacionesMoviles.WebApi.Dtos.Tecnico
{
    public class DtoCreateUpdateTecnico
    {
        public int IdTecnico { get; set; }

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public string? Contrasenia { get; set; }
    }
}
