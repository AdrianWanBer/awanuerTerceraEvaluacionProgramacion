using awanuerTerceraEvaluacion.Dtos;

namespace awanuerTerceraEvaluacion.Servicios
{
    /// <summary>
    /// Implementacion que contiene la operativa de la aplicacion
    /// awb - 040324
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {


        /// <summary>
        /// Metodo encargado de añadir venta
        /// awb - 040324
        /// </summary>
        /// <param name="listaVentas"></param>
        int idVenta = 0;
        private IFormatProvider? provider;

        public void añadirVenta(List<ventasDtos> listaVentas)
        {
            ventasDtos listaTemporal = new ventasDtos();

            Console.WriteLine("Cual a sido el importe: ");
            float importe = Convert.ToInt64(Console.ReadLine());
            DateTime fechaVenta = DateTime.Now;

            listaTemporal.ImporteVenta = importe;
            listaTemporal.fechaVenta = fechaVenta;
            listaTemporal.idVenta = idVenta;
            idVenta += 1;
            listaVentas.Add(listaTemporal);
        }
        /// <summary>
        /// Se encargara de sumar todas las ventas del dia
        /// </summary>
        /// <param name="listaVentas"></param>
        public void calculoTotalVentasDiarias(List<ventasDtos> listaVentas)
        {
            float importeTotal = 0;
            Console.WriteLine("De que fecha desea realizar el calculo total (formato --> dd-MM-yyyy): ");
            string fecha = Console.ReadLine();
            string formatoFecha = "dd MM yyyy";
            DateTime FechaBien = DateTime.ParseExact(fecha, formatoFecha, provider);
            //Console.WriteLine(FechaBien);
            foreach (ventasDtos ventas in listaVentas)
            {
                if (fecha.Equals(ventas.fechaVenta))
                {
                    importeTotal = importeTotal + ventas.ImporteVenta;
                }

                
            }
            Console.WriteLine("Total ventas: " + importeTotal + " euros");
            Console.WriteLine("Tiempo transcurrido: " + fecha);
            Console.WriteLine();
        }

        /// <summary>
        /// Metodo que se encargara de escribir en un fichero las ventas de un dia completo 
        /// por individual
        /// awb - 040324
        /// </summary>
        /// <param name="listaVentas"></param>
        public void mostrarVentasDia(List<ventasDtos> listaVentas)
        {
            Console.WriteLine("Que fecha desea escribir (formato --> dd-MM-yyyy): ");
            string fecha = Console.ReadLine();
            string formatoFecha = "dd MM yyyy";
            DateTime FechaBien = DateTime.ParseExact(fecha, formatoFecha, provider);

            StreamWriter sw = new StreamWriter($"{FechaBien.Day}{FechaBien.Month}{FechaBien.Year}.txt");
            int conteoVentas = 1;
            foreach (ventasDtos ventas in listaVentas)
            {
                if (FechaBien.Equals(ventas.fechaVenta))
                {
                    sw.WriteLine("……….");
                    sw.WriteLine("Venta número: " + conteoVentas);
                    sw.WriteLine("Euros: " + ventas.ImporteVenta + " euros");
                    sw.WriteLine("Instante de compra: " + ventas.fechaVenta);
                    sw.WriteLine("……….");
                    conteoVentas++;

                }
            }
            Console.WriteLine("Archivo escrito");
        }
        /// <summary>
        /// Metodo que contendra la creacion de de pedidos a los proveedores y mostrarlos por consola
        /// awb - 040324
        /// </summary>
        /// <param name="listaPedidos"></param>
        int idPedido = 0;
        public void crearPedido(List<pedidosDtos> listaPedidos)
        {
            do
            {
                pedidosDtos nuevoPedido = new pedidosDtos();

                Console.WriteLine("Nombre del producto: ");
                string nombreProducto = Console.ReadLine();
                Console.WriteLine("Cantidad del producto: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Fecha deseada de entrega (dd-MM-yyyy): ");
                string fechaEntrega = Console.ReadLine();

                nuevoPedido.nombreProducto = nombreProducto;
                nuevoPedido.cantidadProducto = cantidad;
                nuevoPedido.fechaEntrega = fechaEntrega;
                nuevoPedido.idPedido = idPedido;

                listaPedidos.Add(nuevoPedido);
                idPedido++;

                Console.WriteLine("Si desea continuar pulse (s), en su opuesta pulse cualquier otra tecla");
            } while (Console.ReadLine().Equals("s"));

            foreach (pedidosDtos pedidos in listaPedidos)
            {
                Console.WriteLine("Producto: " + pedidos.nombreProducto);
                Console.WriteLine("Cantidad: " + pedidos.cantidadProducto + " unidades");
                Console.WriteLine("Fecha entrega: " + pedidos.fechaEntrega);
                Console.WriteLine();
            }
        }
    }
}
