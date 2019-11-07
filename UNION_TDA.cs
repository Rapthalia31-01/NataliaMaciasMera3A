using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UNION_TDA
{
    class UNION_TDA
    {
        static void Main(string[] args)
        {

            int op = 0;

            NodoPilaCola mipilacola = null;

            Console.WriteLine("Escoja cualquiera de las opciones a ejecutar:\n"
                        + "1) Pila  \n"
                        + "2) Cola \n");
            int op0 = int.Parse(Console.ReadLine());



            do
            {
                Console.WriteLine("Ingrese opción \n"
                         + "1) Crear  \n"
                         + "2) Apilar - Encolar \n" +
                         "3) Desapilar - Desencolar\n" +
                         "4) Cima\n" +
                         "5) Preguntar si la estructura de datos esta vacia \n" +
                         "6) Imprimir Toda La estructura de datos \n" +
                         "7) Salir \n");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        mipilacola = NodoPilaCola.Crear(mipilacola);
                        break;
                    case 2:
                        mipilacola = NodoPilaCola.APilarEncolar(mipilacola);
                        break;
                    case 3:
                        mipilacola = NodoPilaCola.DesapilarDesencolar(mipilacola, op0);
                        break;
                    case 4:
                        NodoPilaCola.ImprimirCima(mipilacola);
                        break;
                    case 5:
                        NodoPilaCola.estaVacia(mipilacola);
                        break;
                    case 6:
                        NodoPilaCola.Imprimir(mipilacola);
                        break;

                }
            } while (op != 7);

        }
    }
}
