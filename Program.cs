using System;

namespace ejerc_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nf; 
             
            Console.WriteLine("Bienvenido al Programa para hallar el factorial de un numero");
            Console.ReadKey();

            do{
                Console.Clear();
                Console.WriteLine("Ingrese 0 para salir del Programa");    
                Console.WriteLine("Ingrese un Numero para hallar su Factorial: ");
                n = Convert.ToInt32(Console.ReadLine());

                if(n != 0)
                {
                    nf = 1;

                    for(int i = 1; i < n+1 ; i++)
                    {
                        nf = nf * i;
                    }

                Console.WriteLine("El numero Factorial de " + n +" es: " + nf);
                Console.ReadKey();
                }
 
            } while(n != 0);
        }
    }
}