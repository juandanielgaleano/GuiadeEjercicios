using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiadeEjercicios
{
    class ClassEjercicio1
    {
        public static void showMinMaxAve (int numero)
        {
            int max = 0;
            string auxiliar="";
            int min = 0;
            float Average = 0;
            int counter = 0;
            int accumulator = 0;

            for(counter=0;counter<5;counter++)
            {
                Console.WriteLine("Ingrese un numero");
                auxiliar = Console.ReadLine();
                while (!int.TryParse(auxiliar, out numero))
                {
                    Console.WriteLine("Ingrese un numero");
                    auxiliar=Console.ReadLine();
                }
                if(counter==0)
                {
                    max = numero;
                    min = numero;

                }
                else
                {
                    if(numero<min)
                    {
                        min = numero;
                    }
                    if(numero>max)
                    {
                        max = numero;
                    }
                }
                accumulator = accumulator + numero;

            }
            Average = accumulator / 5;
            Console.WriteLine("El numero maximo es " + max);
            Console.WriteLine("El numero minimo es " + min);
            Console.WriteLine("El promedio de los numeros ingresados es " + Average);

        }
    }
}
