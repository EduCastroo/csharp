//13) Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o 
//seu novo salário, com 15% de aumento.


double valor;

Console.WriteLine("Digite o salário do funcionário: ");
valor = Convert.ToDouble(Console.ReadLine());

double percentual = 15 / 100.0;
double valor_final = valor + (percentual * valor);

Console.WriteLine("O valor final do salário com aumento de 15% é: " +
  valor_final);
