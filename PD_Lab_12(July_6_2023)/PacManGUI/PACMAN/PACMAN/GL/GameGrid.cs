using System;
using System.Drawing;
using System.IO;

namespace PACMAN.GL
{
    internal class GameGrid
    {
        public GameCell[,] Cells;
        public int rows;
        public int columns;
        public GameGrid(string path, int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            Cells = new GameCell[rows, columns];
            Load_Grid(path);
        }
        private void Load_Grid(string path)
        {
            StreamReader fp = new StreamReader(path);
            string record;
            for (int row = 0; row < rows; row++)
            {
                record = fp.ReadLine();
                for (int col = 0; col < columns; col++)
                {
                    GameCell cell = new GameCell(row, col, this);
                    char displayCharacter = record[col];
                    GameObjectType objectType = GameObject.GetGameObjectType(displayCharacter);
                    Image displayImage = Game.Get_Game_Object_Image(displayCharacter);
                    GameObject obj = new GameObject(objectType, displayImage);
                    obj.currentCell = cell;
                    cell.SetGameObject(obj);
                    Cells[row, col] = cell;
                }
            }
            fp.Close();
        }
        public GameCell Get_Cell(int row, int col)
        {
            return Cells[row, col];
        }
        public static double Get_Distance(GameCell cell1, GameCell cell2)
        {
            return Math.Sqrt(Math.Pow(cell2.x - cell1.x, 2) + Math.Pow(cell2.y - cell1.y, 2));
        }
        public int Rows { get => rows; set => rows = value; }
        public int Columns { get => columns; set => columns = value; }

    }
}
