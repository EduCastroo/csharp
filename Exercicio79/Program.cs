// 79) Desenvolva um programa que leia 10 números inteiros e guarde-os em um vetor. 
//No final, mostre quais são os números pares que foram digitados e em que 
//posições eles estão armazenados.

int[] numeros = new int[10];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Digite o " + (i + 1) + "º número inteiro: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int indice in numeros)
{
    Console.Write("|" + indice);
}
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine("O número " + numeros[i] + " na posição " + i + " é PAR!");  
    }
}
