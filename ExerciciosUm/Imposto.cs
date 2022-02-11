using System;
					
public class Program
{
	public static void Main()
	{
		Double Faturamento = 100;
        Double Imposto = 10;
        Double Total = Faturamento * Imposto / 100;

		Console.WriteLine("O total do imposto a pagar é: " + Total);
	}
}