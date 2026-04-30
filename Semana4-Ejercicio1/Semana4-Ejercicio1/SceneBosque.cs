using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_Ejercicio1
{
    public class SceneBosque : Scene
    {
        public override Scene Play()
        {
            Console.Clear();
            Console.WriteLine("Caminas por el bosque y encuentras un lobo...");

            Console.WriteLine("1. Pelear");
            Console.WriteLine("2. Huir");

            string choice = Console.ReadLine();

            if (choice == "1")
                return new SceneFinalMalo();
            else if (choice == "2")
                return new SceneFinalBueno();
            else
            {
                Console.WriteLine("Opción inválida.");
                Console.ReadKey();
                return this;
            }
        }
    }
}
