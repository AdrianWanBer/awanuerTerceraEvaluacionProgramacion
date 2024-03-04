using awanuerTerceraEvaluacion.Dtos;
using awanuerTerceraEvaluacion.Servicios;

namespace awanuerTerceraEvaluacion.Controladores
{
    class program
    {
        static void Main(string[] args)
        {
            //Variables y declaraciones
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            List<ventasDtos> listaVentas = new List<ventasDtos>();
            List<pedidosDtos> listaPedidos = new List<pedidosDtos>();
            bool cerrarMenu = false;
            bool cerradoMenuEmpleado = false;
            bool cerradoMenuGerencia = false;

            while (!cerrarMenu)
            {
                int seleccion = mi.menuPrincipal();
                switch (seleccion)
                {
                    case 0: //Cerrara el menu
                        cerrarMenu = true;
                        break;

                    case 1: //Abrira el menu empleado
                        while (!cerradoMenuEmpleado)
                        {
                            int seleccionEmpleado = mi.menuEmpleado();
                            switch (seleccionEmpleado)
                            {
                                case 0: //Cerrara el menu de empleados
                                    cerradoMenuEmpleado = true;
                                    break;
                                case 1: //Cálculo total de ventas diario
                                    oi.calculoTotalVentasDiarias(listaVentas);
                                    break;
                                case 2: //Añadir venta.
                                    oi.añadirVenta(listaVentas);
                                    break;
                            }
                        }
                        break;

                    case 2://Abrira el menu gerencia
                        while (!cerradoMenuGerencia)
                        {
                            int seleccionGerencia = mi.menuGerencia();
                            switch (seleccionGerencia)
                            {
                                case 0: //Cerrar menu gerencias
                                    cerradoMenuGerencia = true;
                                    break;
                                case 1: //Escribir todas las ventas del dia
                                    oi.mostrarVentasDia(listaVentas);
                                    break;
                                case 2: //Crear un nuevo pedido para proveedores
                                    oi.crearPedido(listaPedidos);
                                    break;
                            }
                        }
                        break;
                }
            }

        }
    }
}
