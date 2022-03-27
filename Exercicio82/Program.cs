// 82) Faça um algoritmo que leia a nota de 10 alunos de uma turma e guarde-as em um vetor.No final, mostre: 
//a) Qual é a média da turma
//b) Quantos alunos estão acima da média da turma
//c) Qual foi a maior nota digitada
//d) Em que posições a maior nota aparece

int[] notas = new int[10];
int maiorNota = 0;
int media = 0, cont = 0;

for (int i = 0; i < 10; i++) {
    Console.WriteLine("Digite a " + (i + 1) + "ª nota: ");
    notas[i] = Convert.ToInt32(Console.ReadLine());
}foreach (int indice in notas)
{
    Console.Write("|" + indice);
    Console.WriteLine();
}
foreach(int indice in notas)
{
    media += indice;
}

media /= 10;
Console.Write("A média das notas digitadas é: " + media);

//b) Quantos alunos estão acima da média da turma
for (int i = 0; i < 10; i++)
{
    if (notas[i] > media)
    {
        cont++;
    }
}
Console.WriteLine(cont + " alunos estão acima da média!");

//c) Qual foi a maior nota digitada
//d) Em que posições a maior nota aparece

for (int i = 0; i < 10; i++)
{
    if (notas[i] > maiorNota)
    {
        maiorNota = notas[i];   
        Console.WriteLine("A maior nota digitada foi: " + maiorNota + " no indice " + i);
    }
}