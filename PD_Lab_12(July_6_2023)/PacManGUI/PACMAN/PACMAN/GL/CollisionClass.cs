namespace PACMAN.GL
{
    internal class CollisionClass
    {
        public static bool Check_Collision_Objects(GameObject player, GameObject enemy)
        {
            if (player.currentCell.X == enemy.currentCell.X && player.currentCell.Y == enemy.currentCell.Y)
                return true;
            return false;
        }
    }
}
