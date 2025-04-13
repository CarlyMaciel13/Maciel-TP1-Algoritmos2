using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje3_TP1_Algoritmos2
{
    internal class Items
    {
        
        public int Numero { get; set; }  // Guarda el número del ítem (por ejemplo, 1, 2, 3...).
        public string Articulo { get; set; }   // Nombre del producto o artículo).
        public double Precio { get; set; }  // Precio unitario del producto.
        public int Cantidad { get; set; }  // Cantidad que se va a comprar de ese artículo.

        // Esta propiedad calcula automáticamente el importe total (precio x cantidad) para no tener que hacerlo despues.
        public double Importe => Precio * Cantidad;

        // Constructor vacío (sin parámetros): se usa cuando se quiere crear un ítem sin cargar datos al inicio.
        public Items() { }

        // Constructor con parámetros
        public Items(int numero, string articulo, double precio, int cantidad)
        {
            Numero = numero;           // Se asigna el número al ítem.
            Articulo = articulo;       // Se asigna el nombre del artículo.
            Precio = precio;           // Se asigna el precio unitario.
            Cantidad = cantidad;       // Se asigna la cantidad deseada.
        }
    }
}
