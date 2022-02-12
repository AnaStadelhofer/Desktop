using System;
using System.Collections.Generic;

public class Program
{
    // Junte duas ArrayList
	public static void Main()
	{
		List<string> Lista = new List<string>();
		
		Lista.Add("Valor 1 da Primeira Lista");
		Lista.Add("Valor 2 da Primeira Lista");
		
        List<string> ListaDois = new List<string>();
		
		ListaDois.Add("Valor 1 da Segunda Lista");
		ListaDois.Add("Valor 2 da Segunda Lista");
		
		List<string> ListaTres = new List<string>();
		
		ListaTres.AddRange(Lista);
		ListaTres.AddRange(ListaDois);
		
		foreach (object it in ListaTres) 
		{
			Console.WriteLine(it);
		}
	}
}