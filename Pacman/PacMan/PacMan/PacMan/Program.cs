using System;
using System.Threading;
using EZInput;
using System.IO;

namespace PacMan
{
    class Program
    {
        static int score = 0;
        static void Main(string[] args)
        {
            // PacMan Coordinates
            int pacmanX = 9;
            int pacmanY = 31;
            
            // Horizontal Ghosts
            // Ghost 1H (Horizontal) Information
            char previous1H = ' ';
            int ghost1HX = 15;
            int ghost1HY = 39;
            string ghost1Hdirection = "left";
            int count1 = 0;
            // Ghost 2H (Horizontal) Information
            char previous2H = ' ';
            int ghost2HX = 6;
            int ghost2HY = 6;
            string ghost2Hdirection = "left";

            // Vertical Ghosts
            // Ghost 1st (Vertical) Information
            char previous1V = ' ';
            int ghost1VX = 20;
            int ghost1VY = 57;
            string ghost1Vdirection = "up";
            int count2 = 0;

            // Ghost 2 Second (Vertical) Information
            char previous2V = ' ';
            int ghost2VX = 15;
            int ghost2VY = 28;
            string ghost2Vdirection = "up";

            // Random Movement Ghosts
            // Ghost 1 (Random) Information
            char previous1R = ' ';
            int ghost1RX = 20;
            int ghost1RY = 28;
            // Ghost 2 (Random) Information
            char previous2R = ' ';
            int ghost2RX = 21;
            int ghost2RY = 30;

            // Smart Movement Ghost
            // Ghost 1 (Smart) Information
            char previous1S = ' ';
            int ghost1SX = 21;
            int ghost1SY = 30;
            // ghost 2 Smart Information
            char previous2S = ' ';
            int ghost2SX = 11;
            int ghost2SY = 53;

            char[,] maze = new char[24, 71];

            readData(maze);
            printMaze(maze);

            Console.SetCursorPosition(pacmanY, pacmanX);
            Console.Write("P");

            bool gameRunning = true;
            while (true)
            {
                Thread.Sleep(90);
                printScore();
                // pacman movement
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    movePacManUp(maze, ref pacmanX, ref pacmanY);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    movePacManDown(maze, ref pacmanX, ref pacmanY);
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    movePacManLeft(maze, ref pacmanX, ref pacmanY);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    movePacManRight(maze, ref pacmanX, ref pacmanY);
                }
                count1++;
                count2++;
             
                if (count1 == 5)            // Slowest Movement
                {
                    gameRunning = moveGhostInLine(ref ghost1Hdirection, maze, ref ghost1HX, ref ghost1HY, ref previous1H); // 1st horizontal ghost
                    if (gameRunning == false) break;

                    gameRunning = moveGhostInLine(ref ghost2Vdirection, maze, ref ghost2VX, ref ghost2VY, ref previous2V); // second vertical ghost
                    if (gameRunning == false) break;

                    gameRunning = moveGhostSmart(maze, ref ghost2SX, ref ghost2SY,ref previous2S , pacmanX, pacmanY); // 2nd smart movement ghost
                    if (gameRunning == false) break;
                    count1 = 0;
                }
                if (count2 == 2)            // Slow Movement
                {
                    gameRunning = moveGhostInLine(ref ghost1Vdirection, maze, ref ghost1VX, ref ghost1VY, ref previous1V); // 1st vertical
                    if (gameRunning == false) break;
                    gameRunning = moveGhostRandom(maze,ref ghost2RX,ref ghost2RY, ref previous2R); // 2nd Random Movement Ghost
                    if (gameRunning == false) break;
                    count2 = 0;
                }
                
                gameRunning = moveGhostRandom(maze, ref ghost1RX, ref ghost1RY, ref previous1R); // 1st Random Movement Ghost
                if (gameRunning == false) break;
                gameRunning = moveGhostInLine(ref ghost2Hdirection, maze, ref ghost2HX, ref ghost2HY, ref previous2H); // 2st Horizontal movement ghost
                if (gameRunning == false) break;
                gameRunning = moveGhostSmart(maze, ref ghost1SX, ref ghost1SY, ref previous1S, pacmanX, pacmanY); // 1st Smart movement ghost
                if (gameRunning == false) break;
            }
        }

        static void printScore()
        {
            Console.SetCursorPosition(79, 12);
            Console.WriteLine("Score: " + score);
        }

