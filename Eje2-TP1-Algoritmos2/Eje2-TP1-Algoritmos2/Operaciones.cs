using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje2_TP1_Algoritmos2
{
    internal class Operaciones
    {
        private int mayor;         // Guarda el número mayor encontrado
        private int repeticiones;  // Cantidad de veces que se repitió el número mayor

        // Constructor sin parámetros
        public Operaciones()
        {
            mayor = int.MinValue;  // Inicializa "mayor" con el valor más bajo posible
            repeticiones = 0;      // Inicializa el contador en 0
        }

        // Método principal que se encarga de todo el proceso
        public void ProcesarNumeros()
        {
            for (int i = 1; i <= 10; i++) // Se repite 10 veces
            {
                Console.Write($"Ingrese el número {i}: ");  // Pide número al usuario
                int num = int.Parse(Console.ReadLine());    // Lee y guarda el número

                if (num > mayor) // Si el número es mayor que el actual "mayor"
                {
                    mayor = num;     // Actualiza el mayor
                    repeticiones = 1; // Reinicia el contador (porque es la primera vez que aparece)
                }
                else if (num == mayor) // Si el número es igual al mayor
                {
                    repeticiones++; // Aumenta la cantidad de repeticiones
                }
                // Si el número es menor, no se hace nada
            }
        }

        // Método para mostrar los resultados
        public void MostrarResultados()
        {
            Console.WriteLine($"\nEl número mayor es: {mayor}");           // Muestra el mayor
            Console.WriteLine($"Se repitió {repeticiones} veces.");        // Muestra las repeticiones
        }
    }
}
