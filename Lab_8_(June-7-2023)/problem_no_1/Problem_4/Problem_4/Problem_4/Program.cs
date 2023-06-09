// See https://aka.ms/new-console-template for more information
using Problem_4;

Circle c = CircleUI.Create_Circle();
Rectangle r = RectangleUI.Create_Rectangle();
Square s = SquareUI.Create_Square();

ShapeDL.Add_Shape(c);
ShapeDL.Add_Shape(r);
ShapeDL.Add_Shape(s);

ShapeUI.Print_Shape(ShapeDL.Get_Shapes());