//Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным.

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Write($"Enter the number -> ");
		int a = Convert.ToInt32(Console.ReadLine());

		if (a % 2 == 0)
		{
			Console.Write($"Even number -> ");
			Console.WriteLine(a);
		}

		else
		{
			Console.Write($"Odd number -> ");
			Console.WriteLine(a);
		}
	}
}