using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            double val = 0;
            int menu, lanche, bebida, tudo=0, egg=0, sal=0, bau=0, coca=0, guara=0, soda=0, fanta=0;
        
            do
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA DE LANCHONETE\n");
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1-LANCHES");
                Console.WriteLine("2-BEBIDAS");
                Console.WriteLine("3-CONTA");
                Console.WriteLine("0-SAIR");
                menu = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("MENU LANCHES");
                            Console.WriteLine("1-X-TUDO R$ 10,00");
                            Console.WriteLine("2-X-EGG R$  7,00");
                            Console.WriteLine("3-X-SALADA R$ 6,00");
                            Console.WriteLine("4-BAURU R$ 5,00");
                            Console.WriteLine("0-VOLTAR");
                            lanche = int.Parse(Console.ReadLine());
                            switch (lanche)
                            {
                                case 1:
                                    val = val + 10.00;
                                    Console.Clear();
                                    tudo++;
                                    break;
                                case 2:
                                    val = val + 7.00;
                                    Console.Clear();
                                    egg++;
                                    break;
                                case 3:
                                    val = val + 6.00;
                                    Console.Clear();
                                    sal++;
                                    break;
                                case 4:
                                    val = val + 5.00;
                                    Console.Clear();
                                    bau++;
                                    break;
                            }
                        } while (lanche != 0);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("MENU BEBIDAS");
                            Console.WriteLine("1-COCA-COLA R$ 8,00");
                            Console.WriteLine("2-GUARANÁ R$ 8,00");
                            Console.WriteLine("3-SODA-LIMONADA R$ 6,00");
                            Console.WriteLine("4-FANTA R$ 6,00");
                            Console.WriteLine("0-VOLTAR");
                            bebida = int.Parse(Console.ReadLine());
                            switch (bebida)
                            {
                                case 1:
                                    val = val + 8.00;
                                    Console.Clear();
                                    coca++;
                                    break;
                                case 2:
                                    val = val + 8.00;
                                    Console.Clear();
                                    guara++;
                                    break;
                                case 3:
                                    val = val + 6.00;
                                    Console.Clear();
                                    soda++;
                                    break;
                                case 4:
                                    val = val + 6.00;
                                    Console.Clear();
                                    fanta++;
                                    break;
                            }
                        } while (bebida != 0);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("PRODUTO:         QTDE:        VALOR:");
                        Console.WriteLine("X-TUDO           {0}             {1},00", tudo, tudo*10);
                        Console.WriteLine("X-EGG            {0}             {1},00", egg, egg*7);
                        Console.WriteLine("X-SALADA         {0}             {1},00", sal, sal*6);
                        Console.WriteLine("BAURU            {0}             {1},00", bau, bau*5);
                        Console.WriteLine("COCA-COLA        {0}             {1},00", coca, coca*8);
                        Console.WriteLine("GUARANÁ          {0}             {1},00", guara, guara*8);
                        Console.WriteLine("SODA-LIMONADA    {0}             {1},00", soda, soda*6);
                        Console.WriteLine("FANTA            {0}             {1},00", fanta, fanta*6);
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("TOTAL:                         {0},00", val);
                        Console.ReadKey();
                        break;
                }
            } while (menu != 0);
        }
    }
}
