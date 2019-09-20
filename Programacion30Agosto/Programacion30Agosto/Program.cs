using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion30Agosto
{
    class Program
    {
        static void Main(string[] args)
        {
            Listas miNuevaLista = new Listas();

            miNuevaLista.cargar("Hola Mundo");
            miNuevaLista.cargar("mundo");  //Este pasa al índice 2.
            miNuevaLista.cargarElementosPrIndice(1, "Hola Mundo"); //Este pasa al indice 1
            miNuevaLista.imprimir();
            miNuevaLista.imprimirConteo();
            miNuevaLista.buscarInfo("Hola Mundo");

            //Listas tipo colección.
            List<EstudianteColeccionList> nEstudiante = new List<EstudianteColeccionList>();
            nEstudiante.Add(new EstudianteColeccionList { codigo = 1, nombres = "Roberto", apellidos = "Martín", fechaDeNacimiento = Convert.ToDateTime("20190906"), identificacion = "1823278" });
            nEstudiante.Add(new EstudianteColeccionList { codigo = 2, nombres = "José", apellidos = "Villanoba", fechaDeNacimiento = Convert.ToDateTime("20190906"), identificacion = "1823279" });

            Console.WriteLine("Elementos de la colección elementos: " + nEstudiante.Count());
        }

        
        

    }


}

