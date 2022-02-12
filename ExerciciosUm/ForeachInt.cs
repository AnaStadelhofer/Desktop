using System;
					
public class Program
{
	// 2) Crie um programa que imprima um arrays com Foreach.
	public static void Main()
	{
		int[] Numeros = {10, 20, 30, 40, 50, 60, 70};
		foreach (int Num in Numeros)
		{
			Console.WriteLine(Num);
		}
	}
}