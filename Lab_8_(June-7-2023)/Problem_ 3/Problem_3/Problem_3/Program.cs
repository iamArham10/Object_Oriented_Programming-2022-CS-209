// See https://aka.ms/new-console-template for more information
using Problem_3;

Animal newanimal = AnimalUI.Create_Animal();
Dog newdog = DogUI.Create_Dog();
Cat newcat = CatUI.Create_Cat();
AnimalDL.Add_Animal(newanimal);
AnimalDL.Add_Animal(newdog);
AnimalDL.Add_Animal(newcat);
Mammal mammal = new Mammal("mammal");
List<Mammal> mammals = new List<Mammal>();
mammals.Add(mammal);
mammals.Add(newcat);
Console.WriteLine("generalizing mammal as mammal then calling greet function");
mammals[0].greets();
Console.WriteLine("generalizing cat as mammal then calling greet function");
mammals[1].greets();
Console.WriteLine("generalizing as animal class and printing cat dog and animal object");
AnimalUI.Print_Animal(AnimalDL.Get_Animals_List());
Console.ReadKey();