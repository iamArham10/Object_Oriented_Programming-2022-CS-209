// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Person p = PersonUI.Input_Person();
Student st = StudentUI.Get_Student();
Staff staff = StaffUI.Create_Staff();
PersonDL.Add_Person(p);
PersonDL.Add_Person(st);
PersonDL.Add_Person(staff);
PersonUI.Print_Person_Info(PersonDL.Get_Person_List());
Console.ReadKey();
