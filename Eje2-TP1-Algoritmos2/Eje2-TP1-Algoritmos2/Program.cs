using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje2_TP1_Algoritmos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones(); // Crea el objeto

            op.ProcesarNumeros();     // Ejecuta el procesamiento
            op.MostrarResultados();   // Muestra los resultados

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey(); // Pausa para que el usuario vea los resultados
        }
    }
}
