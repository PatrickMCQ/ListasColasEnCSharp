using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionColas
{
    class Program
    {
        static void Main(string[] args)
        {
            misColas nuevaCola = new misColas();
            nuevaCola.agregarEnCola("elemento 01");
            nuevaCola.agregarEnCola("elemento 02");
            nuevaCola.agregarEnCola("elemento 03");
            nuevaCola.agregarEnCola("elemento 04");
            nuevaCola.imprimir();
            nuevaCola.obtenerElementosExtraidosDeCola();
            nuevaCola.imprimir();
            nuevaCola.obtenerElementosSinSerExtraidosDeCola();
            nuevaCola.imprimir();
        }
    }
}
