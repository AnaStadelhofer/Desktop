using System;

		
public class Animal
{
	protected int IdAnimal { get; set; }
	protected string NomeAnimal { get; set; }
	
	public Animal(int IdAnimal, string NomeAnimal)
	{
		this.IdAnimal = IdAnimal;
		this.NomeAnimal = NomeAnimal;
	}
}

public class Program
{
	public static void Main()
	{
		List<Leao> Leoes = new List<Leao>();
		int opt = 0;
		int Id = 0;
		int Aliment = 0;
		int Visit = 0;
		do 
		{
			Console.WriteLine("\n [1] - Insert");
			Console.WriteLine("\n [2] - Delete");
			Console.WriteLine("\n [3] - Update");
			Console.WriteLine("\n [4] - Select");
			try
			{
			opt = Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception)
			{
				Console.WriteLine("\n Passou no Try Catch");
			}
			
			switch(opt)
			{
				case 1:
					Console.WriteLine("\n Cadastrar Leão");
					Console.WriteLine("\n Informe o id: ");
					Id = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("\n Informe o nome: ");
					string Name = "";
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
					
					Leoes.Add(new Leao(Id, Name, Visit, Aliment));
					break;
				case 2:
					Console.WriteLine("\n Deletar Leão");
					Console.WriteLine("\n Informe o id: ");
					try
					{
						Id = Convert.ToInt32(Console.ReadLine());
						Leoes.RemoveAt(Id);
					}
					catch(Exception)
					{
						Console.WriteLine("\n Deu bosta");
					}
					break;
				case 3:
					Console.WriteLine("\n Atualizar Leão");
					break;
				case 4:
					Console.WriteLine("\n Selecionar todos Leões");
					foreach(object it in Leoes)
					{
						Console.WriteLine(it);
					}
					break;
				default:
					Console.WriteLine("\n Inválido");
					break;
			}
		} 
		while(opt != 5);
	}
}

public class Leao : Animal
{
	protected int Visitante { get; set; }
	protected int QtdAlimento { get; set; }
	
	public Leao(int IdAnimal, string NomeAnimal, int Visitante, int QtdAlimento) : base(IdAnimal, NomeAnimal)
	{
		this.Visitante = Visitante;
		this.QtdAlimento = QtdAlimento;
	}
	
	public override string ToString()
    {
        return "\n Id: " + base.IdAnimal +
			   "\n Name: " + base.NomeAnimal +
			   "\n Visi: " + Visitante +
			   "\n Alimento: " + QtdAlimento;
    }
}