using System;
using System.Collections.Generic;
using Models;
using Controllers;

public class Program
{
	public static void Main()
	{
		int Opt = 0;
        string Name = "";
		int Id = 0;
		int Aliment = 0;
		int Visit = 0;
		do 
		{
            Console.Clear();
			Console.WriteLine("\n [1] - Insert");
			Console.WriteLine("\n [2] - Delete");
			Console.WriteLine("\n [3] - Update");
			Console.WriteLine("\n [4] - Select");
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
                    Id = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception)
					{
						Console.WriteLine("\n Passou no Try Catch");
					}
					Console.WriteLine("\n Informe o nome: ");
					try
					{
						Name = Console.ReadLine();
					}
					catch(Exception)
					{
						Console.WriteLine("\n Passou no Try Catch");
					}
					
					Console.WriteLine("\n Informe a quantidade de visita: ");
					try
					{
						Visit = Convert.ToInt32(Console.ReadLine());
					}
					catch(Exception)
					{
						Console.WriteLine("\n Passou no Try Catch");
					}
					
					Console.WriteLine("\n Informe a quantidade de alimento: ");
					try
					{
						Aliment = Convert.ToInt32(Console.ReadLine());
					}
					catch(Exception)
					{
						Console.WriteLine("\n Passou no Try Catch");
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
                    Console.WriteLine("\n Adeus...");
                    break;
				default:
					Console.WriteLine("\n Inválido");
					break;
			}
		} 
		while(Opt != 5);
	}
}