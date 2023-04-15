using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;
using System.IO;

namespace Shooting_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string maze_path = "C:\\Users\\Win 10\\Documents\\GitHub\\Object_Oriented_Programming-2022-CS-209\\PD_Lab_2(4-14-2023)\\My_Game_With_Lists_OOP\\Shooting_Game\\Files\\maze.txt";
            char option = Print_Menu();
            do
            {
                if (option == '1')
                {
                    Console.Clear();
                    int rows = 30;
                    int column = 120;
                    char[,] maze = new char[rows, column];
                    Load_maze(maze, maze_path);  // loads the maze from file into the maze character 2D array
                    Print_maze(maze, rows, column); // prints the maze on the console.
                    spaceship DeathStar = new spaceship();
                    DeathStar.position_x = 5;
                    DeathStar.position_y = 2;
                    Create_Spaceship(DeathStar, DeathStar.position_x, DeathStar.position_y);
                    spaceship reaver = new spaceship();
                    reaver.position_x = 92;
                    reaver.position_y = 5;
                    Create_Spaceship(reaver, reaver.position_x, reaver.position_y);
                    Print_spaceship(DeathStar, DeathStar.position_x, DeathStar.position_y);
                    Print_spaceship(reaver, reaver.position_x, reaver.position_y);
                    bool game_running = true;
                    while (game_running)
                    {
                        Thread.Sleep(100);
                        if (Keyboard.IsKeyPressed(Key.UpArrow))
                        {
                            Move_SpaceShip_Up(DeathStar, maze,ref DeathStar.position_x, ref DeathStar.position_y);
                        }
                        if (Keyboard.IsKeyPressed(Key.DownArrow))
                        {
                            Move_SpaceShip_Down(DeathStar, maze , ref DeathStar.position_x, ref DeathStar.position_y);
                        }
                        if (Keyboard.IsKeyPressed(Key.RightArrow))
                        {
                            Move_SpaceShip_Right(DeathStar, maze,ref DeathStar.position_x, ref DeathStar.position_y);
                        }
                        if (Keyboard.IsKeyPressed(Key.LeftArrow))
                        {
                            Move_SpaceShip_Left(DeathStar,maze, ref DeathStar.position_x, ref DeathStar.position_y);
                        }
                    }
                    

                }
                else if (option == '2')
                {
                    Console.Clear();
                    print_Ascii();
                    Console.ReadKey();
                    continue; // prints rules of the game which i havn't written yet.
                }
                Console.ReadKey();
            } while (option != '0');
            
            Console.ReadKey();

        }

        static void Load_maze(char [,] maze, string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                int row = 0;
                string line;
                while ((line = fileVariable.ReadLine()) != null)
                {
                    for (int column = 0; column < line.Length; column++)
                    {
                        maze[row, column] = line[column];
                    }
                    row++;
                }
            }  
        }

        static char Print_Menu()
        {
            Console.WriteLine("Enter The Following Options: ");
            Console.WriteLine("1. Play Game");
            Console.WriteLine("2. See Rules");
            Console.WriteLine("0. Exit");
            char option = char.Parse(Console.ReadLine());
            return option;
        }

        static void Print_maze(char [, ] maze, int rows, int columns)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (maze[row, column] == 'w')
                    {
                        Console.Write("#");
                    }
                    else if (maze[row, column] == 's')
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void print_Ascii()
        {
            for (int idx = 0; idx < 500; idx++)
            {
                char c = (char)idx;
                Console.WriteLine(idx + " " + c);
            }
        }
        
        static void Create_Spaceship (spaceship newspaceship, int x, int y)
        {
            newspaceship.position_x = x;
            newspaceship.position_y = y;
            char left_wall = '(';
            char right_gun = '>';
            char circle = ')';
            char left_gun = '<';
            newspaceship.structure[0, 0] = left_wall;
            newspaceship.structure[1, 0] = left_gun;
            newspaceship.structure[2, 0] = left_wall;
            newspaceship.structure[0, 1] = circle;
            newspaceship.structure[1, 1] = right_gun;
            newspaceship.structure[2, 1] = circle;
        }

        static void Print_spaceship (spaceship Spaceship, int x , int y)
        {
            
            for (int row = 0; row < 3; row++)
            {
                Console.SetCursorPosition(x, y);
                for (int column = 0; column < 2; column++)
                {
                    Console.Write(Spaceship.structure[row, column]);
                }
                y++;
            }
        }

        static void Move_SpaceShip_Down(spaceship Death_Star, char [,] maze,ref int position_x, ref int position_y)
        {
            if (maze[position_x, position_y+2] == 's')
            {
                erase_spaceship(Death_Star, position_x, position_y);
                position_y++;
                Print_spaceship(Death_Star, position_x, position_y);
            }
        }


        static void Move_SpaceShip_Up(spaceship Death_Star, char [,] maze,ref int position_x, ref int position_y)
        {
            if (maze[position_x, position_y-1] == 's')
            {
                erase_spaceship(Death_Star, position_x, position_y);
                position_y--;
                Print_spaceship(Death_Star, position_x, position_y);

            }
        }

        static void Move_SpaceShip_Left(spaceship Death_Star, char [,] maze,ref int position_x, ref int position_y)
        {
            if (maze[position_x-1, position_y] == 's')
            {
                erase_spaceship(Death_Star, position_x, position_y);
                position_x--;
                Print_spaceship(Death_Star, position_x, position_y);
            }
        }

        static void Move_SpaceShip_Right(spaceship Death_Star,char [,] maze, ref int position_x, ref int position_y)
        {
            if (maze[position_x + 1, position_y] == 's')
            {
                erase_spaceship(Death_Star, position_x, position_y);
                position_x++;
                Print_spaceship(Death_Star, position_x, position_y);
            }
        }

        static void erase_spaceship (spaceship spaceship, int x, int y)
        {
            for (int row = 0; row < 3; row++)
            {
                Console.SetCursorPosition(x, y);
                for (int column = 0; column < 2; column++)
                {
                    Console.Write(' ');
                }
                y++;
            }
        }
    }
}
