using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, numCuenta, numCuenta2;
            int click = 1, click2 = 1, op;
            double consignacion,saldo,retiro;

            Console.WriteLine("Registrar cliente ");
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Numero de cuenta: ");
            numCuenta = Console.ReadLine();
            Console.WriteLine("Saldo inicial: ");
            saldo =  double.Parse(Console.ReadLine());

            do
            {


                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("Numero de cuenta: ");
                numCuenta2 = Console.ReadLine();

                if (numCuenta == numCuenta2)
                {
                    click2 = 1;
                    do
                    {
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("Escoja una opcion ");
                        Console.WriteLine("1.Consignar ");
                        Console.WriteLine("2.Retirar ");
                        Console.WriteLine("3.Ver saldo ");
                        Console.WriteLine("4.Salir");

                        Console.WriteLine("   opcion:  ");
                        op = int.Parse(Console.ReadLine());

                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("¿Cuanto desea consignar?: ");
                                consignacion = double.Parse(Console.ReadLine());
                                saldo = saldo + consignacion;
                                Console.WriteLine("se han consignado: " + consignacion);

                                ; break;
                            case 2:
                                Console.WriteLine("¿Cuanto desea retirar?: ");
                                retiro = double.Parse(Console.ReadLine());
                                if (retiro > saldo)
                                {
                                    Console.WriteLine("no es posible hacer el retiro\nEl monto del retiro es mayor al saldo");
                                }
                                else
                                {
                                    saldo = saldo - retiro;
                                    Console.WriteLine("se han retirado: " + retiro);
                                }

                                   ; break;
                            case 3:

                                Console.WriteLine("Su saldo es de: " + saldo);

                                ; break;
                            case 4:
                                click = 2;
                                ; break;

                        }

                    } while (click == 1);
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("El numero de cuenta no existe");
                    click2 = 2;
                }

            } while (click2 == 2);


        }
    }
}
