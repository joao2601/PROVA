using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace prova

{
    internal class Program
    {
        static void Main(string[] args)
        {





            //EX1
            //1. [1 ponto] Escreva um programa que leia um número inteiro e imprima seu valor absoluto(sem sinal), utilizando
            // uma estrutura if-else
            //        float num;
            //Console.WriteLine("Digite um numero");
            //num = float.Parse(Console.ReadLine());
            //if (num < 0)
            //{
            //    num = num * -1;
            //    Console.WriteLine(num);
            //}
            //else
            //    Console.WriteLine(num);







            // EX2. [1 ponto] Escreva um programa em C# que leia um número inteiro e verifique se ele é múltiplo de 3 e 5 ou de 4 e
            //7.Caso não seja, verifique também se esse número é divisível por cada um dos anteriores individualmente(3, 4, 5
            //ou 7). Por fim, caso não seja divisível por nenhuma das opções anteriores, mostre uma mensagem avisando o
            //usuário sobre essa impossibilidade de divisão.


            //int num;
            //Console.WriteLine("Digite um numero inteiro");
            //num = int.Parse(Console.ReadLine());

            //if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("o numero " + num + " é divisivel de 3 e 5");
            //}
            //else if (num % 4 == 0 && num % 7 == 0)
            //{

            //    Console.WriteLine("o numero " + num + " é multiplo de 4 e 7");
            //}

            //else if (num % 3 == 0)

            //{
            //    Console.WriteLine("O numero " + num + " e divisivel por 3");
            //}
            //else if (num % 7 == 0)
            //{
            //    Console.WriteLine("O numero " + num + " e divisivel por 7");
            //}
            //else if (num % 4 == 0)
            //{
            //    Console.WriteLine("O numero " + num + " e divisivel por 4");
            //}
            //else if (num % 5 == 0)
            //{
            //    Console.WriteLine("O numero " + num + " e divisivel por 5");
            //}

            //else Console.WriteLine("o numero " + num +" nao é valido");






            //. EX 3 [1 ponto] Escreva um programa que leia três números inteiros e imprima o maior deles utilizando uma estrutura ifelse

            //int num1, num2, num3;
            //Console.WriteLine("Digite o primeiro numero");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo numero");
            //num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o terceiro numero");
            //num3 = int.Parse(Console.ReadLine());


            //if (num1 > num2 & num2 > num3)
            //{
            //    Console.WriteLine("o maior numero e o numero" + num1);
            //}
            //else if (num2 > num1 & num1 > num3)
            //{
            //    Console.WriteLine("o maior numero e o numero" + num2);
            //}   
            //else if (num3 > num2 & num2 > num1)
            //{
            //    Console.WriteLine("o maior numero e o numero" + num3);
            //}
            //else Console.WriteLine("numero invalido");







            //    4        1 ponto] Utilizando a estrutura switch, escreva um programa em C# que a partir da entrada de um número de 1 a
            //7, informe na tela quais são as disciplinas que você assiste em cada dia da semana. Considere que o dia 1 é o
            //domingo. Caso o dia escolhido seja no fim de semana, apresente uma mensagem informando sobre o que gosta de
            //fazer aos finais de semana (pode inventar). Caso a entrada seja um número que não represente um dia da semana,
            //informe ao usuário que não é válida. 

            //Console.Write("Digite um número correspondente a um dia da semana 1 a 7: ");
            //int dia = int.Parse(Console.ReadLine());

            //switch (dia)
            //{
            //    case 1:
            //        Console.WriteLine("Domingo gosto de fazer o que eu faço no sabado");
            //        break;
            //    case 2:
            //        Console.WriteLine("Segunda-feira: Filosofia, Portugues e matematica");
            //        break;
            //    case 3:
            //        Console.WriteLine("Terça-feira: Quimica, Historia e IMI");
            //        break;
            //    case 4:
            //        Console.WriteLine("Quarta-feira: Biologia, Portugues e PR2");
            //        break;
            //    case 5:
            //        Console.WriteLine("Quinta-feira: Fisica, RDC e Sociologia ");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sexta-feira:Geografia, Matematica e Banco de dados");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sábado gosto de fazer nada");
            //        break;
            //    default:
            //        Console.WriteLine("Número inválido! Digite um número de 1 a 7.");
            //        break;
            //}




            //            5. [2 pontos] Escreva um programa em C# que leia uma sequência de números inteiros e imprima o maior e o menor
            //número da sequência. A sequência deve ser lida até que o usuário digite o número zero.
            int num1, num2, num3;
          
            //Console.WriteLine(" a sequencia e de tres numeros, digite o primeiro");
            //num1 = int.Parse(Console.ReadLine());


            //Console.WriteLine(" a sequencia e de tres numeros, digite o segundo");
            //num2 = int.Parse(Console.ReadLine());


            //Console.WriteLine(" a sequencia e de tres numeros, digite o terceiro");
            //num3 = int.Parse(Console.ReadLine());

            //if (num1 > num2 && num2 < num3)
            //{
            //    Console.WriteLine("o maior numero é " + num1 + " e o menor numero é" + num2);   
            //}
            //else if (num2 > num1 && num1 > num3)
            //{
            //    Console.WriteLine("o maior numero é " + num2 + " e o menor numero é" + num3);
            //}
            //else if (num3 > num2 & num2 > num1)
            //{
            //    Console.WriteLine("o maior numero é " + num3 + " e o menor numero é" + num1);
            //}

            //       EX6     Escreva um programa em C# que leia um número inteiro e verifique se ele é um número perfeito. Um
            //número perfeito é aquele que é igual à soma de seus divisores próprios(ou seja, seus divisores excluindo-o). Por
            //exemplo, o número 6 é perfeito, pois seus divisores próprios são 1, 2 e 3, e 1 + 2 + 3 = 6.

            //int i, num, somadivisao;
            //Console.WriteLine("digite um numero ");
            //num = int.Parse(Console.ReadLine());

            //for (i = 0; i <= num / 2; i++)
            //{
            //    if (num % i == 0) {
            //        somadivisao += i;
            //    }
            //}
            //if (somadivisao == num)
            //{
            //    Console.WriteLine(num +" é um numero perfeito");
            //}
            //else
            //{
            //    Console.WriteLine(num + " nao é um numero perfeito");
            //}

            //            7. [2 pontos] Escreva um programa em C# que leia uma sequência de números inteiros e imprima a média aritmética
            //dos números pares da sequência. A sequência deve ser lida até que o usuário digite o número zero.Caso não haja
            //números pares na sequência, o programa deve imprimir uma mensagem informando que não foi possível calcular
            //a média.


            //int num,num1,num2, num3, num4, num5, sequenciaNum, numPar, media;

            //Console.WriteLine("digite o primioro numero da sequencia de 6 numeros");
            //num = int.Parse(Console.ReadLine());


            //Console.WriteLine("digite o segundo numero da sequencia de 6 numeros");
            //num1 = int.Parse(Console.ReadLine());


            //Console.WriteLine("digite o terceiro numero da sequencia de 6 numeros");
            //num2 = int.Parse(Console.ReadLine());


            //Console.WriteLine("digite o quartonumero da sequencia de 6 numeros");
            //num3 = int.Parse(Console.ReadLine());


            //Console.WriteLine("digite o quintonumero da sequencia de 6 numeros");
            //num4 = int.Parse(Console.ReadLine());


            //Console.WriteLine("digite o sexto numero da sequencia de 6 numeros");
            //num5 = int.Parse(Console.ReadLine());


            //if (num == 0 || num1 == 0 || num2 == 0 || num3 == 0 || num4 == 00 || num5 == 00)
            //{
            //    Console.WriteLine("programa finalizado");     

            //}

            //else if (num % 2 == 0 && num1 % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0 && num4 % 2 == 0 && num5 % 2 == 0)
            //{
            //    media = num + num1 + num2 + num3 + num4 + num5 / 6;
            //    Console.WriteLine(" a media e " + media);
            //}
            //else if (num1 % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0 && num4 % 2 == 0 && num5 % 2 == 0)
            //{
            //    media = num1 + num2 + num3 + num4 + num5 / 5;
            //    Console.WriteLine(" a media e " + media);
            //}

            //else if (num % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0 && num4 % 2 == 0 && num5 % 2 == 0)
            //{
            //    media = num + num2 + num3 + num4 + num5 / 5;
            //    Console.WriteLine(" a media e " + media);
            //}


            //else if (num % 2 == 0 && num1 % 2 == 0 && num3 % 2 == 0 && num4 % 2 == 0 && num5 % 2 == 0)
            //{
            //    media = num1 + num1 + num3 + num4 + num5 / 5;
            //    Console.WriteLine(" a media e " + media);
            //}

            //else if (num % 2 == 0 && num2 % 2 == 0 && num1 % 2 == 0 && num4 % 2 == 0 && num5 % 2 == 0)
            //{
            //    media = num1 + num2 + num1 + num4 + num5 / 5;
            //    Console.WriteLine(" a media e " + media);
            //}

            //else if (num % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0 && num1 % 2 == 0 && num5 % 2 == 0)
            //{
            //    media = num1 + num2 + num3 + num1 + num5 / 5;
            //    Console.WriteLine(" a media e " + media);
            //}

            //else if (num % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0 && num4 % 2 == 0 && num1 % 2 == 0)
            //{
            //    media = num1 + num2 + num3 + num4 + num1 / 5;
            //    Console.WriteLine(" a media e " + media);
            //}



        }
    }
}
