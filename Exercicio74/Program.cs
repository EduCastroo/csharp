//74) Crie um programa que preencha automaticamente (usando lógica, não apenas 
//atribuindo diretamente) um vetor numérico com 10 posições, conforme abaixo:
//5 3 5 3 5 3 5 3 5 3
//0 1 2 3 4 5 6 7 8 9

int[] lista = new int[10];

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        lista[i] = 5;
    }else
    {
        lista[i] = 3;
    }
}

foreach(int i in lista)
{
    Console.Write("|" + i);
}

