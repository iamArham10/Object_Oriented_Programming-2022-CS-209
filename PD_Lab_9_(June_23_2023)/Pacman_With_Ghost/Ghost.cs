using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    /// <summary>
    /// Ghost is an abstract class containing abstract method Move
    /// This class will tell when ghost is created to implement a move method of ghost
    /// </summary>
    public abstract class Ghost : GameObject
    {
        public  Ghost(GameObjectType gt, char displaycharacter) : base(gt, displaycharacter) { }
        public abstract GameCell Move();
    }
}
