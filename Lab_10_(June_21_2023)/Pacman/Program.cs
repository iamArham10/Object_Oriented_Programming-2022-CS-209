using System.Runtime.CompilerServices;
using EZInput;
namespace Pacman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mazepath = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Lab_10_(June_21_2023)\Pacman\Files\maze.txt";
            GameGrid mygrid = new GameGrid(mazepath, 24, 71);
            GameCell start = new GameCell(12, 22, mygrid);
            PacmanPlayer pacman = new PacmanPlayer('p', start);
            print_maze(mygrid);
            printGameObject(pacman);


            bool gameRunning = true;
            while (gameRunning)
            {
                Thread.Sleep(90);
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    moveGameObject(pacman, GameDirection.UP);
                }

                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    moveGameObject(pacman, GameDirection.DOWN);
                }

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveGameObject(pacman, GameDirection.RIGHT);
                }

                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    moveGameObject(pacman, GameDirection.LEFT);
                }
            }
        }

        static void printGameObject(GameObject gameObject)
        {
            Console.SetCursorPosition(gameObject.currentcell.y, gameObject.currentcell.x);
            Console.Write(gameObject.display_character);

        }

        static void clearGameCellContent(GameCell gameCell, GameObject newGameObject)
        {
            gameCell.current_game_object = newGameObject;
            Console.SetCursorPosition(gameCell.y, gameCell.x);
            Console.Write(newGameObject.display_character);

        }

        static void moveGameObject(GameObject gameObject, GameDirection direction)
        {
            GameCell nextCell = gameObject.currentcell.nextcell(direction);
            if (nextCell != null)
            {
                GameObject newGO = new GameObject(GameObjectType.NONE, ' ');
                GameCell currentCell = gameObject.currentcell;
                clearGameCellContent(currentCell, newGO);
                gameObject.currentcell = nextCell;
                printGameObject(gameObject);
            }
        }

        static void print_maze(GameGrid grid)
        {
            for(int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 71;j++) 
                {
                    GameCell cell = grid.getCell(i, j);
                    Console.Write(cell.current_game_object.display_character);
                }
                Console.WriteLine();
            }   
        }
    }
}