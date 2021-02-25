using System;

namespace população
{
    class minhaClasse
    {

        static void Main(string[] args)
        {

            int t = 1;

            int anos;

            int pa, pb;

            double g1, g2;


            for (int i = 0; i < t; i++)

            {
                Console.WriteLine("Digite o número da população a atualmente: ");
                pa = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o número da população b atualmente: ");
                pb = int.Parse(Console.ReadLine());

                anos = 0;
                Console.WriteLine("Digite quantos % a população a cresce anualmente (apenas os números)");
                g1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos % a população b cresce anualmente (apenas os números)");
                g2 = double.Parse(Console.ReadLine());

                while (pa <= pb)
                {
                   pa += (int)((pa*g1)/100); //(int) Dessa forma int pode receber double
                   pb += (int)((pb*g2)/100); //(int) Dessa forma int pode receber double
                    anos++;
                    if (anos > 100)

                    {
                        Console.WriteLine("Mais de 1 século.");
                        break;
                    }
                }
                if (anos <= 100)
                {
                    Console.WriteLine("{0} anos.", anos);
                }
            }
        }
    }
}
