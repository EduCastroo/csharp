// 80) Faça um algoritmo que preencha um vetor de 30 posições com números entre 1 e 
//15 sorteados pelo computador. Depois disso, peça para o usuário digitar um 
//número (chave) e seu programa deve mostrar em que posições essa chave foi 
//encontrada. Mostre também quantas vezes a chave foi sorteada.


int[] numeros = new int[30];
int var = 0, chave;
Random num = new Random();


for (int i = 0; i < numeros.Length; i++)
{
	numeros[i] = num.Next(1, 15);
}
Console.WriteLine("Digite um número: ");
chave = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numeros.Length; i++)
{
    if (chave != numeros[i])
    {
		Console.WriteLine(numeros[i]);
    }
    else
    {
		Console.WriteLine("O número está na posição " + i + ".");
		var++;
    }
	if (var > 1)
    {
		Console.WriteLine("O número digitado foi sorteado " + var + "veze.");
    }
    else
    {
        Console.WriteLine("O número digitado foi sorteado " + var + " vez.");
    }
}
