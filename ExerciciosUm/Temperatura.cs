using System;				
public class Program
{
	public static void Main()
	{
		int Ano = 12;
		Double[] Temp = new Double[Ano];
		Double Soma = 0;
		Double Media = Soma / Ano;
		
		for(int i = 0; i < Ano; i++)
		{
			Console.WriteLine("Informe a " + i + "a temperatura");
			try
			{
				Temp[i] = Convert.ToDouble(Console.ReadLine());
				Soma += Temp[i];
			}
			catch(Exception)
			{
				Console.WriteLine("Temperatura inválida");
			}
		}
		Console.WriteLine("A temperatura média foi: " + Media);
	}
}