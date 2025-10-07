using System.ComponentModel.Design;

double Nota1 = 0;
double Nota2 = 0;

Console.WriteLine("Digite a sua primeira nota");
Nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a sua segunda nota");
Nota2 = double.Parse(Console.ReadLine());

if (Nota1 / Nota2 > 6)
{
    Console.WriteLine("Você foi Aprovado!");
}
else
{
    Console.WriteLine("Você foi Reprovado!");
}