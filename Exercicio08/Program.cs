//8) Desenvolva um programa que leia uma distância em metros e mostre os valores relativos em outras medidas.
//Ex: 
//Digite uma distância em metros: 185.72
//A distância de 85.7m corresponde a:
//0.18572Km
//1.8572Hm
//18.572Dam
//1857.2dm
//18572.0cm
//185720.0mm

double distMetros;

Console.WriteLine("Digite uma distância em metros: ");
distMetros = Convert.ToDouble(Console.ReadLine());

double distKm = (distMetros / 1000);
double distHm = (distMetros / 100);
double distDam = (distMetros / 10);
double distDm = (distMetros * 10);
double distCm = (distMetros * 100);
double distMm = (distMetros * 1000);
Console.WriteLine("A distância de " + distMetros + " metros " + " corresponde a :" );
Console.WriteLine(distKm + "Km");
Console.WriteLine(distHm + "Hm");
Console.WriteLine(distDam + "Dam");
Console.WriteLine(distDm + "Dm");
Console.WriteLine(distCm + "Cm");
Console.WriteLine(distMm + "Mm");