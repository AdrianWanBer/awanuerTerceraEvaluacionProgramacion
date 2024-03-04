namespace awanuerTerceraEvaluacion.Servicios
{
    /// <summary>
    /// Implementacion que se encargara de lo relacionado con los menus
    /// awb - 040324
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Metodo que mostrara el menu y recogera la seleccion
        /// awb - 040324
        /// </summary>
        /// <returns>seleccion</returns>
        public int menuPrincipal()
        {
            Console.WriteLine("A QUE MENU DESEA ACCEDER");
            Console.WriteLine("0. Cerrar aplicación.");
            Console.WriteLine("1. Menú empleado.");
            Console.WriteLine("2. Menú gerencia.");
            int seleccion = Convert.ToInt32(Console.ReadLine());
            return seleccion;
        }

        /// <summary>
        /// Metodo que mostrara el menu de los empleados y recogera la seleccion
        /// awb - 040324
        /// </summary>
        /// <returns>seleccion</returns>
        public int menuEmpleado()
        {
            Console.WriteLine("QUE DESEA HACER (EMPLEADO)");
            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Cálculo total de ventas diario.");
            Console.WriteLine("2. Añadir venta.");
            int seleccion = Convert.ToInt32(Console.ReadLine());
            return seleccion;

        }
        /// <summary>
        /// Metodo que mostrara el menu de las gerencias y recogera la seleccion
        /// awb - 040324
        /// </summary>
        /// <returns>seleccion</returns>
        public int menuGerencia()
        {
            Console.WriteLine("QUE DESEA HACER (GERENCIA)");
            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Escribir todas las ventas del dia.");
            Console.WriteLine("2. Crear un nuevo pedido para proveedores.");
            int seleccion = Convert.ToInt32(Console.ReadLine());
            return seleccion;
        }
    }
}
