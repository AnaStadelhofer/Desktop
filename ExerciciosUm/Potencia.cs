using System;
					
public class Program
{
	public static void Main()
	{
		int Num = 0;
		int Expoente = 0;
		Console.WriteLine("Informe um número para a potencia e para ser o expoente!");
		try
		{
			Num = Convert.ToInt32(Console.ReadLine());
		}
		catch(Exception)
		{
			Console.WriteLine("Número inválido!");
		}
		try
		{
			Expoente = Convert.ToInt32(Console.ReadLine());
		}
		catch(Exception)
		{
			Console.WriteLine("Número inválido!");
		}
			
		Double Resultado = Math.Pow(num,Expoente);
		Console.WriteLine("\n A operação é " + Num + " elevado a " + Expoente + ", o resultado é: " + Resultado);
	}
}