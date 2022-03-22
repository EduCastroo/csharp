// 57) Desenvolva um aplicativo que leia o salário e o sexo de vários funcionários. 
//No final, mostre o total de salários pagos aos homens e o total pago às 
//mulheres. O programa vai perguntar ao usuário se ele quer continuar ou não 
//sempre que ler os dados de um funcionário.

int salario, parar = 1, somaHomem = 0, somaMulher = 0, cont = 0;
string sexo;

Console.WriteLine("Digite 0 para CONTINUAR ou 1 para PARAR: ");
parar = Convert.ToInt32(Console.ReadLine());

while (parar == 0)
{

    Console.WriteLine("Digite o SALÁRIO do funcionário: ");
    salario = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o SEXO do funcionário [M = Masculino] ou [F =  Feminino]: ");
    sexo = Console.ReadLine();

    Console.WriteLine("Digite 0 para CONTINUAR ou 1 para PARAR: ");
    parar = Convert.ToInt32(Console.ReadLine());

    if(sexo == "M")
    {
        somaHomem = somaHomem + salario;
    }
    if(sexo == "F")
    {
        somaMulher = somaMulher + salario;
    }
    

}

Console.WriteLine("O total de salário pago aos HOMENS é: " + somaHomem);
Console.WriteLine("O total de salário pago as MULHERES é: " + somaMulher);





