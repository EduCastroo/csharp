// 58) Faça um algoritmo que leia a idade de vários alunos de uma turma. O programa 
//vai parar quando for digitada a idade 999. No final, mostre quantos alunos 
//existem na turma e qual é a média de idade do grupo.


int idade = 0, cont = 0, soma = 0, media = 0;

Console.WriteLine("Digite a idade dos alunos ou 999 para sair do programa: ");

idade = Convert.ToInt32(Console.ReadLine());

while (idade != 999)
{
    Console.WriteLine("Digite a idade dos alunos ou 999 para sair do programa: ");
    soma += idade;
    cont += 1;
    media = soma / cont;
    idade = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Existem " + cont + " alunos na turma!!");
Console.WriteLine("A média de idade do grupo é: " + media);