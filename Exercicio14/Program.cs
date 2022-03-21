//14) A locadora de carros precisa da sua ajuda para cobrar seus serviços. Escreva 
//um programa que pergunte a quantidade de Km percorridos por um carro alugado e a 
//quantidade de dias pelos quais ele foi alugado. Calcule o preço total a pagar,
//sabendo que o carro custa R$90 por dia e R$0,20 por Km rodado.

double Km = 0.20;
int aluguelDia = 90;
double KmRodados;
int diasAlugados;


Console.WriteLine("Qual foi a quantidade de Km percorridos? ");
KmRodados = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual foi a quantidade de dias alugados? ");
diasAlugados = Convert.ToInt32((Console.ReadLine()));

double valorAluguel = ((Km * KmRodados) + (aluguelDia * diasAlugados));

Console.WriteLine("O valor a ser pago pelo aluguel é:  " + valorAluguel);



