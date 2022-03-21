//9) Crie um algoritmo que leia o nome e as duas notas de um aluno, calcule a sua 
//média e mostre na tela. No final, analise a média e mostre se o aluno teve ou 
//não um bom aproveitamento (se ficou acima da média 7.0).


string nome;
double nota1, nota2;

Console.WriteLine("Digite o nome do aluno: ");
nome = Console.ReadLine();

Console.WriteLine("Digite a primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2) / 2;

if(media >= 7.0)
{
    Console.WriteLine("Parabéns, você foi aprovado com média " + media + ".");
}
else
{
    Console.WriteLine("Infelizmente você reprovou com média " + media + ".");
}