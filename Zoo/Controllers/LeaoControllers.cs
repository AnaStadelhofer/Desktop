using System;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class LeaoControllers
    {
        public static void UpdateLeao(int Id, string Name, int Visit, int Aliment)
        {
            Leao leao;
            leao = Leao.Leoes.Find(leao => leao.IdAnimal == Id);  
            if (leao == null) 
            {
                throw new Exception($"Leão não encontrado.");
            }
            if (!String.IsNullOrEmpty(Name)) 
            {
                    leao.NomeAnimal = Name;
            }
            if (Aliment > 0) 
            {
                leao.Aliment = Aliment;
            }
                leao.Visit = Visit;  
        }

        public static void InsertLeao(int Id, string Name, int Visit, int Aliment)
        {
            new Leao(Id, Name, Visit, Aliment);
        }

        public static void DeleteLeao(int Id)
        {
            Console.WriteLine("Deletar Leão!");
            Console.WriteLine("\n Informe o id: ");
			try
            {
			    Leao.Leoes.RemoveAt(Id);
            }
            catch(Exception)
            {
                Console.WriteLine("Leão não foi deletado!");
            }
        }

        public static void SelectLeao()
        {
            foreach(object it in Leao.Leoes)
			{
				Console.WriteLine(it);
			}
        }

        public static void SelectLeaoEspec(int Id)
        {
            IEnumerable<Leao> foo = from Leao in Leao.Leoes where Leao.IdAnimal == 1 select Leao;
            Leao leao = Leao.Leoes.Find(leao => leao.IdAnimal == Id);

            Leao.Leoes.Where(leao => leao.IdAnimal == 1).First();

            foreach(Leao Leoes in foo)
            {
                Console.WriteLine(Leoes.ToString());
            }

            if (leao == null) 
            {
                throw new Exception($"Leão não encontrado.");
            }
        }

    }
}

/*
IEnumerable<Leao> foo = from leao in Leoes where leao.IdAnimal = Id select leao;
*/