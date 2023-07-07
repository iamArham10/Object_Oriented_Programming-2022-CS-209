using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class GameGrid
    /// <summary>
    /// GameGrid Class is implementation of grid or board of the game
    /// it is made up of cells object 
    /// </summary>
    {
        // attributes
        // 2d Array of GameCell objects
        GameCell[,] grid;
        // Total Rows and Total Columns
        int rows;
        int columns;

        // contructor
        public GameGrid(string filename, int rows, int columns)
        {
            // setting total rows and columns to specified numbers
            this.rows = rows;
            this.columns = columns;
            // initializing an array of specified rows and columns
            grid = new GameCell[rows, columns];

            // loading the maze from file
            Load_Maze(filename);
        }

        // function to load maze
        private void Load_Maze(string filename)
        {
            // creating a file reading variable
            StreamReader filevar = new StreamReader(filename);
            string line = "";
            // using loops to input files
            for (int i = 0; i < this.rows;i++) // for rows
            {
                line = filevar.ReadLine(); // reading file line
                for (int j = 0; j < this.columns;j++) // for columns
                {
                    // creating a cell first
                    GameCell newcell = new GameCell(i, j, this); // 'this' passes that whole grid object
                    // creating an gameobject
                    // gets object type from gameobject static function
                    // and second argument tells newobject display character
                    GameObject newobject = new GameObject(GameObject.GetObjectType(line[j]), line[j]);
                    // assigin new object his cell
                    newobject.currentcell = newcell; // assigning cell to current object
                    newcell.current_game_object = newobject; // assigning object to current cell
                    // assigning cell refrence to 2d array 
                    grid[i, j] = newcell;
                }
            }
        }

        // returns the distance between two cells
        public static double Get_Distance(GameCell c1, GameCell c2)
        {
            return Math.Sqrt(Math.Pow(c2.x - c1.x, 2) + Math.Pow(c2.y - c1.y, 2));
        }

        // returns the required Cell
        public GameCell getCell(int row, int column)
        {
            if (row < this.rows && column < this.columns) // checks if the specified coordinates are valid
            {
                return grid[row, column];
            }
            return null;
        }

    }
}