        static bool moveGhostSmart(char[,] maze, ref int X, ref int Y, ref char previous, int pX, int pY)
        {
            double[] distance = new double[4] {1000000,1000000,1000000,1000000};
            if (maze[X, Y - 1] != '|' && maze[X, Y - 1] != '%' )
            {
                distance[0] = (calculateDistance(X, Y-1, pX, pY));
            }
            if (maze[X, Y + 1] != '|' && maze[X, Y + 1] != '%')
            {
                distance[1] = (calculateDistance(X, Y + 1, pX, pY));
            }
            if (maze[X + 1, Y] != '|' && maze[X + 1, Y] != '%' && maze[X + 1, Y] != '#')
            {
                distance[2] = (calculateDistance(X + 1, Y, pX, pY));
            }
            if (maze[X - 1, Y] != '|' && maze[X - 1, Y] != '%' && maze[X - 1, Y] != '#')
            {
                distance[3] = (calculateDistance(X - 1, Y, pX, pY));
            }
            if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
            {
                string direction = "left";
                return moveGhostInLine(ref direction, maze, ref X, ref Y, ref previous);
            }
            if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
            {
                string direction = "right";
                return moveGhostInLine(ref direction, maze, ref X, ref Y, ref previous);
            }
            if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
            {
                string direction = "down";
                return moveGhostInLine(ref direction, maze, ref X, ref Y, ref previous);
            }
            else
            {
                string direction = "up";
                return moveGhostInLine(ref direction, maze, ref X, ref Y, ref previous);
            }
        }

        static double calculateDistance(int X, int Y, int pX, int pY)
        {
            return Math.Sqrt(Math.Pow((pX - X), 2) + Math.Pow((pY - Y), 2));
        }

        static bool moveGhostInLine(ref string direction, char[,] maze, ref int X, ref int Y, ref char previous)
        {
            if (maze[X, Y - 1] == 'P' || maze[X, Y + 1] == 'P' || maze[X + 1, Y] == 'P' || maze[X - 1, Y] == 'P')
            {
                return false;
            }
            if (direction == "left" && (maze[X, Y-1] == ' ' || maze[X, Y-1] == '.'))
            {
                maze[X, Y] = previous;
                Console.SetCursorPosition(Y, X);
                Console.Write(previous);
                
                Y = Y - 1;
               
                previous = maze[X, Y];
                Console.SetCursorPosition(Y, X);
                Console.Write("G");
                if(maze[X,Y-1] == '|')
                {
                    direction = "right";
                }
            }
            else if (direction == "right" && (maze[X, Y + 1] == ' ' || maze[X, Y + 1] == '.'))
            {
                maze[X, Y] = previous;
                Console.SetCursorPosition(Y, X);
                Console.Write(previous);
                
                Y = Y + 1;
                
                previous = maze[X, Y];
                Console.SetCursorPosition(Y, X);
                Console.Write("G");
                if (maze[X, Y+1] == '|')
                {
                    direction = "left";
                }
            }
            else if (direction == "up" && (maze[X-1, Y] == ' ' || maze[X-1, Y] == '.'))
            {
                maze[X, Y] = previous;
                Console.SetCursorPosition(Y, X);
                Console.Write(previous);

                X = X - 1;

                previous = maze[X, Y];
                Console.SetCursorPosition(Y, X);
                Console.Write("G");
                if (maze[X - 1, Y] == '%' || maze[X - 1, Y] == '#')
                {
                    direction = "down";
                }
            }
            else if (direction == "down" && (maze[X + 1, Y] == ' ' || maze[X + 1, Y] == '.'))
            {
                maze[X, Y] = previous;
                Console.SetCursorPosition(Y, X);
                Console.Write(previous);

                X = X + 1;

                previous = maze[X, Y];
                Console.SetCursorPosition(Y, X);
                Console.Write("G");
                if (maze[X + 1, Y] == '%' || maze[X + 1, Y] == '#')
                {
                    direction = "up";
                }
            }
            return true;
        }

