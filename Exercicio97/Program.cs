/*97) Refaça o exercício 91, só que agora em forma de função Maior(), mas faça uma 
adaptação que vai receber TRÊS números como parâmetro e vai retornar qual foi o 
maior entre eles.*/


int num1, num2, num3;

Console.WriteLine("Digite o primeiro número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
num3 = Convert.ToInt32(Console.ReadLine());

static int Maior(int num1, int num2, int num3)
{
   if (num1 > num2)
    {
        if(num1 > num3)
        {
            return num1;
        }
        else
        {
            return num3;
        }
    }
    else
    {
        if (num2 > num3)
        {
            return num2;
        }
        else
        {
            return num3;
        }
    }
}
Console.WriteLine(Maior(num1, num2, num3));