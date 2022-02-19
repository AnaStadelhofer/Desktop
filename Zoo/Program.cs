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
						Console.WriteLine("\n Cadastrar Leão");
						Console.WriteLine("\n Informe o Id: ");
						try
						{
							Id = Convert.ToInt32(Console.ReadLine());
						}
						catch(Exception)
						{
							Console.WriteLine("\n Id inválido!");
						}
						Console.WriteLine("\n Informe o nome: ");
						try
						{
							Name = Console.ReadLine();
						}
						catch(Exception)
						{
							Console.WriteLine("\n Nome inválido!");
						}
						
						Console.WriteLine("\n Informe a quantidade de visita: ");
						try
						{
							Visit = Convert.ToInt32(Console.ReadLine());
						}
						catch(Exception)
						{
							Console.WriteLine("\n Visita inválida!");
						}
						
						Console.WriteLine("\n Informe a quantidade de alimento: ");
						try
						{
							Aliment = Convert.ToInt32(Console.ReadLine());
						}
						catch(Exception)
						{
							Console.WriteLine("\n Tempo de Alimento inválido!");
						}
						try
						{
							LeaoControllers.InsertLeao(Id, Name, Visit, Aliment);
						}
						catch(Exception)
						{
							Console.WriteLine("\n Erro no metodo para cadastrar Leão");
						}
						break;

					case 2:
					// DELETAR LEAO
						Console.WriteLine("\n Deletar Leão");
						Console.WriteLine("\n Informe o id: ");
						try
						{
							Id = Convert.ToInt32(Console.ReadLine());
						}
						catch(Exception)
						{
							Console.WriteLine("\n Id informado é inválido!");
						}
						try
						{
							LeaoControllers.DeleteLeao(Id);
						}
						catch(Exception)
						{
							Console.WriteLine("\n Erro no metodo para deletar Leão");
						}
						break;

					case 3:
					// Atualizar Leão
						Console.WriteLine("\n Atualizar Leão");
						Console.WriteLine("\n Informe o Id do Leão");
						try
						{
							Id = Convert.ToInt32(Console.ReadLine());
						}
						catch(Exception)
						{
							Console.WriteLine("\n Id inválido");
						}
						Console.WriteLine("\n Informe o nome: ");
						try
						{
							Name = Console.ReadLine();
						}
						catch(Exception)
						{
							Console.WriteLine("\n Nome inválido!");
						}
						
						Console.WriteLine("\n Informe a quantidade de visita: ");
						try
						{
							Visit = Convert.ToInt32(Console.ReadLine());
						}
						catch(Exception)
						{
							Console.WriteLine("\n Visita inválido!");
						}
						
						Console.WriteLine("\n Informe a quantidade de alimento: ");
						try
						{
							Aliment = Convert.ToInt32(Console.ReadLine());
						}
						catch(Exception)
						{
							Console.WriteLine("\n Tempo de Alimento inválido!");
						}
						try
						{
							LeaoControllers.UpdateLeao(Id, Name, Visit, Aliment);
						}
						catch(Exception)
						{
							Console.WriteLine("\n Erro no metodo para atualizar Leão");
						}
						break;

					case 4:
					// SELECIONAR TODOS LEÕES
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

					// SELECT UM LEAO
						Console.WriteLine("\n Selecionar Leão Especifico");
						Console.WriteLine("\n Informe o Id: ");
						try
						{
							Id = Convert.ToInt32(Console.ReadLine());
						}
						catch(Exception)
						{
							Console.WriteLine("\n Id inválido!");
						}
						try
						{
							LeaoControllers.SelectLeaoEspec(Id);
						}
						catch(Exception)
						{
							Console.WriteLine("\n Erro no metodo para selecionar Leão especifico");
						}
						break;
					default:
						Console.WriteLine("\n Escolha inválida!");
						break;
				}
			} 
			while(Opt != 6);
		}
	}
}