using Space_Successions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Successions
{
    public class GameObject
    {
        public char displayCharacter;
        public GameCell currentCell;
        public GameObjectType gameObjectType;
        public Image image;

        public GameObject(GameObjectType gameObjecttype, Image image)
        {
            this.gameObjectType = gameObjecttype;
            this.image = image;
        }

        public static GameObjectType Get_Game_Object_Type(char DisplayCharacter) 
        {
            if (DisplayCharacter == '|' || DisplayCharacter == '#' || DisplayCharacter == '%')
                return GameObjectType.Wall;
            else if (DisplayCharacter == '.')
                return GameObjectType.Reward;
            else
                return GameObjectType.None;
        }

        public char DisplayCharacter { get { return displayCharacter; } set => this.displayCharacter = value; }
        public GameObjectType GameObjectType { get { return gameObjectType; } set => gameObjectType = value; }
        public Image Image { get => this.image; set => this.image = value; }
        public GameCell CurrentCell_GS 
        {   get =>  currentCell; 
            set
            {
                currentCell = value;
                currentCell.Set_Game_Object(this);
            } 
        }

        public GameCell Contains
        {
            get => default;
            set
            {
            }
        }
    }

}
