using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNION_TDA
{
    public class NodoPilaCola
    {
        int dato;
        NodoPilaCola frente;
        NodoPilaCola siguiente;
        NodoPilaCola cima;

        public NodoPilaCola(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }

        public static NodoPilaCola Crear(NodoPilaCola pilacola)

        {
            Console.WriteLine("Ingrese elemento a guardar");
            int valor = int.Parse(Console.ReadLine());
            pilacola = new NodoPilaCola(valor);
            pilacola.frente = pilacola.cima = pilacola;


            return pilacola;
        }
        public static NodoPilaCola APilarEncolar(NodoPilaCola pilacola)
        {

            //CASO 1: Pila no ha sido instanciada, o, pila nula
            if (pilacola == null)
            {
                Console.WriteLine("La estructura de datos no ha sido creada... escoja opción 1");
                return pilacola;
            }


            Console.WriteLine("Ingrese elemento a guardar");
            int valor = int.Parse(Console.ReadLine());
            NodoPilaCola nodoNuevo = new NodoPilaCola(valor);

            NodoPilaCola aux = pilacola;
            for (; aux.siguiente != null; aux = aux.siguiente) ;
            aux.siguiente = nodoNuevo;
            pilacola.cima = nodoNuevo;

            return pilacola;
        }
        public static NodoPilaCola DesapilarDesencolar(NodoPilaCola pilacola, int op0)
        {
            //CASO 1: Pila no ha sido instanciada, o, pila nula
            if (pilacola == null)
            {
                Console.WriteLine("La estructura de datos no ha sido creada... escoja opción 1");
                return pilacola;
            }
            //Caso 2: que solo exista nodo
            if (pilacola.siguiente == null)
            {
                Console.WriteLine("Elemento: " + pilacola.dato);
                return pilacola.siguiente;//return null;
            }

            if (op0 == 2)
            {
                //CASO 1: Pila no ha sido instanciada, o, pila nula
                if (pilacola == null)
                {
                    Console.WriteLine("La estructura de datos no ha sido creada... escoja opción 1");
                    return pilacola;
                }

                Console.WriteLine("Elemento: " + pilacola.dato);
                pilacola = pilacola.siguiente;

                return pilacola;//return null;


            }
            else
            {


                //Caso 3 donde hay 2 o más nodos
                NodoPilaCola aux = pilacola;
                for (; aux.siguiente.siguiente != null; aux = aux.siguiente) ;
                Console.WriteLine("Elemento: " + aux.siguiente.dato);
                aux.siguiente = aux.siguiente.siguiente;
                pilacola.cima = aux;
                return pilacola;

            }

        }

        public static void Imprimir(NodoPilaCola miPila)
        {
            if (miPila == null)
                Console.WriteLine("La estructura de datos no ha sido creada... escoja opción 1");
            for (NodoPilaCola aux = miPila; aux != null; aux = aux.siguiente)
                Console.WriteLine("Dato:" + aux.dato + "\n");
        }

        public static void ImprimirCima(NodoPilaCola miPila)
        {
            //CASO 1: Pila no ha sido instanciada, o, pila nula
            if (miPila == null)
                Console.WriteLine("La estructura de datos no ha sido creada... escoja opción 1");
            else

                Console.WriteLine("Cima: " + miPila.cima.dato + "\n");


        }


        public static void estaVacia(NodoPilaCola miPila)
        {
            //CASO 1: Pila no ha sido instanciada, o, pila nula
            if (miPila == null)
                Console.WriteLine("La estructura de datos esta vacia");
            else
                Console.WriteLine("La estructura de datos no esta vacia");
        }

    }
}
