﻿// 72) Crie um programa que preencha automaticamente (usando lógica, não apenas 
//atribuindo diretamente) um vetor numérico com 10 posições, conforme abaixo:
//5 10 15 20 25 30 35 40 45 50
//0 1 2 3 4 5 6 7 8 9;


int[] lista = new int[10];

for (int i = 0; i < 10; i++)
{
    lista[i] = 5*(i+1);
    Console.Write("|" + lista[i]);
}