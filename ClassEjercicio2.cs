using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiadeEjercicios
{
    class ClassEjercicio2
    {
        public static void showSquareCubed()
        {
            int numero = 0;
            string auxiliar = "";
            double resultadoCuadrado = 0;
            double resultadoCubo = 0;

            Console.WriteLine("Ingrese un numero para elevarlo al cuadrado y al cubo");

            auxiliar=Console.ReadLine();

            while(!int.TryParse(auxiliar,out numero) && numero<0)
            {
                Console.WriteLine("Ingrese un numero mayor a 0 para elevarlo al cuadrado y al cubo");

                auxiliar = Console.ReadLine();
            }
            resultadoCuadrado=Math.Pow(numero, 2);
            resultadoCubo = Math.Pow(numero, 3);
            Console.WriteLine("El resultado de elevar el numero al cuadrado es " + resultadoCuadrado);
            Console.WriteLine("El resultado de elevar el numero al cubo es " + resultadoCubo);
        }
    }
}
