﻿// 67) Faça um programa usando a estrutura “para” que leia um número inteiro 
//positivo e mostre na tela uma contagem de 0 até o valor digitado:
//Ex: Digite um valor: 9
//Contagem: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, FIM!




int num = 0;
Console.WriteLine("Digite um número inteiro positivo para contar até ele: ");
num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    Console.Write(i + ",");
}
Console.WriteLine("FIM!");   