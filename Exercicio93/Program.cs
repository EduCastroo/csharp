/*93) Faça um programa que tenha um procedimento chamado Contador() que recebe 
três valores como parâmetro: o início, o fim e o incremento de uma contagem. O
programa principal deve solicitar a digitação desses valores e passá-los ao 
procedimento, que vai mostrar a contagem na tela.*/

int inicio, fim, incremento;

Console.WriteLine("Digite o INICIO: ");
inicio = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o FIM: ");
fim = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o INCREMENTO: ");
incremento = Convert.ToInt32(Console.ReadLine());


static void Contador(int inicio, int fim, int incremento)
{
    for(int i = inicio ; i <= fim; i += incremento)
    {
        Console.Write(i + " >> ");
    }
    Console.Write(" FIM");
}

Contador(inicio, fim, incremento);