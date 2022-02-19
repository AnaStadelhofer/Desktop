using System;
using System.Collections.Generic;
using Models;
using Controllers;
using Views;

namespace Menu
{
	public class Program
	{
		public static void Main()
		{
			string Name = "";
			int Id = 0;
			int Aliment = 0;
			int Visit = 0;
			int Opt = 0;
			do 
			{
				Console.WriteLine("\n [1] - Insert");
				Console.WriteLine("\n [2] - Delete");
				Console.WriteLine("\n [3] - Update");
				Console.WriteLine("\n [4] - Select");
				Console.WriteLine("\n [5] - Select Id");
				Console.WriteLine("\n [6] - Sair ");
				Console.WriteLine("\n Escolha uma opção: ");
				try
				{
				Opt = Convert.ToInt32(Console.ReadLine());
				}
				catch(Exception)
				{
					Console.WriteLine("\n Escolha inválida! Informe um dos númericos de 1 á 6");
				}
				
				switch(Opt)
				{
					case 1:
					// CADASTRAR LEÃO
						try
						{
							LeaoViews.InsertLeonView();
						}
						catch(Exception)
						{
							Console.WriteLine("\n Erro no metodo para cadastrar Leão");
						}
						break;
					case 2:
					// DELETAR LEAO
						try
						{
							LeaoViews.DeleteLeonView();
						}
						catch(Exception)
						{
							Console.WriteLine("\n Erro no metodo para deletar Leão");
						}
						break;
					case 3:
					// Atualizar Leão
						try
						{
							LeaoViews.UpdateLeonView();
						}
						catch(Exception)
						{
							Console.WriteLine("\n Erro no metodo para atualizar Leão");
						}
						break;

					case 4:
					// SELECIONAR TODOS LEÕES
						try
						{
							LeaoViews.SelectAllLeonView();
						}
						catch(Exception)
						{
							Console.WriteLine("\n Erro no metodo para selecionar Leão");
						}
						break;
					case 5:
					// SELECT UM LEAO
						try
						{
							LeaoViews.SelectOneLeonView();
						}
						catch(Exception)
						{
							Console.WriteLine("\n Erro no metodo para selecionar Leão especifico");
						}
						break;
					default:
						Console.WriteLine("\n Adeus!");
						break;
				}
			} 
			while(Opt != 6);
		}
	}
}