using System;

namespace L16_RAMS_1018822
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] numero = new int[40, 50];
            int sumapositivos = 0;
            int sumanegativos = 0;
            Console.WriteLine("");

            for (int a=0; a<40; a++)
            {
                for (int b=0; b<50; b++)
                {
                    numero[a, b] = (int)(rnd.Next(-50, 50));
                }
            }
            for(int a=0; a<40; a++)
            {
                for(int b=0; b<50; b++)
                {
                    Console.WriteLine(numero[a, b] + "\t");
                }
            }

            for (int a = 0; a<40; a++)
            {
                for(int b=0; b<50; b++)
                {
                    if (numero[a,b]>0)
                    {
                        sumapositivos = sumapositivos + numero[a, b];
                    }
                    else
                    {
                        sumanegativos = sumanegativos + numero[a, b];
                    }
                }
            }
            Console.WriteLine("La suma de los numeros posisitvos es: "+sumapositivos);
            Console.WriteLine("La suma de los numeros negativos es: "+sumanegativos);
        }
    }
}
