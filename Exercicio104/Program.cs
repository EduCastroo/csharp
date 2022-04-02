/*
PARTE 1: ESTRUTURA SEQUENCIAL
Faça um programa para ler o valor do raio de um círculo, 
e depois mostrar o valor da área deste círculo com quatro 
casas decimais conforme exemplos.
Fórmula: area = pi * raio ^ 2 */


double raio;

Console.WriteLine("Digite o raio para descobrir a área da circunferência: ");
raio = Convert.ToDouble(Console.ReadLine());

double area = 3.14159 * (raio * raio);

Console.WriteLine("ÁREA = " + Math.Round(area, 4));