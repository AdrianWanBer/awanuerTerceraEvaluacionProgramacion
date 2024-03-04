using awanuerTerceraEvaluacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awanuerTerceraEvaluacion.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo que se encarga de añadir una venta a la lista
        /// awb - 040324
        /// </summary>
        public void añadirVenta(List<ventasDtos> listaVentas);
        /// <summary>
        /// Metodo que se encarga de calcular las ventas totales de un dia en especifico
        /// awb - 040324
        /// </summary>
        /// <param name="listaVentas"></param>
        public void calculoTotalVentasDiarias(List<ventasDtos> listaVentas);

        /// <summary>
        /// Metodo que se encarga de mostrar en un fichero las ventas 1 por 1 de un dia especifico
        /// awb - 040324
        /// </summary>
        /// <param name="listaVentas"></param>
        public void mostrarVentasDia(List<ventasDtos> listaVentas);

        /// <summary>
        /// Metodo que contendra la creacion de de pedidos a los proveedores
        /// awb - 040324
        /// </summary>
        /// <param name="listaPedidos"></param>
        public void crearPedido(List<pedidosDtos> listaPedidos);
    }
}
