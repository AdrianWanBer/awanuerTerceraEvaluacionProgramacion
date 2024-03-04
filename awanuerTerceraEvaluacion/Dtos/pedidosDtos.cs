using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awanuerTerceraEvaluacion.Dtos
{
    /// <summary>
    /// Identidad que contendra los campos de los pedidos
    /// awb - 040324
    /// </summary>
    internal class pedidosDtos
    {
        public int idPedido;
        public string nombreProducto;
        public int cantidadProducto;
        public string fechaEntrega;

        /// <summary>
        /// Constructor con los campos
        /// awb - 040324
        /// </summary>
        /// <param name="idPedido"></param>
        /// <param name="nombreProducto"></param>
        /// <param name="cantidadProducto"></param>
        /// <param name="fechaEntrega"></param>
        public pedidosDtos(int idPedido, string nombreProducto, int cantidadProducto, string fechaEntrega)
        {
            this.idPedido = idPedido;
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            this.fechaEntrega = fechaEntrega;
        }

        /// <summary>
        /// Constructor vacio
        /// awb - 040324
        /// </summary>
        public pedidosDtos()
        {
        }
    }
}
