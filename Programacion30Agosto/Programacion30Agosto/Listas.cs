using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion30Agosto
{
    class Listas
    {
        //Investigar que significa la <t> dentro de las estructuras de datos.
        private List<string> milista = new List<string>(); //Instancia de listas.     

        public void cargar(string data)
        {

            milista.Add(data);
        }

        public void cargarElementosPrIndice(int posicion, string data)
        {
            milista.Insert(posicion, data);  //Se utiliza este método para las posiciones (indies) de lo que se ingrese.
        }

        //public int contarElementosDeListas()
        //{
        //    return milista.Count(); //El Count cuenta los elementos de las listas, este toma un string.
        //}

        public void imprimirConteo()
        {
             Console.WriteLine("La lista cuenta con: " + milista.Count().ToString() + " elementos");  //Muestra todos los elementos.
             Console.ReadKey();
        }

        public void imprimir()
        {
            //foreach(string prime in milista)
            //{
            //    Console.WriteLine(prime);  
            //}

            //for (int i; i < milista.Count; i++)
            //{
            //    Console.WriteLine($"{i} = {milista[i]}");  //Con el signo de $ se puede manipular el string
            //}

            milista.ForEach(a => Console.WriteLine("Elementos: " + a));  //ForEach muestra los elementos de una sola manera
            // "a" se le asigna lo que le sigue.

            Console.ReadKey();
        }

        public void limpiarLista()
        {
            milista.Clear(); //Borra toda la información de la lista.
        }

        public void buscarInfo(string info)
        {
            int encontrado = milista.IndexOf(info);  //Index devuelve la posición en donde está el elemento

            Console.WriteLine("Se encontró el elemento en la posición: " + encontrado);

            
            Console.ReadKey();
        }
    }
}
