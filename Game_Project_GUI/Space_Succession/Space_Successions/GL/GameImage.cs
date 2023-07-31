using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Successions
{
    public class Game
    {

        public static GameObject Get_Blank_GameObject()
        {
            return new GameObject(GameObjectType.None, Properties.Resources.None);
        }

        public static GameObject Get_Pallet_GameObject()
        {
            return new GameObject(GameObjectType.Reward, Properties.Resources.pallets);
        }
        public static Image Get_Game_Object_Image(char displayCharacter)
        {
            Image img = Properties.Resources.None;
            if (displayCharacter == '|' || displayCharacter == '%')
                img = Properties.Resources.wall;
            else if (displayCharacter == '#')
                img = Properties.Resources.None;
            else if (displayCharacter == '.')
                img = Properties.Resources.pallets;
            else if (displayCharacter == 'P' || displayCharacter == 'p')
                img = Properties.Resources.Player;
            else if (displayCharacter == 'H' || displayCharacter == 'h')
                img = Properties.Resources.monster1;
            else if (displayCharacter == 'V' || displayCharacter == 'v')
                img = Properties.Resources.monster2;
            else if (displayCharacter == 'R' || displayCharacter == 'r')
                img = Properties.Resources.monster3;
            else if (displayCharacter == 'S' || displayCharacter == 's')
                img = Properties.Resources.monster;
            return img;
        }
    }
}
