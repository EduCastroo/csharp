// 84) Crie um programa que leia o nome e a idade de 9 pessoas e guarde esses 
//valores em dois vetores, em posições relacionadas. No final, mostre uma listagem 
//contendo apenas os dados das pessoas menores de idade.

string[] nome = new string[2];
int[] idade = new int[2];

Console.WriteLine("Digite o nome de 9 pessoas e suas respectiva idades (Pressione Enter)");

for (int i = 0; i < nome.Length; i++)
{
    Console.WriteLine("Digite o nome: ");
    nome[i] = Console.ReadLine();

    Console.WriteLine("Digite a idade: ");
    idade[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < nome.Length; i++)
{
    if (idade[i] < 18)
    {
        Console.WriteLine("Nome: " + nome[i] + " e Idade: "+ idade[i]);
    }
}