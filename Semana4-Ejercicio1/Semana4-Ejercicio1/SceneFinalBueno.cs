using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_Ejercicio1
{
    public class SceneFinalBueno : Scene
    {
        public override Scene Play()
        {
            Console.Clear();
            Console.WriteLine("¡Lograste sobrevivir! - Final bueno");
            Console.WriteLine("Presiona cualquier tecla para salir");
            Console.ReadKey();
            return null;
        }
    }
}
