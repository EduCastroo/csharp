/* 94) [DESAFIO] Desenvolva um aplicativo que tenha um procedimento chamado 
Fibonacci() que recebe um único valor inteiro como parâmetro, indicando quantos 
termos da sequência serão mostrados na tela. O seu procedimento deve receber 
esse valor e mostrar a quantidade de elementos solicitados.
Obs: Use os exercícios 70 e 75 para te ajudar na solução
Ex: 
Fibonacci(5) vai gerar 1 >> 1 >> 2 >> 3 >> 5 >> FIM
Fibonacci(9) vai gerar 1 >> 1 >> 2 >> 3 >> 5 >> 8 >> 13 >> 21 >> 34 >> FIM*/



static void Fibonacci(int termo)
{
	int aux = 0, num = 0, num2 = 1;
	for (int i = 0; i < termo; i++)
	{
		Console.Write(num2 + " >> ");
		aux = num2;
		num2 += num;
		num = aux;
		
	}
    Console.Write(" FIM");
}
Fibonacci(9);