using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_Ejercicio1
{
    public class Game
    {
        public void Start()
        {
            Scene currentScene = new SceneInicio();

            while (currentScene != null)
            {
                currentScene = currentScene.Play();
            }
        }
    }
}
