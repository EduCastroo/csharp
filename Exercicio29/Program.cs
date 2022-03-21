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

Console.WriteLine("Digite o tempo de empresa do funcionário: ");
tempoEmpresa = Convert.ToInt32(Console.ReadLine());

double reajMin = 3/100;
double reajMed = 12.5/100;
double reajMax = 20/100;

double aumentoMin =  salario + (reajMin * salario);
double aumentoMed =  salario + (reajMed * salario);
double aumentoMax =  salario + (reajMax * salario);

if (tempoEmpresa < 3)
{
    Console.WriteLine("Você recebeu um aumento de 3%, seu novo salário é: " + aumentoMin);
}else if (tempoEmpresa > 10)
{
    Console.WriteLine("Você recebeu um aumento de 20%, seu novo salário é: " + aumentoMax);
}
else
{
    Console.WriteLine("Você recebeu um aumento de 12.5%, seu novo salário é: " + aumentoMed);
}