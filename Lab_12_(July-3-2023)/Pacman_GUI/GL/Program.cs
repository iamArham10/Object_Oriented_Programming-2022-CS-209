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

            // pacman information
            GameCell start = new GameCell(19, 26, mygrid);
            PacmanPlayer pacman = new PacmanPlayer('P', start);
            start.current_game_object = pacman;

            // creating a Horizontal Ghost
            HorizontalGhost HG1 = new HorizontalGhost(GameObjectType.ENEMY, 'H', GameDirection.LEFT);
            GameCell HG1cell = new GameCell(1, 24, mygrid);
            HG1.currentcell = HG1cell;
            HG1cell.current_game_object = HG1;

            // creating a Vertical Ghost
            VerticalGhost VG1 = new VerticalGhost(GameObjectType.ENEMY, 'V', GameDirection.DOWN);
            GameCell VG1cell = new GameCell(3, 51, mygrid);
            VG1.currentcell = VG1cell;
            VG1cell.current_game_object = VG1;

            // creating a random movement Ghost 
            RandomGhost RG1 = new RandomGhost(GameObjectType.ENEMY, 'R');
            GameCell RG1cell = new GameCell(6, 51, mygrid);
            RG1.currentcell = RG1cell;
            RG1cell.current_game_object = RG1;

            // creating smart ghost
            SmartGhost SG1 = new SmartGhost(GameObjectType.ENEMY, 'S', pacman);
            GameCell SG1Cell = new GameCell(1, 20, mygrid);
            SG1Cell.current_game_object = SG1;
            SG1.currentcell = SG1Cell;

            // printing the maze
            print_maze(mygrid);
            printGameObject(pacman);
            printGameObject(HG1);
            printGameObject(VG1);
            printGameObject(RG1);
            printGameObject(SG1);

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

                Move_Ghost(HG1);
                Move_Ghost(VG1);
                Move_Ghost(RG1);
                Move_Ghost(SG1);
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

        static void Move_Ghost(Ghost g)
        {
            GameCell nextcell = g.Move();
            if (nextcell != null)
            {
                GameObject newGo;
                newGo = nextcell.current_game_object;
               /* if (nextcell.current_game_object.gameobjecttype == GameObjectType.REWARD)
                {
                    newGo = new GameObject(GameObjectType.REWARD, '.');    
                }
                else
                {
                    newGo = new GameObject(GameObjectType.NONE, ' ');
                }*/
                Change_Cell(nextcell, g, newGo);
            }
        }
        
        static void moveGameObject(PacmanPlayer P, GameDirection gd)
        {
            GameCell nextcell = P.move(gd);
            if (nextcell != null)
            {
                GameObject newGO = new GameObject(GameObjectType.NONE, ' ');
                Change_Cell(nextcell, P, newGO);
            }
        }

        static void Change_Cell(GameCell nextcell, GameObject CurrentObject, GameObject newGo)
        {
            GameCell currentCell = CurrentObject.currentcell;
            clearGameCellContent(currentCell, newGo);
            CurrentObject.currentcell = nextcell;
            printGameObject(CurrentObject);
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