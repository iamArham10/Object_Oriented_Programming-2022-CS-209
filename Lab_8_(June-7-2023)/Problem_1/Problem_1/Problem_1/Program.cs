// See https://aka.ms/new-console-template for more information
using Problem_1;
// function to print Cylinder Area
void Print_Cylinder(Cylinder c)
{
    Console.WriteLine(c.Get_Cylinder_Area());
}

// creating cylinder objects
Cylinder c1 = new Cylinder();
c1.Set_Height(5.4);
c1.Set_Radius(10);
c1.Set_Color("Blue");
Cylinder c2 = new Cylinder(5.4, 20, "Red");
Cylinder c3 = new Cylinder(3.4, 12);
c3.Set_Color("Yellow");

// printing attributes of Cylinder
Print_Cylinder(c1);
Print_Cylinder(c2);
Print_Cylinder(c3);
Console.ReadKey();
