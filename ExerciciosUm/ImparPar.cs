using System;
					
public class Program
{
	public static void Main()
	{
		int i = 0;
		Double[] Num = new Double[10];
		for(i = 0; i < 10; i++)
		{
			Console.WriteLine("Informe o " +(i+1)+ "a número: ");
			try
			{
				Num[i] = Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception)
			{
			Console.WriteLine("Número inválido");	
			}
		}
		for(i = 0; i < Num.Length; i++)
		{	
			if(Num[i] % 2 == 0)
			{
			Console.WriteLine(" " + (i+1) + "a: " + Num[i] + " é par");
			}
			else
			{
			Console.WriteLine(" " + (i+1) + "a: " + Num[i] + " é ímpar");
			}
		}
	}
}