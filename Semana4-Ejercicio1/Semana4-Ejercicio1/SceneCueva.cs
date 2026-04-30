using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_Ejercicio1
{
    public class SceneCueva : Scene
    {
        public override Scene Play()
        {
            Console.Clear();
            Console.WriteLine("Entras a la cueva y encuentras un tesoro...");

            Console.WriteLine("1. Tomar el tesoro");
            Console.WriteLine("2. Salir");

            string choice = Console.ReadLine();

            if (choice == "1")
                return new SceneFinalBueno();
            else if (choice == "2")
                return new SceneFinalMalo();
            else
            {
                Console.WriteLine("Opción inválida.");
                Console.ReadKey();
                return this;
            }
        }
    }
}
