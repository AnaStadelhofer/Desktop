using System;
using System.Collections.Generic;
using Models;
using Controllers;

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
				Console.WriteLine("\n [6] - Sair");
				Console.WriteLine("\n Escolha uma opção: ");
				try
				{
				Opt = Convert.ToInt32(Console.ReadLine());
				}
				catch(Exception)
				{
					Console.WriteLine("\n Passou no Try Catch");
				}
				
				switch(Opt)
				{
					case 1:
						Console.WriteLine("\n Cadastrar Leão");
						try
						{
							LeaoControllers.InsertLeao();
						}
						catch(Exception)
						{
							Console.WriteLine("\n Erro no metodo para cadastrar Leão");
						}
						break;
					case 2:
						Console.WriteLine("\n Deletar Leão");
						try
						{
							LeaoControllers.DeleteLeao();
						}
						catch(Exception)
						{
							Console.WriteLine("\n Erro no metodo para deletar Leão");
						}
						break;
					case 3:
						Console.WriteLine("\n Atualizar Leão");
						try
						{
							LeaoControllers.UpdateLeao();
						}
						catch(Exception)
						{
							Console.WriteLine("\n Erro no metodo para atualizar Leão");
						}
						break;
					case 4:
						Console.WriteLine("\n Selecionar todos Leões");
						try
						{
							LeaoControllers.SelectLeao();
						}
						catch(Exception)
						{
							Console.WriteLine("\n Erro no metodo para selecionar Leão");
						}
						break;
					case 5:
						Console.WriteLine("\n Selecionar Leão Especifico");
						try
						{
							LeaoControllers.SelectLeaoEspec();
						}
						catch(Exception)
						{
							Console.WriteLine("\n Erro no metodo para selecionar Leão especifico");
						}
						break;
					default:
						Console.WriteLine("\n Inválido");
						break;
				}
			} 
			while(Opt != 6);
		}
	}
}