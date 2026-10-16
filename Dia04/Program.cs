Console.WriteLine("Digite um número:");
int numero = Convert.ToInt32(Console.ReadLine());

for (int contador = 1; contador <= 10; contador++)
{
    if ((numero * contador) % 2 == 0)
    {
    Console.WriteLine(numero + " x " + contador + " = " + (numero * contador));
    }
}
