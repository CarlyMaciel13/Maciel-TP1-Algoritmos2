using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje1_Tp1_Algoritmos2
{
    internal class Operaciones
    {
        #region Atributos
        private int[] numeros; // Vector para almacenar los 10 números
        private int mayor;     // Variable para guardar el número mayor
        private int repeticiones; // Cantidad de veces que se repite el número mayor
        #endregion

        #region Constructor sin parámetros
        public Operaciones()
        {
            Numeros = new int[10]; // Se inicializa el vector con tamaño 10
            Mayor = int.MinValue;  // Inicia "mayor" con el valor más bajo posible para comparr luego
            Repeticiones = 0;      // Inicializa el contador en 0
        }
        #endregion
        #region Propiedades
        public int[] Numeros { get => numeros; set => numeros = value; }
        public int Mayor { get => mayor; set => mayor = value; }
        public int Repeticiones { get => repeticiones; set => repeticiones = value; }
        #endregion

        #region Metodos
        // Método para cargar los 10 números
        public void CargarNumeros()
        {
            for (int i = 0; i < 10; i++) // Bucle que se repite 10 veces
            {
                Console.Write($"Ingrese el número {i + 1}: "); // Solicita número al usuario
                Numeros[i] = int.Parse(Console.ReadLine());    // Guarda el número en el vector
            }
        }

        // Método para calcular el número mayor
        public void CalcularMayor()
        {
            // Recorre el vector para encontrar el número mayor
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] > Mayor) // Si el número actual es mayor que el anterior mayor
                {
                    Mayor = Numeros[i]; // Actualiza el número mayor
                }
            }
        }

        // Método para contar cuántas veces se repite el número mayor
        public void ContarRepeticiones()
        {
            Repeticiones = 0; // Reinicia el contador por si se llama varias veces

            for (int i = 0; i < Numeros.Length; i++) // Recorre el vector
            {
                if (Numeros[i] == Mayor) // Si encuentra el número mayor
                {
                    Repeticiones++; // Incrementa el contador
                }
            }
        }

        // Método para mostrar los resultados
        public void MostrarResultados()
        {
            Console.WriteLine($"\nEl número mayor es: {Mayor}"); // Muestra el número mayor(poner el $"" hace que se muestre el valor de la variable en medio de las {})
            Console.WriteLine($"Se repitió {Repeticiones} veces."); // Muestra cuántas veces se repitió
        }
        #endregion
    }
}
