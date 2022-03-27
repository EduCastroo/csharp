/*92) Crie uma lógica que leia um número inteiro e passe para um procedimento
ParOuImpar() que vai verificar e mostrar na tela se o valor passado como 
parâmetro é PAR ou ÍMPAR.*/

int num1;

Console.WriteLine("Digite o primeiro número: ");
num1 = Convert.ToInt32(Console.ReadLine());

static void ParOuImpar(int num1)
{
    if(num1 % 2 == 0)
    {
        Console.WriteLine("O número " + num1 + " é PAR!");
    }
    else
    {
        Console.WriteLine("O número " + num1 + " é ÍMPAR!");
    }
}
ParOuImpar(num1);