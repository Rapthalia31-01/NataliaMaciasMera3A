using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Cola
{
    class TDA_COLA
    {
        static void Main(string[] args)
        {


            Queue miCola = new Queue();
            int opcion;
                do
                {
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                opcion = menu();
                switch (opcion)
                {
                    case 1:
                        Encolar( ref miCola);
                        break;
                    case 2:
                        EstaVaciaCola(ref miCola);
                        break;
                    case 3:
                        Desencolar(ref miCola);
                        break;
                    case 4:
                        Imprimir(miCola);
                        break;
                    case 6:
                        EstaVaciaCola(ref miCola);
                        break;
                    case 7:
                        
                        break;
                    default:
                        mensaje("ERROR: la opción no es valida. Intente de nuevo.");
                        break;

                }
            } while (opcion != 5);
     
                mensaje("El programa a finalizado.");
            }


            static void Encolar(ref  Queue cola)
            {

                int n, num = 0, ero;

                Console.WriteLine("ingrese total de numeros");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("ingrese numeros enteros");
                    ero = int.Parse(Console.ReadLine());

                    cola.Enqueue(ero);

                    if (ero % 2 == 1)
                    {
                        num++;
                    }

                }
                Console.WriteLine("Total de numeros pares son: " + num);
                cola.Enqueue(num);
                Imprimir(cola);
            }





            static void EstaVaciaCola(ref Queue cola)
            {
                cola.Clear();
                Imprimir(cola);
            }

            static void Desencolar(ref Queue cola)
            {
                if (cola.Count > 0)
                {
                    int num = (int)cola.Dequeue();
                    mensaje("Elemento " + num + " eliminado");
                }
                else
                {
                    Imprimir(cola);
                }
            }

            static int menu()
            {
            //Console.Clear();

            Console.WriteLine("Ingrese opción \n"
                    + "(1) Crear Cola \n"
                    + "(2) Encolar - enqueue\n" +
                    "(3) Desencolar - dequeue \n" +
                    "(4) Cima-fondo\n" +
                    "(5) Cabecera-frente\n" +
                    "(6) Preguntar si cola esta vacia - isEmpty\n" +
                    "(7) Imprimir Toda ED \n" +
                    "(8) Salir \n");
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
                    Console.WriteLine("\n    -------");
                    Console.WriteLine(" :> {0}", texto);
                    Console.WriteLine("--------------");
                    Console.WriteLine("\n    :> Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }

            /** Imprime pila */
            static void Imprimir(Queue cola)
            {
                if (cola.Count > 0)
                {
                    Console.WriteLine("");
                    foreach (int dato in cola)
                    {
                        Console.WriteLine(" ");
                        if (dato < 10)
                            Console.WriteLine("  0{0} ", dato);
                        else
                            Console.WriteLine("  {0} ", dato);
                        Console.WriteLine("      ");
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