        static int ghostDirection()
        {
            Random r = new Random();
            int value = r.Next(4);
            return value;
        }
        static bool moveGhostRandom(char [,] maze, ref int X, ref int Y, ref char previous)
        {
            if (maze[X, Y - 1] == 'P' || maze[X, Y + 1] == 'P' || maze[X + 1, Y] == 'P' || maze[X - 1, Y] == 'P')
            {
                return false;
            }
            int value = ghostDirection();
            if (value == 0)
            {
                if (maze[X, Y - 1] == ' ' || maze[X, Y - 1] == '.' || maze[X, Y - 1] == 'P')
                {
                    maze[X, Y] = previous;
                    Console.SetCursorPosition(Y, X);
                    Console.Write(previous);

                    Y = Y - 1;
                    previous = maze[X, Y];
                    Console.SetCursorPosition(Y, X);
                    Console.Write('G');
                }
            }
            else if (value == 1)
            {
                if (maze[X, Y + 1] == ' ' || maze[X, Y + 1] == '.' || maze[X, Y + 1] == 'P')
                {
                    maze[X,Y] = previous;
                    Console.SetCursorPosition(Y, X);
                    Console.Write(previous);
                    Y = Y + 1;
                    previous = maze[X,Y];
                    Console.SetCursorPosition(Y, X);
                    Console.Write('G');
                }
            }
            else if (value == 2)
            {
                if (maze[X - 1,Y] == ' ' || maze[X - 1,Y] == '.' || maze[X - 1,Y] == 'P')
                {
                    maze[X,Y] = previous;
                    Console.SetCursorPosition(Y, X);
                    Console.Write(previous);
                    X = X - 1;
                    previous = maze[X,Y];
                    Console.SetCursorPosition(Y, X);
                    Console.Write('G');
                }
            }
            else if (value == 3)
            {
                if (maze[X + 1,Y] == ' ' || maze[X + 1,Y] == '.' || maze[X + 1,Y] == '.')
                {
                    maze[X,Y] = previous;
                    Console.SetCursorPosition(Y, X);
                    Console.Write(previous);
                    X = X + 1;
                    previous = maze[X,Y];
                    Console.SetCursorPosition(Y, X);
                    Console.Write('G');
                }
            }
            return true;
        }


        static void calculateScore()
        {
            score = score + 1;
        }

        static void movePacManUp(char[,] maze, ref int pacmanX, ref int pacmanY)
        {
            if (maze[pacmanX - 1, pacmanY] == ' ' || maze[pacmanX - 1, pacmanY] == '.')
            {
                maze[pacmanX, pacmanY] = ' ';
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write(" ");
                pacmanX = pacmanX - 1;
                if (maze[pacmanX, pacmanY] == '.')
                {
                    calculateScore();
                }
                Console.SetCursorPosition(pacmanY, pacmanX);
                maze[pacmanX, pacmanY] = 'P';
                Console.Write("P");

            }
        }
        static void movePacManDown(char[,] maze, ref int pacmanX, ref int pacmanY)
        {
            if (maze[pacmanX + 1,pacmanY] == ' ' || maze[pacmanX + 1,pacmanY] == '.')
            {
                maze[pacmanX,pacmanY] = ' ';
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write(" ");
                pacmanX = pacmanX + 1;
                Console.SetCursorPosition(pacmanY, pacmanX);
                if (maze[pacmanX, pacmanY] == '.')
                {
                    calculateScore();
                }
                maze[pacmanX, pacmanY] = 'P';
                Console.Write("P");
                
            }
        }

        static void movePacManLeft(char[,] maze, ref int pacmanX, ref int pacmanY)
        {
            if (maze[pacmanX,pacmanY - 1] == ' ' || maze[pacmanX,pacmanY - 1] == '.')
            {
                maze[pacmanX,pacmanY] = ' ';
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write(" ");
                pacmanY = pacmanY - 1;
                if (maze[pacmanX, pacmanY] == '.')
                {
                    calculateScore();
                }
                Console.SetCursorPosition(pacmanY, pacmanX);
                maze[pacmanX, pacmanY] = 'P';
                Console.Write("P");
                
            }
        }

        static void movePacManRight(char[,] maze, ref int pacmanX, ref int pacmanY)
        {
            if (maze[pacmanX,pacmanY + 1] == ' ' || maze[pacmanX,pacmanY + 1] == '.')
            {
                maze[pacmanX,pacmanY] = ' ';
                Console.SetCursorPosition(pacmanY, pacmanX);
                Console.Write(" ");
                pacmanY = pacmanY + 1;
                if (maze[pacmanX, pacmanY] == '.')
                {
                    calculateScore();
                }
                Console.SetCursorPosition(pacmanY, pacmanX);
                maze[pacmanX, pacmanY] = 'P';
                Console.Write("P");
                
            }
        }

        static void printMaze(char[,] maze)
        {
            for (int x = 0; x < maze.GetLength(0); x++)
            {
                for (int y = 0; y < maze.GetLength(1); y++)
                {
                    Console.Write(maze[x,y]);
                }
                Console.WriteLine();
            }
        }

        static void readData(char [,] maze)
        {
            StreamReader fp = new StreamReader("maze.txt");
            string record;
            int row = 0;
            while ((record = fp.ReadLine()) != null)
            {
                for (int x = 0; x < 71; x++)
                {
                    maze[row, x] = record[x];
                }
                row++;
            }

            fp.Close();
        }
    }
}

