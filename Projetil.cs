using System;

namespace Projetil
{

    public class Program 
    {
        public static void Main()
        {
			const double G = 9.80665;
			      double AnguloGraus;
			      double AnguloRadianos;
			      double Velocidade;
			      double Alcance;
			      double Altura;
			      
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Projétil");
			Console.WriteLine();
			Console.ResetColor();
			
			Console.Write("Insira a velocidade (m/s): ");
			Velocidade = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Insira o ângulo (graus): ");
			AnguloGraus = Convert.ToDouble(Console.ReadLine());
			
			AnguloRadianos = AnguloGraus * (Math.PI/180);
			
			Alcance = (Math.Pow(Velocidade, 2) * Math.Sin(2 * AnguloRadianos)) / G;
			Console.WriteLine($"Alcance: {Alcance:N2} m");
			
			Altura = Math.Pow((Velocidade * Math.Sin(AnguloRadianos)), 2) / (2 * G);
			Console.WriteLine($"Altura: {Altura:N2} m");
        }
    }
}
