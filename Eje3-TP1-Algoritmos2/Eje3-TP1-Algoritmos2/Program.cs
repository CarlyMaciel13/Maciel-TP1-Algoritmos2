using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST;

namespace Eje3_TP1_Algoritmos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Facturas factura = new Facturas(); // Se crea un objeto de tipo Facturas para trabajar.
            int opcion;                         // Variable para guardar la opción del menú elegida por el usuario.

            do
            {
                opcion = Menu(); // Muestra el menú y guarda la opción seleccionada.

                switch (opcion)  // Según el valor de la opción, se ejecuta un bloque de código.
                {
                    case 1:
                        factura.IngresarTipoFactura(); // Permite elegir el tipo de factura (A, B o C).
                        break;
                    case 2:
                        factura.IngresarItems();       // Permite ingresar ítems con nombre, precio y cantidad.
                        break;
                    case 3:
                        factura.MostrarFacturaFinal(); // Muestra todos los ítems y el total a pagar.
                        break;
                    case 4:
                        factura.MostrarItemMayor();    // Muestra el ítem con mayor valor (importe).
                        break;
                    case 5:
                        factura.MostrarPromedio();     // Muestra el promedio de todos los importes.
                        break;
                }

                // Espera a que el usuario presione una tecla y luego limpia la pantalla.
                Console.WriteLine("\n\nToque una tecla para continuar..");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 0); // El ciclo se repite hasta que se elija la opción 0 (salir).

            Console.ReadKey(); // Espera una tecla final antes de cerrar el programa.
        }

        // Método que muestra el menú de opciones y devuelve la opción elegida por el usuario.
        private static int Menu()
        {
            int cantidaDeOpciones = 5; // Cantidad total de opciones válidas del menú.
            int opcion;                // Variable para guardar la opción elegida.

            Console.WriteLine("Ingrese el número de la opción y luego enter:\n");
            Console.WriteLine("1 - Ingresar tipo de factura");
            Console.WriteLine("2 - Ingresar ítems");
            Console.WriteLine("3 - Mostrar factura final");
            Console.WriteLine("4 - Mostrar ítem de mayor valor");
            Console.WriteLine("5 - Mostrar promedio de importes");
            Console.WriteLine("0 - Salir\n");

            // Se llama a la clase Validaciones para asegurarse que se ingrese un número entre 0 y 5.
            opcion = Validaciones.LeerInt(0, cantidaDeOpciones);
            return opcion; // Devuelve la opción elegida.
        
        }
    }
    
}


