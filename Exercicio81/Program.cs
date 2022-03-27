// 81) Crie um programa que leia a idade de 8 pessoas e guarde-as em um vetor. No 
//final, mostre:
//a) Qual é a média de idade das pessoas cadastradas
//b) Em quais posições temos pessoas com mais de 25 anos
//c) Qual foi a maior idade digitada (podem haver repetições)
//d) Em que posições digitamos a maior idade


int[] idade = new int[8];
int maiorIdade = 0;


for (int i = 0; i < 8; i++) { 

    Console.WriteLine("Digite a idade da " + (i+1) + "ª pessoa: ");
    idade[i] = Convert.ToInt32(Console.ReadLine());
}foreach (int id in idade) {
    Console.Write("|" + id);
    Console.WriteLine();
}
int media = (idade[0] + idade[1] + idade[2] + idade[3] + idade[4] + idade[5] + idade[6] + idade[7]) / 8;
Console.Write("A média das idades digitadas é: " + media);

for (int i = 0; i < 8; i++)
{
    if (idade[i] > 25)
    {
        Console.WriteLine("Temos pessoas com mais de 25 anos na posição " + i);
    }
    if(idade[i] > maiorIdade)
    {
        maiorIdade = idade[i];
        Console.WriteLine("A maior idade digitada foi: " + maiorIdade);
        Console.WriteLine("A maior idade foi digitada no indice: " + i);
    }
}


