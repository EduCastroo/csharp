//11) Desenvolva uma lógica que leia os valores de A, B e C de uma equação do 
//segundo grau e mostre o valor de Delta.

double A;
double B;
double C;

Console.WriteLine("Digite o valor de A: ");
A = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor de B: ");
B = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor de C: ");
C = Convert.ToDouble(Console.ReadLine());

double delta = ((B * B) - 4 * A * C);
Console.WriteLine("O valor de delta = " + delta);