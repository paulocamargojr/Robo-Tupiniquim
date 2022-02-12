using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            Console.WriteLine("Insira a primeira coordenada:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a segunda coordenada:");
            int y = Convert.ToInt32(Console.ReadLine());

            do
            {

                Console.WriteLine("Insira a posição inicial do robo(Separe as coordenadas e a visão do robô por espaço):");
                string posicaoInicial = Console.ReadLine();
                char[] coordenadasIniciais = posicaoInicial.ToCharArray();

                int posicaoInicialX = (int)Char.GetNumericValue(coordenadasIniciais[0]);
                int posicaoInicialY = (int)Char.GetNumericValue(coordenadasIniciais[2]);
                char visao = Convert.ToChar(coordenadasIniciais[4]);

                if (posicaoInicialX > x || posicaoInicialY > y)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Essas coordenadas não existem!Tente novamente");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;

                }

                if (visao != 'N' && visao != 'S' && visao != 'O' && visao != 'L')
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro! Informe N, S, O ou L");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;

                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sucesso!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Insira um comando para o robo:");
                    string comando = Console.ReadLine();
                    char[] comandos = comando.ToCharArray();

                    for (int j = 0; j < comandos.Length; j++)
                    {

                        if (comandos[j] == 'M' && visao == 'N')
                        {

                            /*Caso o comando exceda o retangulo o robo ficara na ultima casa disponivel e não avançará mais.*/
                            if (!(posicaoInicialY == y))
                            {

                                posicaoInicialY++;

                            }
                            else
                            {

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Incapaz de continuar nessa direção!");
                                Console.ForegroundColor = ConsoleColor.White;

                            }


                        }
                        else if (comandos[j] == 'M' && visao == 'L')
                        {

                            if (!(posicaoInicialX == x))
                            {

                                posicaoInicialX++;

                            }
                            else
                            {

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Incapaz de continuar nessa direção!");
                                Console.ForegroundColor = ConsoleColor.White;

                            }


                        }
                        else if (comandos[j] == 'M' && visao == 'S')
                        {

                            if (posicaoInicialY > 0)
                            {

                                posicaoInicialY--;

                            }
                            else
                            {

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Incapaz de continuar nessa direção!");
                                Console.ForegroundColor = ConsoleColor.White;

                            }


                        }
                        else if (comandos[j] == 'M' && visao == 'O')
                        {

                            if (posicaoInicialX > 0)
                            {

                                posicaoInicialX--;

                            }
                            else
                            {

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Incapaz de continuar nessa direção!");
                                Console.ForegroundColor = ConsoleColor.White;

                            }


                        }
                        else if (comandos[j] == 'E' && visao == 'N')
                        {

                            visao = 'O';

                        }
                        else if (comandos[j] == 'E' && visao == 'L')
                        {

                            visao = 'N';

                        }
                        else if (comandos[j] == 'E' && visao == 'S')
                        {

                            visao = 'L';

                        }
                        else if (comandos[j] == 'E' && visao == 'O')
                        {

                            visao = 'S';

                        }
                        else if (comandos[j] == 'D' && visao == 'N')
                        {

                            visao = 'L';

                        }
                        else if (comandos[j] == 'D' && visao == 'L')
                        {

                            visao = 'S';

                        }
                        else if (comandos[j] == 'D' && visao == 'S')
                        {

                            visao = 'O';

                        }
                        else if (comandos[j] == 'D' && visao == 'O')
                        {

                            visao = 'N';

                        }

                    }

                    Console.WriteLine(posicaoInicialX + " " + posicaoInicialY + " " + visao);

                }

                k++;

            } while (k < 2);

            Console.ReadKey();
        }
    }
}
