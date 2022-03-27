// 75) Crie um programa que preencha automaticamente (usando lógica, não apenas 
//atribuindo diretamente) um vetor numérico com 15 posições com os primeiros 
//elementos da sequência de Fibonacci:

//1 1 2 3 5 8 13 21 34 55 89 144 233 377 610
//0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15

int[] lista = new int[15];

int num = 0, num2 = 1, aux;

for (int i = 0; i < 15; i++)
{
	if (i == 0)
    {
		lista[i] = 1;
    }
    else
    {
        aux = num;
        num = num2;
        num2 = num + aux;
        lista[i] = num2;
    }
	
}
foreach (int i in lista)
{
    Console.Write("|" + i);
}