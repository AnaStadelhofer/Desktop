using System;
using System.Collections.Generic;

namespace Models
{
    public class Leao : Animal
    {
        // Static quando pertence a propria classe (Tipo o List, vai ter somente um para todos Leoes)
        public static List<Leao> Leoes = new List<Leao>();
        public int Visit { get; set; }
        public int Aliment { get; set; }
        
        public Leao(int IdAnimal,
                    string NomeAnimal, 
                    int Visit, 
                    int Aliment) : 
                    base(IdAnimal, NomeAnimal)
        {
            this.Visit = Visit;
            this.Aliment = Aliment;

            Leoes.Add(this);
        }

        public override string ToString()
        {
        return "\n ============================ " +
               "\n Id: " + base.IdAnimal +
			   "\n Nome: " + base.NomeAnimal +
			   "\n Visitantes: " + Visit +
			   "\n Tempo de Alimentação: " + Aliment +
               "\n ============================ ";
        }
    }
}