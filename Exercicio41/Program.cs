//41) Desenvolva um programa que mostre na tela a seguinte contagem: 100 95 90 85 80... 0 Acabou!

int num = 100;

while (num >= 0)
{
    Console.WriteLine(num);
    num = num - 5;
}
Console.WriteLine("Acabou!");