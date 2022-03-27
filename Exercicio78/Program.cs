// 78) Escreva um programa que leia 15 números e guarde-os em um vetor. No final, 
//mostre o vetor inteiro na tela e em seguida mostre em que posições foram 
//digitados valores que são múltiplos de 10.


int[] numeros = new int[15];


for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Digite um número inteiro: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int indice in numeros)
{
    Console.Write("|" + indice);
    Console.WriteLine("");
}
for (int i = 0; i < numeros.Length; i++)
{
    if(numeros[i] % 2 == 0)
    {
        Console.WriteLine("Multiplo de 10 na posição " + i);
    }
}