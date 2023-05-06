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
            string maze_path = "C:\\Users\\Win 10\\Documents\\GitHub\\Object_Oriented_Programming-2022-CS-209\\PD_Lab_3(4-28-2023)\\Game\\Shooting_Game\\Files\\maze.txt";
            char option = Print_Menu();
            do
            {
                if (option == '1')
                {
                    Console.Clear();
                    int rows = 30;
                    bool reaverposition = true;
                    int column = 120;
                    char[,] maze = new char[rows, column];
                    Load_maze(maze, maze_path);  // loads the maze from file into the maze character 2D array
                    Print_maze(maze, rows, column); // prints the maze on the console.
                    // Creating Player's Spaceship
                    spaceship DeathStar = new spaceship(5,2,100);
                    DeathStar.Create_Spaceship(DeathStar.position_x, DeathStar.position_y);
                    // Creating Enemy Spaceship
                    spaceship reaver = new spaceship(92,5,100);
                    reaver.Create_Spaceship(reaver.position_x, reaver.position_y);
                    Print_spaceship(DeathStar);
                    Print_spaceship(reaver);
                    // bullets of our player
                    bullet[] deathstar_bullets = new bullet[1000];
                    int bullet_count = 0;
                    char bullet = '.';
                    // bullets of reaver enemy
                    bullet[] reaver_bullets = new bullet[1000];
                    int reaver_bullet_count = 0;
                    bool game_running = true;
                    while (game_running)
                    {
                        Thread.Sleep(100);
                        Print_Health(DeathStar.health, reaver.health);
                        if (DeathStar.health <= 1)
                        {
                            break;
                        }
                        if (Keyboard.IsKeyPressed(Key.UpArrow))
                        {
                            Move_SpaceShip_Up(DeathStar, maze);
                        }
                        if (Keyboard.IsKeyPressed(Key.DownArrow))
                        {
                            Move_SpaceShip_Down(DeathStar, maze);
                        }
                        if (Keyboard.IsKeyPressed(Key.RightArrow))
                        {
                            Move_SpaceShip_Right(DeathStar, maze);
                        }
                        if (Keyboard.IsKeyPressed(Key.LeftArrow))
                        {
                            Move_SpaceShip_Left(DeathStar,maze);
                        }
                        if (Keyboard.IsKeyPressed(Key.Space))
                        {
                            Generate_Death_Star_bullets(deathstar_bullets,ref bullet_count, DeathStar.position_x, DeathStar.position_y, bullet);
                        }
                        Generate_Enemy_bullets(reaver_bullets, ref reaver_bullet_count, reaver.position_x, reaver.position_y, bullet);
                        Move_Enemy_Bullets(reaver_bullets, reaver_bullet_count, bullet,maze, DeathStar.position_x, DeathStar.position_y,ref reaver.health);
                        Move_Bullet(deathstar_bullets, bullet_count, bullet, maze,reaver.position_x, reaver.position_y, ref DeathStar.health);
                        Move_Reaver(reaver,reaverposition);

                        if (reaver.position_y >= 25)
                        {
                            reaverposition = false;
                        }
                        else if (reaver.position_y <= 2)
                        {
                            reaverposition = true;
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
            else
            {
                Console.WriteLine("File doesn't Exists");
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

        static void Print_Health(int player_health, int enemy_health)
        {
            
            string Player_health =  player_health.ToString();
            int ph_x = 101;
            int ph_y = 8;
            int en_x = ph_x;
            int en_y = ph_y+1;
            string Enemy_health = enemy_health.ToString();
            Console.SetCursorPosition(ph_x, ph_y);
            Erase_word(Player_health);
            Console.SetCursorPosition(ph_x, ph_y);
            Console.Write("Enemy Health:" + Player_health);

            Console.SetCursorPosition(en_x, en_y);
            Erase_word(Player_health);
            Console.SetCursorPosition(en_x, en_y);
            Console.Write("Health:      " + Enemy_health);
        }

        static void Erase_word(string word)
        {
            for (int idx = 0; idx < word.Length;idx++)
            {
                Console.Write(' ');
            }
        }

        static void Print_maze(char [, ] maze, int rows, int columns)
        {
            char wall = Convert.ToChar(165);
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (maze[row, column] == 'w')
                    {
                        Console.Write(wall);
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
        
        
        static void Move_Reaver(spaceship Spaceship ,bool position)
        {
            if (position == true)
            { 
                    erase_spaceship(Spaceship);
                    Spaceship.Change_Y_Cord(+1);
                    Print_spaceship(Spaceship);
                
            }
            else if (position == false)
            {  
                    erase_spaceship(Spaceship);
                    Spaceship.Change_Y_Cord(-1);
                    Print_spaceship(Spaceship);  
            }
        }


        static void Print_spaceship (spaceship Spaceship)
        {
            int y = Spaceship.position_y;
            for (int row = 0; row < 3; row++)
            {
                Console.SetCursorPosition(Spaceship.position_x, y);
                for (int column = 0; column < 2; column++)
                {
                    Console.Write(Spaceship.structure[row, column]);
                }
                y++;
            }
        }

        static void Generate_Death_Star_bullets(bullet[] bullets,ref int bullet_count, int death_star_position_x, int death_star_position_y, char bullet)
        {
            bullets[bullet_count] = new bullet(death_star_position_x+1, death_star_position_y);
            Console.SetCursorPosition(bullets[bullet_count].position_x, bullets[bullet_count].position_y);
            Console.Write(bullet);
            bullet_count++;
        }
        
        static void Generate_Enemy_bullets(bullet[] bullets, ref int bullet_count, int reaver_position_x, int reaver_position_y, char bullet)
        {
            bullets[bullet_count] = new bullet(reaver_position_x - 1, reaver_position_y);
            Console.SetCursorPosition(bullets[bullet_count].position_x, bullets[bullet_count].position_y);
            Console.Write(bullet);
            bullet_count++;
        }

        static void Move_Enemy_Bullets(bullet[] bullets, int bullet_count, char bullet, char[,] maze, int spaceship_position_x, int spaceship_position_y, ref int health)
        {
            for (int current_bullet = 0; current_bullet < bullet_count; current_bullet++)
            {
                if (Is_Bullet_Active(bullets, current_bullet))
                {
                    if (spaceship_position_x == bullets[current_bullet].position_x && spaceship_position_y == bullets[current_bullet].position_y)
                    {
                        Erase_Bullet(spaceship_position_x, spaceship_position_y);
                        Make_Bullet_InActive(bullets, current_bullet);
                        health--;
                    }
                    if (maze[bullets[current_bullet].position_y , bullets[current_bullet].position_x - 2] != 's')
                    {
                        Make_Bullet_InActive(bullets, current_bullet);
                        Erase_Bullet(bullets[current_bullet].position_x, bullets[current_bullet].position_y);  
                    }
                    else
                    {
                        Erase_Bullet(bullets[current_bullet].position_x, bullets[current_bullet].position_y);
                        bullets[current_bullet].Change_X_cord(-1);
                        Print_Bullet(bullets[current_bullet].position_x, bullets[current_bullet].position_y, bullet);
                    }
                }
            }
        }

        static void Print_Bullet(int x, int y, char bullet)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(bullet);
        }

        static void Erase_Bullet(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

        static void Move_Bullet(bullet[] bullets, int bullet_count, char bullet, char[,] maze, int enemy_x, int enemy_y, ref int health)
        {
            for (int current_bullet = 0; current_bullet < bullet_count; current_bullet++)
            {
                if (Is_Bullet_Active(bullets, current_bullet))
                {
                    if (enemy_x == bullets[current_bullet].position_x && enemy_y == bullets[current_bullet].position_y)
                    {
                        Erase_Bullet(bullets[current_bullet].position_x, bullets[current_bullet].position_y);
                        Make_Bullet_InActive(bullets, current_bullet);
                        health--;
                    }
                    if (maze[bullets[current_bullet].position_y, bullets[current_bullet].position_x + 2] != 's')
                    {
                        Erase_Bullet(bullets[current_bullet].position_x, bullets[current_bullet].position_y);
                        Make_Bullet_InActive(bullets, current_bullet);
                    }
                    else
                    {
                        Erase_Bullet(bullets[current_bullet].position_x, bullets[current_bullet].position_y);
                        bullets[current_bullet].Change_X_cord(+1);
                        Print_Bullet(bullets[current_bullet].position_x, bullets[current_bullet].position_y, bullet);
                    }
                }
            }
        }

        static void Make_Bullet_InActive( bullet[] bullets, int bullet_index)
        {
            bullets[bullet_index].Make_Bullet_InActive();
        }

        static bool Is_Bullet_Active( bullet[] bullet, int bullet_index)
        {
            bool Is_active = bullet[bullet_index].Is_Bullet_Active();
            return Is_active;
        }

        static void Move_SpaceShip_Down(spaceship Death_Star, char [,] maze)
        {
            if (maze[Death_Star.position_y, Death_Star.position_x+1] == 's')
            {
                erase_spaceship(Death_Star);
                Death_Star.Change_Y_Cord(+1);
                Print_spaceship(Death_Star);
            }
        }


        static void Move_SpaceShip_Up(spaceship Death_Star, char [,] maze)
        {
            if (maze[Death_Star.position_y, Death_Star.position_x-1] == 's')
            {
                erase_spaceship(Death_Star);
                Death_Star.Change_Y_Cord(-1);
                Print_spaceship(Death_Star);
            }
        }

        static void Move_SpaceShip_Left(spaceship Death_Star, char [,] maze)
        {
            if (maze[Death_Star.position_y-1, Death_Star.position_x] == 's')
            {
                erase_spaceship(Death_Star);
                Death_Star.Change_X_cord(-1);
                Print_spaceship(Death_Star);
            }
        }

        static void Move_SpaceShip_Right(spaceship Death_Star,char [,] maze)
        {
            if (maze[Death_Star.position_y + 1, Death_Star.position_x] == 's')
            {
                erase_spaceship(Death_Star);
                Death_Star.Change_X_cord(+1);
                Print_spaceship(Death_Star);
            }
        }

        static void erase_spaceship (spaceship spaceship)
        {
            int y = spaceship.position_y;
            for (int row = 0; row < 3; row++)
            {
                Console.SetCursorPosition(spaceship.position_x, y);
                for (int column = 0; column < 2; column++)
                {
                    Console.Write(' ');
                }
                y++;
            }
        }
    }
}
