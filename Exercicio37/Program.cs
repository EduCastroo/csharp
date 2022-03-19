/*37) Uma empresa precisa reajustar o salário dos seus funcionários, dando um
aumento de acordo com alguns fatores. Faça um programa que leia o salário atual,
o gênero do funcionário e há quantos anos esse funcionário trabalha na empresa.
No final, mostre o seu novo salário, baseado na tabela a seguir:
-Mulheres
- menos de 15 anos de empresa: +5 %
-de 15 até 20 anos de empresa: +12 %
-mais de 20 anos de empresa: +23 %
-Homens
- menos de 20 anos de empresa: +3 %
-de 20 até 30 anos de empresa: +13 %
-mais de 30 anos de empresa: +25 %*/


int sexo, anos, salario;

Console.WriteLine("Qual o gênero do funcionário? Digite 1 para MULHER ou Digite 2 para HOMEM: ");
sexo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantos anos o funcionário trabalha na empresa: ");
anos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o salário do funcionário");
salario = Convert.ToInt32(Console.ReadLine());

int aumentoM5 = (salario * 5) / 100;
int aumentoM12 = (salario * 12) / 100;
int aumentoM23 = (salario * 23) / 100;

int aumentoH3 = (salario * 3) / 100;
int aumentoH13 = (salario * 13) / 100;
int aumentoH25 = (salario * 25) / 100;

if ((sexo == 1)&&(anos < 15))
{
    Console.WriteLine("Seu novo salário com aumento de 5% é: R$" + (salario + aumentoM5));
}if((sexo == 1)&&(anos >= 15)&&(anos <= 20))
{
    Console.WriteLine("Seu novo salário com aumento de 12% é: R$" + (salario + aumentoM12));
}if((sexo == 1)&&(anos > 20))
{
    Console.WriteLine("Seu novo salário com aumento de 23% é: R$" + (salario + aumentoM23));
}if((sexo == 2)&&(anos < 20))
{
    Console.WriteLine("Seu novo salário com aumento de 3% é: R$" + (salario + aumentoH3));
}if((sexo == 2)&&(anos >= 20)&&(anos <= 30))
{
    Console.WriteLine("Seu novo salário com aumento de 13% é: R$" + (salario + aumentoH13));
}if((sexo == 2)&&(anos > 30))
{
    Console.WriteLine("Seu novo salário com aumento de 25% é: R$" + (salario + aumentoH25));
}