using System;
public class Program
{
     //1) Crie um programa que questione a quantidade de notas a ser informada, receba as notas e calcule a média.
	public static void Main()
	{
		int Quantidade = 0;
		Double Soma = 0.00;
		Double Media = 0.00;
		int i = 0;
		Double[] Nota = new Double[43];
		
		try
		{
           Quantidade = Convert.ToInt32(Console.ReadLine());
       	}
		catch(Exception)
		{
           Console.WriteLine(" Número invalido...");
       	}
       	for(i=0; i<Quantidade; i++)
        {
            try
            {
                Console.WriteLine(" Digite a "+ (i+1) +"a nota: ");
                Nota[i] = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine(" Número invalido...");
            }
            Soma = Soma + Nota[i];
        }
        Media = Soma/i;
        Console.WriteLine(" Foi digitado " + i + " notas, a soma foi " + Soma + " e a media foi " + Media);
	}
}