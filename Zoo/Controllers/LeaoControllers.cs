using System;
using System.Collections.Generic;
using Models;
using Menu;

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
        }

        public static void DeleteLeao()
        {
            Console.WriteLine("Deletar Leão!");
        }

        public static void SelectLeao()
        {
            Console.WriteLine("Selecionar Leão!");
        }

        public static void SelectLeaoEspec()
        {
            Console.WriteLine("Selecionar Leão Especifico!");
        }

    }
}

/*
Animal foo = from animal in animais where animal.idAnimal = id;
*/