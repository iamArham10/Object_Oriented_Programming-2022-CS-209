using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Driver Code : 
            /// character array one
            /// objects we want to move in the screen ///
            char[,] triangle = new char[5, 3] { 
                {'@',' ', ' '},
                {'@','@', ' '},
                {'@','@', '@'},
                {'@','@', ' '},
                {'@',' ', ' '}
            };
            /// character array two 
            char[,] optriangle = new char[5, 3] {
                {'#','#', '#'},
                {' ','#', ' '},  
                {' ','#', ' '},
                {' ','#', ' '},
                {'#','#', '#'}
            };
            
            Boundary b = new Boundary(new Point(0, 0), new Point(90, 0), new Point(0, 90), new Point(90, 90)); // Boundaries
            Boundary b1 = new Boundary(new Point(0, 0), new Point(90, 0), new Point(0, 20), new Point(90, 20));// of object movement
            GameObject g1 = new GameObject(triangle, new Point(5, 5), b, "Patrol");                            // object no 1 that patrols
            GameObject g2 = new GameObject(optriangle, new Point(5,22), b1, "Projectile");                     // object no2 that moves in projectile motion
            GameObject g3 = new GameObject(triangle, new Point(5, 5), b1, "Diagonal");                         // object no3 that moves in diagonal direction
            List<GameObject> gameobjects = new List<GameObject>(); // list of objects;
            gameobjects.Add(g1);
            gameobjects.Add(g2); // addings objects to the list
            gameobjects.Add(g3);

            while (true)
            {
                Thread.Sleep(100); // Pauses the execution for 100 milisecond 
                                   // to make objects moving slowly

                foreach(GameObject gameobject in gameobjects) // foreach loop selects each gameobject
                {
                    // then 
                    gameobject.Erase();
                    gameobject.Move(); // applies these three methods to that object
                    gameobject.Print();
                }
            }
        }
    }
}
