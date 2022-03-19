//36) Um programa de vida saudável quer dar pontos atividades físicas que podem
//ser trocados por dinheiro. O sistema funciona assim:
//-Cada hora de atividade física no mês vale pontos
//- até 10h de atividade no mês: ganha 2 pontos por hora *
//- de 10h até 20h de atividade no mês: ganha 5 pontos por hora
//- acima de 20h de atividade no mês: ganha 10 pontos por hora
//- A cada ponto ganho, o cliente fatura R$0,05 (5 centavos)
//Faça um programa que leia quantas horas de atividade uma pessoa teve por mês,
//calcule e mostre quantos pontos ela teve e quanto dinheiro ela conseguiu ganhar.



int horasTreino;

Console.WriteLine("Quantas horas você treinou esse mês? ");
horasTreino = Convert.ToInt32(Console.ReadLine());

int pontos2 = horasTreino * 2;
int pontos5 = horasTreino * 5;
int pontos10 = horasTreino * 10;
double reais2 = pontos2 * 0.05;
double reais5 = pontos5 * 0.05;
double reais10 = pontos10 * 0.05;


if (horasTreino <= 10)
{
    Console.WriteLine("Você treinou " + horasTreino + " hr este mês");
    Console.WriteLine("Você juntou " + pontos2 + " pts este mês");
    Console.WriteLine("Você juntou R$" + reais2 + " este mês");
}if((horasTreino > 10) && (horasTreino <= 20))
{
    Console.WriteLine("Você treinou " + horasTreino + " hr este mês");
    Console.WriteLine("Você juntou " + pontos5 + " pts este mês");
    Console.WriteLine("Você juntou R$" + reais5 + " este mês");
}if(horasTreino > 20)
{
    Console.WriteLine("Você treinou " + horasTreino + " hr este mês");
    Console.WriteLine("Você juntou " + pontos10 + " pts este mês");
    Console.WriteLine("Você juntou R$" + reais10 + " este mês");
}