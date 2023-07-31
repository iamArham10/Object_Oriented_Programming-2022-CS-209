using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Successions
{
    public abstract class Alien : GameObject
    {
        public Alien(GameObjectType type , Image displayImage) : base(type, displayImage)
        { }
        public int Health = 10;
        public GameObjectType Previous_Object;
        public abstract GameCell Move();
    }
}
