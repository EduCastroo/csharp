/* 99) Faça um programa que possua uma função chamada Potencia(), que vai receber 
dois parâmetros numéricos (base e expoente) e vai calcular o resultado da 
exponenciação.
Ex: Potencia(5,2) vai calcular 52 = 25 */

double bas, exp;

static double Potencia(double bas, double exp)
{
    double resultado = Math.Pow(bas, exp);
 return resultado;
}
Console.WriteLine(Potencia(5,2));