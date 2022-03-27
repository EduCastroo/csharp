//69) [DESAFIO] Desenvolva um programa que leia o primeiro termo e a razão de uma 
//PA(Progressão Aritmética), mostrando na tela os 10 primeiros elementos da PA e 
//a soma entre todos os valores da sequência.

int primeiro, razao, numTermo = 9, ultiTermo, soma = 0;


Console.WriteLine("Digite o pimeiro termo: ");
primeiro = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a razão: ");
razao = Convert.ToInt32(Console.ReadLine());

//ultiTermo = primeiro + ((numTermo - 1) * razao);

for (int progressao = 0; progressao <= numTermo; progressao++)
{
	primeiro += razao;
	Console.WriteLine(primeiro);

}


//TODO - Add Soma