using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPR21Bim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Questao1

            int numero;

            Console.WriteLine("Escreva um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("É um numero inteiro absoluto");
                numero++;
            }
            else if (numero == 1)
            {
                Console.WriteLine("Não é um numeiro inteiro absoluto");
                numero--;
            }
            Console.ReadLine();

            //Questao2
            {
                float numerointeiro;

                Console.WriteLine("Entre com um valor qualquer: ");
                numerointeiro = float.Parse(Console.ReadLine());

                if (numerointeiro * 3 == 0 && numerointeiro * 4 == 0 && numerointeiro * 5 == 0)
                {
                    Console.WriteLine("O número {0} é multiplo por 3 por 4 e por 5.", numerointeiro);
                }
                else
                {
                    if (numerointeiro * 3 == 0)
                    {
                        Console.WriteLine("O número {0} é multiplo apenas por 3.", numerointeiro);
                    }
                    else
                    {
                        if (numerointeiro * 5 == 0)
                        {
                            Console.WriteLine("O número {0} é multiplo apenas por 4.", numerointeiro);
                        }
                        else
                        if (numerointeiro * 3 == 0)
                        {
                            Console.WriteLine("O número {0} é multiplo apenas por 5", numerointeiro);
                        }
                        
                    }
                    Console.WriteLine("Entre com um valor qualquer: ");
                    numerointeiro = float.Parse(Console.ReadLine());

                    if (numerointeiro % 3 == 0 && numerointeiro % 4 == 0 && numerointeiro % 5 == 0)
                    {
                        Console.WriteLine("O número {0} é divisível por 3 por 4 e por 5.", numerointeiro);
                    }
                    else
                    {
                        if (numerointeiro % 3 == 0)
                        {
                            Console.WriteLine("O número {0} é divisível apenas por 3.", numerointeiro);
                        }
                        else
                        {
                            if (numerointeiro % 5 == 0)
                            {
                                Console.WriteLine("O número {0} é divisível apenas por 4.", numerointeiro);
                            }
                            else
                            if (numerointeiro % 3 == 0)
                            {
                                Console.WriteLine("O número {0} é divisível apenas por 5", numerointeiro);
                            }
                        }
                        Console.ReadKey();

                        //Questao3

                        {
                            int numinteiro;
                            Console.WriteLine("Digite um número inteiro");
                            numinteiro = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite um número inteiro");
                            numinteiro = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite um número inteiro");
                            numinteiro = int.Parse(Console.ReadLine());

                            if (numinteiro >= 0)
                            {
                                Console.WriteLine("O numero inteiro maior é: ", numinteiro);
                            }
                            else if (numerointeiro >= 0)
                            {
                                Console.WriteLine("O número maoir é: ", numinteiro);
                            }
                            else if(numerointeiro <= 0)
                            {
                                Console.WriteLine("O numero inteiro maoir é:", numinteiro);
                            }
                                   
                        }

                        //Questao4

                        int diasdasemana;
                        int materias;
   

                        Console.WriteLine("Digite um dia da semana");
                         diasdasemana = int.Parse(Console.ReadLine());

                        switch (diasdasemana)
                        {
                            case '1':
                                materias = diasdasemana;
                                Console.WriteLine("Não tem aula e Domingo");
                                break;                          
                            
                            case '2':
                                materias = diasdasemana;
                                Console.WriteLine("As materias do dia são {aulasdodia}");
                                break;

                            case '3':
                                materias = diasdasemana;
                                Console.WriteLine("As materias do dia são {aulasdodia}");
                                break;

                            case '4':
                                materias = diasdasemana;
                                Console.WriteLine("As materias do dia são {aulasdodia}");
                                break;

                            case '5':
                                materias = diasdasemana;
                                Console.WriteLine("As materias do dia são {aulasdodia}");
                                break;
                            
                            case '6':
                                materias = diasdasemana;
                                Console.WriteLine("As materias do dia são {aulasdodia}");
                                break;
                            
                            case '7':
                                materias = diasdasemana;
                                Console.WriteLine("Não tem aula é Sabado");
                                break;

                        }

                    }
                }

                  //Questao5
                {
                    int v1, v2;
                    Console.WriteLine("Digite dois valores inteiros:");
                    string[] input = Console.ReadLine().Split(' ');

                    v1 = int.Parse(input[1]);
                    v2 = int.Parse(input[2]);

                    int menor = v1;
                    if (v2 < menor) menor = v2;

                    int maior = v1;
                    if (v2 > maior) maior = v2;

                    Console.WriteLine("Os valore em ordem são: {menor}, {maior}");
                }

            }
        }
    }
}
