//35) Uma empresa de aluguel de carros precisa cobrar pelos seus serviços. O
//aluguel de um carro custa R$90 por dia para carro popular e R$150 por dia para
//carro de luxo. Além disso, o cliente paga por Km percorrido. Faça um programa
//que leia o tipo de carro alugado (popular ou luxo), quantos dias de aluguel e
//quantos Km foram percorridos. No final mostre o preço a ser pago de acordo com a
//tabela a seguir:
//-Carros populares(aluguel de R$90 por dia)
//- Até 100Km percorridos: R$0,20 por Km
//- Acima de 100Km percorridos: R$0,10 por Km
//- Carros de luxo (aluguel de R$150 por dia)
//-Até 200Km percorridos: R$0,30 por Km
//- Acima de 200Km percorridos: R$0,25 por Km


int carro, dias, km;

Console.WriteLine("Para alugar um CARRO POPULAR (digite: 1) / CARRO DE LUXO (digite: 2) : ");
carro = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de dias alugados: ");
dias = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite quantos Km foram percorridos: ");
km = Convert.ToInt32(Console.ReadLine());

int carPop = dias * 90;
int carLux = dias * 150;

if ((carro == 1) && (km <= 100))
{
    Console.WriteLine("TOTAL a pagar = " + (carPop + km*0.20));
}if ((carro == 1)&&(km > 100)&&(km < 200))
{
    Console.WriteLine("TOTAL a pagar = " + (carPop + km * 0.10));
}
if ((carro == 2)&&(km <= 200))
{
    Console.WriteLine("TOTAL a pagar = " + (carLux + km * 0.30));
}if ((carro == 2)&&(km > 200))
{
    Console.WriteLine("TOTAL a pagar = " + (carLux + km * 0.25));
}