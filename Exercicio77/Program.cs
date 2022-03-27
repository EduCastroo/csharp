// 77) Faça um programa que leia 7 nomes de pessoas e guarde-os em um vetor. No 
//final, mostre uma listagem com todos os nomes informados, na ordem inversa 
//daquela em que eles foram informados.


string[] nomes = new string[7];

for (int i = 0; i < 7; i++)
{
    Console.WriteLine("Digite o nome da " + (i+1) + "ª pessoa: ");
    nomes[i] = Console.ReadLine();
    
}

foreach (string indice in nomes)
{
    Console.Write("|" + indice);
}
Console.WriteLine("");
for (int i = 6; i >= 0; i--)
{
    Console.Write("|" + nomes[i]);
}


