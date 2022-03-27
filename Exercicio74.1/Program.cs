// 74) Crie um programa que preencha automaticamente (usando lógica, não apenas 
// 3 5 3 5 3 5 3 5 3
//0 1 2 3 4 5 6 7 8 9

int[] lista = new int[10];

int aux = 0;

while (aux < 10)
{
    if (aux == 0)
    {
        lista[aux] = 3;
    }
    if (lista[aux] == 3)
    {
        lista[aux] = 5;
    }
    aux++;
}
foreach (int i in lista)
{
    Console.WriteLine(i);
}