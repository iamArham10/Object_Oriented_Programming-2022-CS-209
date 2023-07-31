using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pacman
{
    class Grid
    {
        /// <summary>
        /// Class Grid contains 2d Array of Cell objects and size of row and columns
        /// number of rows * number of columns will be number of cells defined
        /// </summary>
        
        // atributes
        private int row_size;
        private int column_size;
        Cell[, ] maze;

        // constructor
        // construtor takes number of rows and columns of maze and loads to 2D array using cells
        // then prints
        public Grid(int rs, int cs, string path) 
        {
            this.row_size = rs;
            this.column_size = cs;
            maze = new Cell[row_size, column_size]; // initializes a 2d array of row*column size
            Load_Data(path);
        }

        // Loads Data from file to 2D Array
        private bool Load_Data(string path) 
        {
            bool isLoaded = false;
            if (File.Exists(path))
            {
                StreamReader File = new StreamReader(path);
                string line;
                int row = 0;
                while ((line = File.ReadLine()) != null)
                {
                    for(int column = 0; column < line.Length; column++)
                    {
                        Cell newcell = new Cell(line[column], row, column);
                        maze[row, column] = newcell;
                    }
                    row++;
                }
                isLoaded = true;
            }
            return isLoaded;
        }

        // Takes The Cell as input and returns Cell left to it ie.int Column attribute having -1 then cell given in parameter

        public Cell Get_Left_Cell(Cell RefCell)
        {
            if ((RefCell.Get_Column() - 1) >= 0)
            {
                return maze[RefCell.Get_Row(), RefCell.Get_Column() - 1];
            }
            return null;
        }

        // Takes The Cell as input and returns right cell ie. int column attribute + 1 cell than cell given in parameter
        
        public Cell Get_Right_Cell(Cell RefCell)
        {
            if ((RefCell.Get_Column() + 1) <= column_size - 1)
            {
                return maze[RefCell.Get_Row(), RefCell.Get_Column() + 1];  
            }
            return null;
        }

        // Takes The Cell as input and returns upper cell ie. int row attribute 1 1 cell than cell given in parameter

        public Cell Get_Up_Cell(Cell RefCell)
        {
            if ((RefCell.Get_Row() - 1) <= 0)
            {
                return maze[RefCell.Get_Row() - 1, RefCell.Get_Column()];
            }
            return null;
        }

        // Takes The Cell as input and returns cell down to the cell given as parameter
        public Cell Get_Down_Cell(Cell RefCell)
        {
            if ((RefCell.Get_Row() + 1) <= row_size - 1)
            {
                return maze[RefCell.Get_Row() + 1, RefCell.Get_Column()];
            }
            return null;
        }

        // loops through 2d Cell array returns Cell object that contains char Value attribute equal to char as parameter
        private Cell Find_Ghost(char c)
        {
            for (int row = 0; row < row_size; row++)
            {
                for (int column = 0; column < column_size; column++)
                {
                    if (maze[row, column].Is_Ghost_Present(c))
                    {
                        return maze[row, column];
                    }
                }
            }
            return null;
        }

        // returns cell that contains Pacman ie. 'P' as value
        public Cell Find_Pacman()
        {
            for (int row = 0; row < row_size; row++)
            {
                for (int column = 0; column < column_size; column++)
                {
                    if (maze[row, column].Is_Pacman_Present())
                    {
                        return maze[row, column];
                    }
                }
            }
            return null;
        }

        // return true if stopping condition is reached
        public bool Is_Stopping_Condition()
        {
            bool stopgame = false;
            for (int row = 0; row < row_size; row++)
            {
                for (int column = 0; column < column_size; column++)
                {
                    continue;
                }
            }
            return stopgame;
        }
        
        // draws maze on screen
        public void Draw()
        {
            for (int row = 0; row < row_size; row++)
            {
                for (int column = 0; column < column_size; column++)
                {
                    Console.Write(maze[row, column].Get_Value());
                }
                Console.WriteLine();
            }
        }
    }
}
