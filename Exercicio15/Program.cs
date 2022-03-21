//15) Crie um programa que leia o número de dias trabalhados em um mês e mostre o 
//salário de um funcionário, sabendo que ele trabalha 8 horas por dia e ganha R$25 
//por hora trabalhada.

int diasTrab;
int valorDia = 200;

Console.WriteLine("Digite a quantidade de dias trabalhados: ");
diasTrab = Convert.ToInt32(Console.ReadLine());


int salario = (diasTrab * valorDia);
Console.WriteLine("O valor do salário é: " + salario);
