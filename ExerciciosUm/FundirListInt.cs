using System;
using System.Collections.Generic;

public class Program
{
    // Tirar dúvida
	//6) Crie um programa que una duas listas de inteiros. 
	public static void Main()
	{
		List<int> ListaUm = new List<int>();
		
		ListaUm.Add(1);
		ListaUm.Add(2);
		ListaUm.Add(3);
		/*
		List<int>ListaDois = new List<int>();
		
		ListaDois.Add(21);
		ListaDois.Add(22);
		ListaDois.Add(23);
		
		List<int> ListaTres = new List<int>();
		
		ListaTres.AddRange(ListaUm);
		ListaTres.AddRange(ListaDois);
		*/
		foreach(object it in ListaUm)
		{
			Console.WriteLine(ListaUm);
		}
	}
}