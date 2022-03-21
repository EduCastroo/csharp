//10) Faça um algoritmo que leia a largura e altura de uma parede, calcule e 
//mostre a área a ser pintada e a quantidade de tinta necessária para o serviço,
//sabendo que cada litro de tinta pinta uma área de 2metros quadrados.


double largura;
double altura;

Console.WriteLine("Digite a largura da parede: ");
largura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a altura da parede: ");
altura = Convert.ToDouble(Console.ReadLine());

double areaPint = (largura * altura);

Console.WriteLine("A área a ser pintada é igual a: " + areaPint + "m²");

double tintaNesc = (areaPint / 2);

Console.WriteLine("Será necessário " + tintaNesc + " litros de tinta para pintar a parede.");
