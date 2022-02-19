using System;
using Controllers;

namespace Views
{
    public class LeaoViews
    {
        
        public static void UpdateLeonView()
        {
            string Name = "";
			int Id = 0;
			int Aliment = 0;
			int Visit = 0;
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
        }

        public static void DeleteLeonView()
        {
            int Id = 0;
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
        }

        public static void SelectAllLeonView()
        {
            Console.WriteLine("\n Selecionar todos Leões");
            try
			{
				LeaoControllers.SelectLeao();
			}
			catch(Exception)
			{
				Console.WriteLine("\n Erro no metodo para selecionar todos leões!");
			}
        }

        public static void SelectOneLeonView()
        {
            int Id = 0;
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
        }

        public static void InsertLeonView()
        {
            string Name = "";
			int Id = 0;
			int Aliment = 0;
			int Visit = 0;
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
        }
    }
}