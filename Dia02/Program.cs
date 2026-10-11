Console.WriteLine("Digite um número");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Você digitou: " + a);

Console.WriteLine("Digite outro número");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Soma: " + (a + b));
Console.WriteLine("Multiplicação: " + (a * b));
Console.WriteLine("Subtração: " + (a - b));
if (b == 0)
{
    Console.WriteLine("Não dá para dividir por zero!"); 
}
else
{
    Console.WriteLine("Divisão: " + (a / b));
    Console.WriteLine("Resto: " + (a % b)); 
}   
if (a % 2 == 0)
{
  Console.WriteLine("É par !");
}
else 
{
    Console.WriteLine("É impar !");
}