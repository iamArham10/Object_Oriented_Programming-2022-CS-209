using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Successions.GL
{
    public static class CollisionDetection
    {
        public static bool IsAlienCollideWithPacman(Alien a)
        {
            if (a.currentCell.CurrentGameObject.GameObjectType == GameObjectType.Player) return true;
            return false;
        }

        public static bool isPlayerCollideWithPallet(GameCell cell)
        {
            if (cell.CurrentGameObject.gameObjectType == GameObjectType.Reward) return true;
            return false;
        }

        public static bool isCollideWithbullet(Alien a)
        {
            if (a.currentCell.CurrentGameObject.gameObjectType == GameObjectType.Bullet)
            {
                return true;
            }
            return false;
        }
    }
}
