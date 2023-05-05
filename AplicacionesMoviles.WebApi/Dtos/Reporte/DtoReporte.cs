
namespace AplicacionesMoviles.WebApi.Dtos.Reporte
{
    public class DtoReporte
    {
        /// <summary>
        /// Cantidad de registros pertenecientes a pruebas aprobadas
        /// </summary>
        /// <example>10</example>
        public double CantidadAprobada { get; set; }

        /// <summary>
        /// Cantidad de registros pertenecientes a pruebas fallidas
        /// </summary>
        /// <example>5</example>
        public double CantidadFallida { get; set; }

        /// <summary>
        /// Porcentaje de registros pertenecientes a pruebas aprobadas
        /// </summary>
        /// <example>0.50</example>
        public double CantidadAprobadaPorcentaje { get; set; }

        /// <summary>
        /// Porcentaje de registros pertenecientes a pruebas fallidas
        /// </summary>
        /// <example>0.35</example>
        public double CantidadFallidaPorcentaje { get; set; }

        /// <summary>
        /// Cantidad  total de pruebas realizadas
        /// </summary>
        /// <example>50</example>
        public double CantidadPruebasRealizadas { get; set; }
    }
}
