//24) Faça um algoritmo que pergunte a distância que um passageiro deseja 
//percorrer em Km. Calcule o preço da passagem, cobrando R$0.50 por Km para 
//viagens até 200Km e R$0.45 para viagens mais longas.

double distPerc;

Console.WriteLine("Digite a distância percorrida: ");
distPerc = Convert.ToDouble(Console.ReadLine());

double passagemCurta = (distPerc * 0.50);
double passagemLonga = (distPerc * 0.45);

if(distPerc <= 200)
{
    Console.WriteLine("O preço da passagem é: R$" + passagemCurta + ",00");
}
else{
    Console.WriteLine("O preço da passagem é: R$" + passagemLonga + ",00");
}
