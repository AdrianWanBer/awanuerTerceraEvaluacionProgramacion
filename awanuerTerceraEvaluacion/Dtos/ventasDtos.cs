namespace awanuerTerceraEvaluacion.Dtos
{
    /// <summary>
    /// Identidad que contiene los campos relacionados con las ventas
    /// awb - 040324
    /// </summary>
    internal class ventasDtos
    {
        public int idVenta;
        public float ImporteVenta;
        public DateTime fechaVenta;

        /// <summary>
        /// Constructor con los campos 
        /// awb - 040324
        /// </summary>
        /// <param name="idVenta"></param>
        /// <param name="importeVenta"></param>
        /// <param name="fechaVenta"></param>
        public ventasDtos(int idVenta, float importeVenta, DateTime fechaVenta)
        {
            this.idVenta = idVenta;
            ImporteVenta = importeVenta;
            this.fechaVenta = fechaVenta;
        }

        /// <summary>
        /// Constructor vacio
        /// awb - 040324
        /// </summary>
        public ventasDtos()
        {
        }
    }
}
