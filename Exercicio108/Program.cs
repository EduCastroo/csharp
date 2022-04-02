/* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/


int inteirosLidos, dentro = 0, fora = 0;

Console.WriteLine("Digite a quantidade de números que serão lidos: ");
inteirosLidos = Convert.ToInt32(Console.ReadLine());

int[] valores = new int[inteirosLidos];

for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine("Digite o "+(i+1)+"º número inteiro: ");
    valores[i] = Convert.ToInt32(Console.ReadLine());
}

foreach (int valor in valores)
{
    if(valor >=10 && valor <= 20)
    {
        dentro++;
    }
    else
    {
        fora++;
    }
}
Console.WriteLine(dentro + " in");
Console.WriteLine(fora + " out");