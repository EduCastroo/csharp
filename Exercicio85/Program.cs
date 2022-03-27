// 85) Faça um algoritmo que leia o nome, o sexo e o salário de 5 funcionários e 
//guarde esses dados em três vetores. No final, mostre uma listagem contendo 
//apenas os dados das funcionárias mulheres que ganham mais de R$5 mil.


string[] nome = new string[2];
string[] sexo = new string[2];
int[] salario = new int[2];

Console.WriteLine("Digite o nome, o sexo e o salário de 5 funcionários (Pressione Enter)");

for (int i = 0; i < nome.Length; i++)
{
    Console.WriteLine("Digite o nome: ");
    nome[i] = Console.ReadLine();

    Console.WriteLine("Digite a sexo (M/F): ");
    sexo[i] = Console.ReadLine();

    Console.WriteLine("Digite o salário: ");
    salario[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < nome.Length; i++)
{
    if(sexo[i] == "F" && salario[i] > 5000)
    {
        Console.WriteLine("As mulheres que ganham mais de R$5000,00 são: ");
        Console.WriteLine("Nome: " + nome[i] + " e Salário: " + salario[i]);
    }
}