using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionColas
{
    class misColas
    {
        //Colas
        Queue<string> cola = new Queue<string>();

        public void agregarEnCola(string data)
        {
            cola.Enqueue(data);  //Estamos agregando un elemento a la cola, Enqueue es para insertar.
        }

        public void imprimir()
        {
            foreach(var item in cola)  //Este recorre toda la cola.
            {
                Console.WriteLine(item);  
            }
            Console.ReadKey();

            
        }

        public void obtenerElementosExtraidosDeCola()
        {
            var elementoEstraido2 = cola.Dequeue();  //Dequeue es para extraer.
            Console.WriteLine("Elemento extraido: " + elementoEstraido2);
            Console.ReadKey();
        }

        public void obtenerElementosSinSerExtraidosDeCola()
        {
            var elementoEstraido2 = cola.Peek();  //Solo se consulta quien será atendido.
            Console.WriteLine("Primer elmento: " + elementoEstraido2);
            Console.ReadKey();
        }
    }
}
