//28) Faça um programa que leia a largura e o comprimento de um terreno 
//retangular, calculando e mostrando a sua área em m². O programa também 
//devemostrar a classificação desse terreno, de acordo com a lista abaixo:
// -Abaixo de 100m² = TERRENO POPULAR
//- Entre 100m² e 500m² = TERRENO MASTER
//- Acima de 500m² = TERRENO VIP

int largura, comprimento;

Console.WriteLine("Digite a LARGURA do terreno: ");
largura = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o COMPRIMENTO do terreno: ");
comprimento = Convert.ToInt32(Console.ReadLine());

int areaTerreno = (largura * comprimento);

if (areaTerreno < 100)
{
    Console.WriteLine("TERRENO POPULAR (Menos de 100m²)");
}
else if (areaTerreno > 500)
{
    Console.WriteLine("TERRENO VIP (Mais de 500m²)");
}
else
{
    Console.WriteLine("TERRENO MASTER (Entre 100m² e 500m²)");
}

