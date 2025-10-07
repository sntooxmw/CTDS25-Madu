double Apples;
double Pagar;

Console.WriteLine("Você irá comprar quantas maçãs?");
Apples = double.Parse(Console.ReadLine());

if (Apples < 25)
{
    Pagar = Apples * 2.73;
    Console.WriteLine($"Você irá pagar R${Pagar:F2}");
}
else
{
    Pagar = Apples * 2.00;
    Console.WriteLine($"Você irá pagar R${Pagar:F2}");
}