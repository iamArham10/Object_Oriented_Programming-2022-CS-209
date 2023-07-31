using Space_Successions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Successions
{
    public class GameGrid
    {
        public GameCell[,] Cells;
        private int rows;
        private int columns;
        
        public GameGrid(string path, int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            Cells = new GameCell[rows, columns];
            Load_Grid(path);
        }

        private void Load_Grid(string path)
        {
            StreamReader fileReader = new(path);
            string line;
            for (int row = 0; row < rows; row++)
            {
                line = fileReader.ReadLine();
                for (int column = 0; column < columns; column++) 
                {
                    GameCell newcell = new GameCell(row, column, this);
                    char displaychar = line[column];
                    GameObjectType gameobjecttype = GameObject.Get_Game_Object_Type(displaychar);
                    Image objectimage = Game.Get_Game_Object_Image(displaychar);
                    GameObject gameObject = new GameObject(gameobjecttype, objectimage);
                    gameObject.currentCell = newcell;
                    newcell.Set_Game_Object(gameObject);
                    Cells[row, column] = newcell;
                }
            }
            fileReader.Close();
        }

        public GameCell Get_GameCell(int row, int col)
        {
            return Cells[row, col];
        }

        public static double Get_Distance_Between_Cells(GameCell c1, GameCell c2)
        {
            return Math.Sqrt(Math.Pow(c1.X-c2.X,2) + Math.Pow(c1.Y-c2.Y,2));
        }

        public int Rows { 
            get => this.rows; 
            set 
            {
                if (value > 0) { this.rows = value; }
            }
        }
        public int Columns
        {
            get => this.columns;
            set
            {
                if (value > 0) { this.columns = value; }
            }
        }
    }
}
