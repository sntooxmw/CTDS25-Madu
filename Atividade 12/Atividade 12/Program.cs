int Valor;
int Valor2;

Console.WriteLine("Digite o primeiro número");
Valor = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
Valor2 = int.Parse(Console.ReadLine());

if (Valor > Valor2)
{
    Console.WriteLine($"{Valor} é maior que {Valor2}");
}
else
{
    Console.WriteLine($"{Valor2} é maior que {Valor}");
}