using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awanuerTerceraEvaluacion.Servicios
{
    /// <summary>
    /// Interfaz que contiene los metodos de MenuImplementacion
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo encargado de mostrar el menu principal por consola y recoger la opcion
        /// seleccionada por el usuario
        /// awb - 040324
        /// </summary>
        /// <returns>la seleccion</returns>
        public int menuPrincipal();
        /// <summary>
        /// Metodo encargado de mostrar el menu del empleado por consola y recoger la opcion
        /// seleccionada por el usuario
        /// awb - 040324
        /// </summary>
        /// <returns>int</returns>
        public int menuEmpleado();

        /// <summary>
        /// Metodo encargado de mostrar el menu de la gerencia por consola y recoger la opcion
        /// seleccionada por el usuario
        /// awb - 040324
        /// </summary>
        /// <returns>int</returns>
        public int menuGerencia();
    }
}
