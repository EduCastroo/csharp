//83) [DESAFIO] Crie uma lógica que preencha um vetor de 20 posições com números 
//aleatórios(entre 0 e 99) gerados pelo computador. Logo em seguida, mostre os 
//números gerados e depois coloque o vetor em ordem crescente, mostrando no final 
//os valores ordenados.

int[] numeros = new int[20];
Random num = new Random();
int maior = 0;

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = num.Next(0, 99);
}
foreach (int i in numeros)
{
    Console.Write("|" + i);
}
Array.Sort(numeros);
Console.WriteLine();
foreach (int i in numeros)
{
    Console.Write("|" + i);
}


//83) [DESAFIO] Crie uma lógica que preencha um vetor de 20 posições com números 
//aleatórios(entre 0 e 99) gerados pelo computador. Logo em seguida, mostre os 
//números gerados e depois coloque o vetor em ordem crescente, mostrando no final 
//os valores ordenados.

/*int[] numeros = new int[20];
Random num = new Random();
int maior = 0, aux = 0;

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = num.Next(0, 99);
}
foreach (int i in numeros)
{
    Console.Write("|" + i);
}
// Array.Sort(numeros);


for (int j = 0; j < numeros.Length; j++)
{
    // verificar ordem crescente
    for (int i = 0; i < (numeros.Length - 1); i++)
    {

        if (numeros[i] > numeros[i + 1])
        {
            aux = numeros[i];
            numeros[i] = numeros[i + 1];
            numeros[i + 1] = aux;
        }
    }

}

Console.WriteLine();
foreach (int i in numeros)
{
    Console.Write("|" + i);
}
*/