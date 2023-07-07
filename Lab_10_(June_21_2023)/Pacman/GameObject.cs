using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    /// <summary>
    /// game object class contains information about game object it's display character current cell object is present and object type
    /// </summary>
    public class GameObject
    {
        // attributes
        // character to display
        public char display_character;
        // cell in which character is residing
        public GameCell currentcell;
        // object type like player, enemy etc
        public GameObjectType gameobjecttype;

        // contructor
        public GameObject(GameObjectType ot,  char display_character)
        {
            this.display_character = display_character;
            gameobjecttype = ot;
        }

        // returns the type of object
        public static GameObjectType GetObjectType(char display_character) 
        {
            GameObjectType ot;
            if (display_character == '|' || display_character == '%' || display_character == '#')
            {
                ot = GameObjectType.WALL;
            }
            else if (display_character == 'G')
            {
                ot = GameObjectType.ENEMY;
            }
            else if (display_character == 'P')
            {
                ot = GameObjectType.PLAYER;
            }
            else if (display_character == '.')
            {
                ot = GameObjectType.REWARD;
            }
            else
            {
                ot = GameObjectType.NONE;
            }
            return ot;

        }
    }
}
