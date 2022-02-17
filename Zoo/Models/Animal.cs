using System;

namespace Models
{
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
}