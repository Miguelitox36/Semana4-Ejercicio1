using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_Ejercicio1
{
    public class SceneInicio : Scene
    {
        public override Scene Play()
        {
            Console.Clear();
            Console.WriteLine("Te despiertas en un bosque misterioso...");
            Console.WriteLine("1. Ir hacia el bosque oscuro");
            Console.WriteLine("2. Entrar a una cueva");

            string choice = Console.ReadLine();

            if (choice == "1")
                return new SceneBosque();
            else if (choice == "2")
                return new SceneCueva();
            else
            {
                Console.WriteLine("Opción inválida.");
                Console.ReadKey();
                return this;
            }
        }
    }
}
