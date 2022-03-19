//29) Desenvolva um programa que leia o nome de um funcionário, seu salário,
//quantos anos ele trabalha na empresa e mostre seu novo salário, reajustado de
//acordo com a tabela a seguir:
//-Até 3 anos de empresa: aumento de 3%
//- entre 3 e 10 anos: aumento de 12.5%
//- 10 anos ou mais: aumento de 20%

string nome;
double salario;
int tempoEmpresa;

Console.WriteLine("Digite o nome do funcionário: ");
nome = Console.ReadLine();

Console.WriteLine("Digite o salário do funcionário: ");
salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite quantos anos o funcionário trabalha na empresa: ");
tempoEmpresa = Convert.ToInt32(Console.ReadLine());


//FÓRMULA % = (valor * porcentagem)/100
double aumentoMin = (salario * 3) / 100;
double aumentoMed = (salario * 12.5) / 100;
double aumentoMax = (salario * 20) / 100;

if (tempoEmpresa <= 3)
{
    Console.WriteLine("O seu novo salário com aumento de 3% é: R$" + (salario + aumentoMin));
}
else if (tempoEmpresa >= 10)
{
    Console.WriteLine("O seu novo salário com aumento de 20% é: R$" + (salario + aumentoMax));
}
else
{
    Console.WriteLine("O seu novo salário com aumento de 12.5% é: R$" + (salario + aumentoMed));
}