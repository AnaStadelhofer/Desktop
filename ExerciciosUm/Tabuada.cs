using System;
public class Program
{
	public static void Main()
	{
		int Num = 0;
		try
		{
			Console.WriteLine("\n Informe um número para a tabuada");
			Num = Convert.ToInt32(Console.ReadLine());
			for(int i = 0; i <= 10; i++)
			{
				Console.WriteLine(" " + Num + " * " + i + " = " + i * Num);
			}
		}
		catch(Exception)
		{
			Console.WriteLine("Valor invalido!");
		}   
	}
}