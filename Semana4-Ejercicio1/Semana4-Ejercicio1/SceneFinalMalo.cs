using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_Ejercicio1
{
    public class SceneFinalMalo : Scene
    {
        public override Scene Play()
        {
            Console.Clear();
            Console.WriteLine("Has muerto - Final malo");
            Console.WriteLine("Presiona cualquier tecla para salir");
            Console.ReadKey();
            return null;
        }
    }
}
