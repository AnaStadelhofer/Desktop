using System;
					
public class Program
{
	public static void Main(String[] args)
	{
		try 
		{
			int ValueOne = Convert.ToInt32(args[0]);
			int ValueTwo = Convert.ToInt32(args[1]);
			
			Console.WriteLine(ValueOne + " + " + ValueTwo + " = " + (ValueOne + ValueTwo));
            Console.WriteLine(ValueOne + " - " + ValueTwo + " = " + (ValueOne - ValueTwo));
            Console.WriteLine(ValueOne + " * " + ValueTwo + " = " + (ValueOne * ValueTwo));
            Console.WriteLine(ValueOne + " / " + ValueTwo + " = " + (ValueOne / ValueTwo));
		}
		catch (Exception)
		{
			Console.WriteLine(" O número informado é inválido!! ");
		}
	}
}