// 70) [DESAFIO] Faça um programa que mostre os
//      10 primeiros elementos da Sequência de Fibonacci: 1 1 2 3 5 8 13 21...

int num = 0, num2 = 1, aux;

for (int i = 0; i < 10; i++)
{
	aux = num;
	num = num2;
	num2 = num + aux;
    Console.WriteLine(num2);
}















/* int num1=0, num2=1, aux;

		for (int i = 0; i​​​​​​​ < 60; i++)
		{
			aux=num1;
			num1 = num2;
			num2 = num1 + aux;
			Console.WriteLine("{0}", num2);

		}
*/