using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST;

namespace Eje3_TP1_Algoritmos2
{
    internal class Facturas
    {
        private int tipoFactura;               // Guarda el tipo de factura elegido por el usuario.
        private double porcentaje;             // Porcentaje que se va a aplicar al total según el tipo de factura.
        private List<Items> listaItems;        // Lista que guarda los ítems que se van agregando a la factura.

        // Constructor de la clase: se ejecuta automáticamente cuando se crea un objeto de esta clase.
        public Facturas()
        {
            listaItems = new List<Items>();   // Inicializamos la lista de ítems (empezamos con la lista vacía).
        }

        // Este método permite al usuario elegir el tipo de factura.
        public void IngresarTipoFactura()
        {
            // Mostramos las opciones al usuario.
            Console.WriteLine("Tipo de factura:");
            Console.WriteLine("1 - Responsable Inscripto (10.5%)");
            Console.WriteLine("2 - Consumidor Final (21%)");
            Console.WriteLine("3 - Bienes y Servicios (-27%)");

            // Usamos un método externo para leer la opción del usuario (entre 1 y 3).
            tipoFactura = Validaciones.LeerInt(1, 3);

            // Según el tipo elegido, se asigna el porcentaje correspondiente.
            switch (tipoFactura)
            {
                case 1: porcentaje = 0.105; break;  // 10.5%
                case 2: porcentaje = 0.21; break;   // 21%
                case 3: porcentaje = -0.27; break;  // -27% (en este caso es una deducción o descuento).
            }
        }

        // Este método permite ingresar varios productos (ítems) en la factura.
        public void IngresarItems()
        {
            Console.Write("¿Cuántos ítems desea ingresar?: ");   // Preguntamos cuántos ítems quiere cargar el usuario.
            int cantidad = int.Parse(Console.ReadLine());         // Leemos la respuesta y la convertimos a número.

            // Repetimos el ingreso de datos la cantidad de veces que indicó el usuario.
            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine($"\nÍtem {i}:");                // Indicamos qué ítem estamos cargando.

                Console.Write("Artículo: ");                      // Pedimos el nombre del artículo.
                string articulo = Console.ReadLine();

                Console.Write("Precio: ");                        // Pedimos el precio unitario del artículo.
                double precio = double.Parse(Console.ReadLine());

                Console.Write("Cantidad: ");                      // Pedimos la cantidad que se va a llevar.
                int cant = int.Parse(Console.ReadLine());

                // Creamos un nuevo objeto Items con esos datos y lo agregamos a la lista.
                listaItems.Add(new Items(i, articulo, precio, cant));
            }
        }

        // Este método muestra todos los ítems cargados con su importe final calculado.
        public void MostrarFacturaFinal()
        {
            Console.WriteLine("\n--- FACTURA FINAL ---");         // Mostramos un título.

            // Recorremos todos los ítems que están en la lista.
            foreach (var item in listaItems)
            {
                // Calculamos el importe final, sumando o restando el porcentaje según el tipo de factura.
                double importeFinal = item.Importe + (item.Importe * porcentaje);

                // Mostramos todos los datos del ítem, incluido su importe final con formato decimal.
                Console.WriteLine($"Ítem {item.Numero}: {item.Articulo} | Cant: {item.Cantidad} | Precio: {item.Precio} | Importe Final: {importeFinal:F2}");
            }
        }

        // Este método busca y muestra el ítem con el mayor valor (importe).
        public void MostrarItemMayor()
        {
            // Si no hay ítems en la lista, se muestra un mensaje y se termina el método.
            if (listaItems.Count == 0)
            {
                Console.WriteLine("No hay ítems cargados.");
                return;
            }

            // Supone que el primer ítem es el de mayor valor.
            Items mayor = listaItems[0];

            // Recorremos todos los ítems para encontrar cuál tiene el mayor importe.
            foreach (var item in listaItems)
            {
                if (item.Importe > mayor.Importe)
                    mayor = item; // Si encontramos uno con más valor, lo guardamos como el nuevo mayor.
            }

            // Mostramos los datos del ítem que tiene el mayor valor.
            Console.WriteLine("\nÍtem de mayor valor:");
            Console.WriteLine($"Número: {mayor.Numero} | Artículo: {mayor.Articulo} | Precio: {mayor.Precio} | Cantidad: {mayor.Cantidad} | Importe: {mayor.Importe}");
        }

        // Este método calcula y muestra el promedio de los importes de todos los ítems.
        public void MostrarPromedio()
        {
            // Si no hay ítems cargados, muestra un mensaje y termina el método.
            if (listaItems.Count == 0)
            {
                Console.WriteLine("No hay ítems cargados.");
                return;
            }

            double suma = 0; // Variable para guardar la suma total de importes.

            // Sumamos el importe de cada ítem.
            foreach (var item in listaItems)
                suma += item.Importe;

            // Calculamos el promedio dividiendo la suma total entre la cantidad de ítems.
            double promedio = suma / listaItems.Count;

            // Mostramos el resultado con dos decimales.
            Console.WriteLine($"\nPromedio de importes: {promedio:F2}");
        }
    }
}
