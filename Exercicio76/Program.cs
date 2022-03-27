// 76) Crie um programa que preencha automaticamente um vetor numérico com 7
// números gerados aleatoriamente pelo computador e depois mostre os valores 
// gerados na tela.


int[] lista = new int[7];
Random num = new Random();

for (int i = 0; i < lista.Length; i++ )
{
lista[i] = num.Next(100);
Console.Write(lista[i] + "|");
}

