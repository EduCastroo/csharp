/*
Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau
Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara (veja 
abaixo). Se a equação não possuir raízes (o valor de "a" não pode ser zero, e o valor de "delta" não pode ser 
negativo), mostrar uma mensagem "Impossivel calcular". */

double a, b, c, delta;

Console.WriteLine("Digite o valor de A: ");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor de B: ");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor de C: ");
c = Convert.ToDouble(Console.ReadLine());

delta = ((b*b) - (4*a*c));
double raiz = Math.Sqrt(delta);

double x1 = ((-b) + raiz)/(2 * a);
double x2 = ((-b) - raiz)/(2 * a);

if (delta >= 0 && a > 0)
{
    Console.WriteLine("DELTA = " + delta);
    Console.WriteLine("X1 = " + Math.Round(x1, 5));
    Console.WriteLine("X2 = " + Math.Round(x2, 5));
    
}
else
{
    Console.WriteLine("IMPOSSÍVEL CALCULAR!! (DELTA < 0)");
}


