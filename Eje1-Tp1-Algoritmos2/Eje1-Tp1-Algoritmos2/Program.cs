using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje1_Tp1_Algoritmos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones(); // Se crea un objeto de la clase Operaciones

            op.CargarNumeros();       // Carga los números
            op.CalcularMayor();       // Calcula el número mayor
            op.ContarRepeticiones();  // Cuenta cuántas veces se repite
            op.MostrarResultados();   // Muestra el resultado final

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey(); // Pausa para que se pueda ver el resultado antes de que se cierre
        }
    }
}
