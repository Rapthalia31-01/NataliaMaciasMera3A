using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Pila
{
    class TDA_PILA
    {

        static void Main(string[] args)
        {
            Stack miPila = new Stack();
            int opcion;
            do
            {
                Console.Clear();
                opcion = menu();
                switch (opcion)
                {
                    case 1:
                        Apilar(ref miPila);
                        break;
                    case 2:
                        Desapilar(ref miPila);
                        break;
                    case 3:
                        Vaciar(ref miPila);
                        break;
                    case 4:
                        imprimir( miPila);
                        break;
                    case 5:
                        break; 
                    default:
                        mensaje("ERROR: la opción no es valida. Intente de nuevo.");
                        break;
                }
            }
            while (opcion != 5);
            mensaje("El programa a finalizado.");
        }


        static void Apilar (ref Stack pila)
        {

            int n, num = 0, ero;
          
                Console.WriteLine("ingrese total de numeros");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("ingrese numeros enteros");
                    ero = int.Parse(Console.ReadLine());

                    pila.Push(ero);

                    if (ero % 2 == 0)
                    {
                        num++;
                    }
             
                }
                Console.WriteLine("Total de numeros pares son: " + num);
                pila.Push(num);
                imprimir(pila);
            }

           
        
        

            static void Vaciar (ref Stack pila)
        {
            pila.Clear();
            imprimir(pila);
        }

        static void Desapilar(ref Stack pila)
        {
            if (pila.Count > 0)
            {
                int num = (int)pila.Pop();
                mensaje("Elemento " + num + " eliminado");
            }
            else
            {
                imprimir(pila);
            }
        }

        static int menu()
        {
            //Console.Clear();

            Console.WriteLine("Ingreso al Stack Menu \n"
                        + "(1) Apilar elemento - push\n" +
                        "(2) Desapilar elemento -pop \n" +
                        "(3) Preguntar si pila esta vacia - isEmpty\n" +
                        "(4) Imprimir Toda ED \n" +
                        "(5) Salir del programa \n");
            Console.WriteLine("Ingrese la opción a elegir: ");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                return num;
            }
            catch
            {
                return 0;
            }
        }

        static void mensaje(String texto)
        {
            if (texto.Length > 0)
            {
                Console.WriteLine("\n    --------------------");
                Console.WriteLine(" :> {0}", texto);
                Console.WriteLine("--------------------------");
                Console.WriteLine("\n  Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        /*Imprime pila */
        static void imprimir(Stack pila)
        {
            if (pila.Count > 0)
            {
                Console.WriteLine("  ");
                foreach (int dato in pila)
                {
                    Console.WriteLine(" ");
                    if (dato < 10)
                        Console.WriteLine(" 0{0} ", dato);
                    else
                        Console.WriteLine("  {0} ", dato);
                    Console.WriteLine("     ");
                }
                Console.WriteLine("\nPresione cualquier tecla para continuar ...");
                Console.ReadKey();
            }
            else
            {
                mensaje("La Pila esta vacia");
            }
        }
    }
}

