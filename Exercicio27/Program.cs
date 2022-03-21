//27) Crie um programa que leia duas notas de um aluno e calcule a sua média,
//mostrando uma mensagem no final, de acordo com a média atingida:
// -Média até 4.9: REPROVADO
//- Média entre 5.0 e 6.9: RECUPERAÇÃO
//- Média 7.0 ou superior: APROVADO


double nota1;
double nota2;

Console.WriteLine("Digite a PRIMEIRA nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a SEGUNDA nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2) / 2;

if(media <= 4.9)
{
    Console.WriteLine("REPROVADO");
}if (media > 7.0)
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("RECUPERAÇÃO");
}