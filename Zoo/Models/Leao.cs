using System;

namespace Models
{
    public class Leao : Animal
    {
        protected int Visitante { get; set; }
        protected int QtdAlimento { get; set; }
        
        public Leao(int IdAnimal, string NomeAnimal, int Visitante, int QtdAlimento) : base(IdAnimal, NomeAnimal)
        {
            this.Visitante = Visitante;
            this.QtdAlimento = QtdAlimento;
        }
    }
}