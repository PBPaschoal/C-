﻿/* Aula 52 Exercício Beecrowd - 1074 Par ou Ímpar
 * Leia um valor inteiro N. Este valor será a quantidade de valores que serão lidos em seguida. 
 * Para cada valor lido, mostre uma mensagem em inglês dizendo se este valor lido é par (EVEN), 
 * ímpar (ODD), positivo (POSITIVE) ou negativo (NEGATIVE). No caso do valor ser igual a zero (0), 
 * embora a descrição correta seja (EVEN NULL), pois por definição zero é par, seu programa deverá imprimir apenas NULL.
 * 
 * Entrada
 * A primeira linha da entrada contém um valor inteiro N(N < 10000) que indica o número de casos de teste. 
 * Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).
 * 
 * Saída
 * Para cada caso, imprima uma mensagem correspondente, de acordo com o exemplo abaixo. Todas as letras 
 * deverão ser maiúsculas e sempre deverá haver um espaço entre duas palavras impressas na mesma linha.
 * 
 * Exemplo de Entrada	                Exemplo de Saída
 * 4                                    ODD NEGATIVE
 * -5                                   NULL
 * 0                                    ODD POSITIVE
 * 3                                    EVEN NEGATIVE
 * -4 */

using System;

namespace Program {  
    internal class Program { 
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++) {
                int value = int.Parse(Console.ReadLine());
                if(value % 2 == 0) {
                    if (value > 0) {
                        Console.WriteLine("EVEN POSITIVE");
                    } else if (value < 0) {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                } if(value == 0) {
                    Console.WriteLine("NULL");
                } else if(value % 2 != 0) { 
                    if(value > 0) {
                        Console.WriteLine("ODD POSITIVE");
                    } else if(value < 0) {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
        }
    }
}