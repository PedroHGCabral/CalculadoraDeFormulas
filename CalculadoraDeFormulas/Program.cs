using CalculadoraDeFormulas;

string resposta = "";
Calculadora calc = new Calculadora();

do
{
    Console.WriteLine("Digite sF, sI, v e t. Deixe em branco e dê enter no que quer encontrar");
    string? sF = Console.ReadLine();
    string? sI = Console.ReadLine();
    string? v = Console.ReadLine();
    string? t = Console.ReadLine();
    resposta = calc.MovimentoUniforme(sF, sI, v, t);
    Console.WriteLine(resposta);
}
while (resposta != "Erro!!!");


Console.WriteLine("Digite a, b e c");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

resposta = calc.Funcao_Quadratica(a, b, c);
Console.WriteLine(resposta);