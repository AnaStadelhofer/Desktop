using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class LeaoControllers
    {
        List<Leao> Leoes = new List<Leao>();
        
        public static void UpdateLeao()
        {
            Console.WriteLine("Atualizar Leão!");
        }

        public static void InsertLeao()
        {
            Console.WriteLine("Cadastrar Leão!");   
            //Leoes.Add(new Leao(Id, Name, Visit, Aliment));
        }

        public static void DeleteLeao()
        {
            Console.WriteLine("Deletar Leão!");
        }

        public static void SelectLeao()
        {
            Console.WriteLine("Selecionar Leão!");
        }
    }
}