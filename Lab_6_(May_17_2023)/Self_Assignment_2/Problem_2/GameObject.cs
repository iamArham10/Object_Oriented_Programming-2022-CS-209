using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class GameObject
    {
        // attributes
        public Char[, ] Shape = new char[5,3]; // printing object
        public Point StartingPoint; // printing position
        public Boundary Premises; // boundary defines the space where printing object should move
        public String Direction; // movement direction of an object
        bool Move_Direction = true; // flag determines at which direction should Shape be patrolling
        int Starting_Movement = 0; // Starting moment determines position of parabola

        // constructor
        public GameObject() // creates a default game object character array
        {
            Char[,] Shape = {{ '.', '.', '.' }};
            this.Shape = Shape;
            StartingPoint = new Point(0,0);
            Premises = new Boundary();
            Direction = "LeftToRight";
        }
        
        public GameObject(Char[,] Shape, Point SP, Boundary premises, String direction) // create a object with given parameters
        {
            this.Shape = Shape;
            this.StartingPoint = SP;
            this.Premises = premises;
            this.Direction = direction;
        }

        // methods
        public void Erase() // Prints Space of size of Shape 2d at x y coordinates
        {
            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.SetCursorPosition(StartingPoint.Get_X() + column, StartingPoint.Get_Y() + row);
                    Console.WriteLine(' ');
                }
            }
        }

        public void Print() // prints 2d array characters at x y coordinates
        {
            for(int row = 0; row < 5;row++)
            {
                for (int column= 0; column < 3; column++)
                {
                    Console.SetCursorPosition(StartingPoint.Get_X() + column, StartingPoint.Get_Y() + row);
                    Console.WriteLine(Shape[row, column]);
                }
            }
        }

        public void Move() // changes the x and y coordinates of position to print 2d array characters
        {
            if (Direction == "LeftToRight")
            {
                Move_LefttoRight();
            }

            else if (Direction == "RightToLeft")
            {
                Move_RighttoLeft();
            }

            else if (Direction == "Diagonal")
            {
                Move_Diagonal();
            }
            else if (Direction == "Patrol")
            {
                Move_Patrol();   
            }
            else if (Direction == "Projectile")
            {
                Move_Projectile();
            }
        }

        void Move_Patrol() // patrols the 2d character array printing on the screen
        {
            if (Move_Direction == true) // patrols to left side
            {
                if (StartingPoint.x == Premises.TopLeft.x) // if object reaches to the left side of boundary
                {
                    Move_Direction = false; // changes movement direction
                }
                else
                {
                    StartingPoint.x--; // decreasing x coordinate
                }
            }
            if (Move_Direction == false) // patrols to right side
            {
                if (StartingPoint.x == Premises.TopRight.x) // if object reaches to the right side of the boundary
                {
                    Move_Direction = true; // to change direction
                }
                else
                {
                    StartingPoint.x++; // increases x coordinate
                }
            }
        }

        void Move_RighttoLeft()
        {
            if (StartingPoint.x == Premises.TopLeft.x) 
            {
                StartingPoint.x = Premises.TopRight.x;
            }
            else
            {
                StartingPoint.x--;
            }
        }

        void Move_LefttoRight()
        {
            if (StartingPoint.x == Premises.TopRight.x)
            {
                StartingPoint.x = Premises.TopLeft.x;
            }
            else
            {
                StartingPoint.x++;
            }
        }

        void Move_Diagonal() // to move diagonal
        {
            if (StartingPoint.x == Premises.TopRight.x) // if object reaches to right wall of boundary
            {
                StartingPoint.Set_X(Premises.TopLeft.x + 1);
                StartingPoint.Set_Y(Premises.TopLeft.y + 1);
            }
            else if (StartingPoint.y == Premises.BottomLeft.y) // if object reaches to bottom wall of the boundary
            {
                StartingPoint.Set_Y(Premises.TopLeft.y + 1);
                StartingPoint.Set_X(Premises.TopLeft.x + 1);
            }
            else
            {
                StartingPoint.Set_XY(StartingPoint.x + 1, StartingPoint.y + 1);
            }
        }

        void Move_Projectile() // moves object in a projectile motion
        {
            if (Starting_Movement <= 5) // moves 5 steps towards top right
            {
                StartingPoint.x++;
                StartingPoint.y--;
                Starting_Movement++;
            }
            else if (Starting_Movement <= 7) // moves 2 steps towards right
            {
                StartingPoint.x++;
                Starting_Movement++;
            }
            else if (Starting_Movement >= 7 && Starting_Movement <= 11) // moves 4 steps towards bottom right
            {
                StartingPoint.x++;
                StartingPoint.y++;
                Starting_Movement++;
            }
            else
            {
                StartingPoint.x = Premises.BottomLeft.x + 2;
                StartingPoint.y = Premises.BottomLeft.y - 2;
                Starting_Movement = 0;
            }

        }
    }

}
