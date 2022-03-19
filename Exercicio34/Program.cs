//34) O Índice de Massa Corpórea (IMC) é um valor calculado baseado na altura e no
//peso de uma pessoa. De acordo com o valor do IMC, podemos classificar o
//indivíduo dentro de certas faixas.
//- abaixo de 18.5: Abaixo do peso
//- entre 18.5 e 25: Peso ideal
//- entre 25 e 30: Sobrepeso
//- entre 30 e 40: Obesidade
//- acima de 40: Obseidade mórbida

double peso, altura;

Console.WriteLine("Digite seu peso: ");
peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua altura: ");
altura = Convert.ToDouble(Console.ReadLine());

double imc = (peso / (altura*altura));

if(imc <= 18.5)
{
    Console.WriteLine("ABAIXO DO PESO! - IMC: = " + imc);
}else if((imc > 18.5) && (imc < 25)){
    Console.WriteLine("PESO IDEAL! - IMC: = " + imc);
}
else if ((imc >= 25)&&(imc < 30))
{
    Console.WriteLine("SOBREPESO! - IMC: = " + imc);
}
else if ((imc >= 30)&&(imc < 40))
{
    Console.WriteLine("OBESIDADE! - IMC: = " + imc);
}else if(imc >= 40)
{
    Console.WriteLine("OBESIDADE MÓRBIDA! - IMC: = " + imc);
}