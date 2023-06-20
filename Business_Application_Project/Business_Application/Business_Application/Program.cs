// See https://aka.ms/new-console-template for more information
using Business_Application;
using Business_Application.DL;
using System.Net.Sockets;

// XY coordinates represents where to output data on console
int X_coordinate_menu = 40;
int Y_coordinate_menu = 8;
// reads user credentials from file
UserDL.Load_Users();
// reads medicine data
MedicineDL.Read_Medicine_Data();


// application
char option;
do
{
    // if user has signed in user_signin will become true
    // then user menu options will be shown
    bool user_signedIn = false;
    User app_user = null;
    // prints the main menu on screen and takes option input from user
    MainUI.Clear_Screen();
    MainUI.Print_Header();
    option = MainUI.Main_Menu(X_coordinate_menu, Y_coordinate_menu);
    // -------------------------------------<Sign In Sign Up >-----------------------------------------------
    if (option == '1')
    {
        MainUI.Clear_Screen();
        MainUI.Print_Header();
        // inputs user credentials from user and creates a user with that name
        app_user = UserUI.Get_User(X_coordinate_menu , Y_coordinate_menu);
        // verifies user from users list 
        app_user = UserDL.Varify_User(app_user);

        if (app_user != null)
        {
            // if user signed in isn't null than user is valid
            user_signedIn = true;
            MainUI.Write_Message("Valid Credentials Logging In", X_coordinate_menu, Y_coordinate_menu + 4);
        }
        else if (app_user == null)
        {
            // if user not valid 
            MainUI.Write_Message("Invalid Credentials", X_coordinate_menu, Y_coordinate_menu + 4);
            user_signedIn = false;
        }
    }


    // ---------------------------------------< Application >-------------------------------------------------
    // is user has signin succesfully then user_signedIn bool will be true so program will run further
    if (user_signedIn == true)
    {
        do
        {
            option = '\0';
            MainUI.Clear_Screen();
            // prints main_menu_option
            MainUI.Print_Header();
            // takes main menu option input from user
            option = MainUI.Main_Menu_Options(X_coordinate_menu, Y_coordinate_menu);
            // take Order
            if (option == '1')
            { 
                MainUI.Clear_Screen();
                MainUI.Print_Header();
                bool isavailable = false;
                if(app_user.Is_Function_Present("TakeOrder"))
                {
                    isavailable = true;
                }
                if (isavailable)
                {
                    Order order = OrderUI.Take_Order(5, Y_coordinate_menu);
                    if (order != null) // checks if any order is taken
                    {
                        OrderDL.Save_Order(order);
                        MedicineDL.Sale_Medicines(order);
                        Console.Clear();
                        MainUI.Print_Header();
                        OrderUI.Print_Order_Receipt(order, 5, Y_coordinate_menu);
                        Console.ReadKey();
                    }
                }
                
            }
            // Creates Medicine Option
            if (option == '2') 
            {
                MainUI.Clear_Screen();
                MainUI.Print_Header();
                bool isavailable = false;
                if (app_user.Is_Function_Present("AddMedicine"))
                {
                    isavailable = true;
                }
                if (isavailable)
                {
                    // takes new medicine data from user and returns a medicine with that name if medicine doesn't already exists with that name
                    Medicine newMedicine = MedicineUI.Create_Medicine(X_coordinate_menu, Y_coordinate_menu);
                    if (newMedicine != null)
                    {
                        // adds medicine to medicines list
                        MedicineDL.Add_Medicine(newMedicine);
                        // saves medicine on file
                        MedicineDL.Save_Single_Medicine(newMedicine);
                    }
                }   
            }
            // View All Medicines
            if (option == '3')
            {
                MainUI.Clear_Screen();
                MainUI.Print_Header();
                bool isavailable = false;
                if (app_user.Is_Function_Present("ViewMedicine"))
                {
                    isavailable = true;
                }
                if (isavailable)
                {
                    // printings all medicines
                    MedicineUI.View_Medicines(X_coordinate_menu, Y_coordinate_menu);
                }
                
            }
            // Remove Medicine or medicine weight
            if (option == '4')
            {
                MainUI.Clear_Screen();
                MainUI.Print_Header();
                bool isavailable = false;
                if (app_user.Is_Function_Present("RemoveMedicine"))
                {
                    isavailable = true;
                }
                if (isavailable)
                {
                    do
                    {
                        MainUI.Clear_Screen();
                        MainUI.Print_Header();

                        option = '\0';
                        // inputs Remove Medicine 
                        option = MainUI.Print_Remove_Medicine_Option(X_coordinate_menu, Y_coordinate_menu);
                        if (option == '1')
                        {
                            MainUI.Clear_Screen();
                            MainUI.Print_Header();
                            // remove complete medicine
                            if (MedicineUI.Remove_Medicine_Complete(X_coordinate_menu, Y_coordinate_menu))
                            {
                                MedicineDL.Save_All_Medicines();
                            }
                        }
                        if (option == '2') // remove medicine weight
                        {
                            MainUI.Clear_Screen();
                            MainUI.Print_Header();
                            // ask user medicine name and weight number to remove
                            // removes the weight if input is valid
                            if (MedicineUI.Remove_Medicine_Weight(X_coordinate_menu, Y_coordinate_menu))
                            {
                                MedicineDL.Save_All_Medicines();
                            }
                        }

                    }
                    while (option != '0');
                }
                
            }  
            if (option == '5') // add medicine weight
            {
                MainUI.Clear_Screen();
                MainUI.Print_Header();
                bool isavailable = false;
                if (app_user.Is_Function_Present("AddMedicineWeight"))
                {
                    isavailable = true;
                }
                if (isavailable)
                {
                    // function takes medicine name searches medicine takes medicine weight 
                    // returns true if weight is added succesfully
                    bool isWeightAdded = MedicineUI.Add_Medicine_Weight(X_coordinate_menu, Y_coordinate_menu);
                    if (isWeightAdded == true)
                    {
                        MainUI.Clear_Screen();
                        MainUI.Print_Header();
                        MainUI.Write_Message("Medicine Weight Added Succesfully", X_coordinate_menu, Y_coordinate_menu);
                        MedicineDL.Save_All_Medicines();

                    }
                    else
                    {
                        MainUI.Clear_Screen();
                        MainUI.Print_Header();
                        MainUI.Write_Message("Invalid Input", X_coordinate_menu, Y_coordinate_menu);
                    }
                }            
            }
            if (option == '6') // change medicine price
            {
                
                MainUI.Clear_Screen();
                MainUI.Print_Header();
                bool isavailable = false;
                if (app_user.Is_Function_Present("ChangePrice"))
                {
                    isavailable = true;
                }
                if (isavailable)
                {
                    bool isPrice_Changed = MedicineUI.Change_Medicine_Price(X_coordinate_menu, Y_coordinate_menu);
                    if (isPrice_Changed)
                    {
                        MainUI.Clear_Screen();
                        MainUI.Print_Header();
                        MainUI.Write_Message("Medicine Price Changed Succesfully", X_coordinate_menu, Y_coordinate_menu);
                        MedicineDL.Save_All_Medicines();
                    }
                    else
                    {
                        MainUI.Clear_Screen();
                        MainUI.Print_Header();
                        MainUI.Write_Message("Invalid Input", X_coordinate_menu, Y_coordinate_menu);
                    }
                }
                   
            }
            if (option == '7') // add medicine Stock
            {
                MainUI.Clear_Screen();
                MainUI.Print_Header();
                bool isavailable = false;
                if (app_user.Is_Function_Present("AddStock"))
                {
                    isavailable = true;
                }
                if (isavailable)
                {
                    if (MedicineUI.Add_Medicine_Stock(X_coordinate_menu, Y_coordinate_menu))
                    {
                        MedicineDL.Save_All_Medicines();
                    }
                }      
            }
            if (option == '8')
            {
                bool isavailable = false;
                if (app_user.Is_Function_Present("SeeSales"))
                {
                    isavailable = true;
                }
                if (isavailable)
                {
                    OrderUI.Print_Previous_Orders(X_coordinate_menu, Y_coordinate_menu);
                }
            }
            if (option == '9') // employee options
            {
                MainUI.Clear_Screen();
                MainUI.Print_Header();
                bool isavailable = false;
                if (app_user.Is_Function_Present("ManageEmployee"))
                {
                    isavailable = true;
                }
                if (isavailable)
                {
                    option = '\0';
                    do
                    {
                        option = UserUI.Print_Admin_Option_Employee(X_coordinate_menu, Y_coordinate_menu);
                        MainUI.Clear_Screen();
                        MainUI.Print_Header();
                        if (option == '1') // Add Employee
                        {
                            MainUI.Clear_Screen();
                            MainUI.Print_Header();
                            Employee newemployee = UserUI.Create_Employee(X_coordinate_menu, Y_coordinate_menu);
                            if (newemployee != null)
                            {
                                UserDL.Add_User(newemployee);
                            }
                        }
                        if (option == '2') // Remove Employee
                        {
                            MainUI.Clear_Screen();
                            MainUI.Print_Header();
                        }
                    } while (option != '0');
                }
                   
            }
            Console.ReadKey();
        } while (option != '0');
    }
    Console.ReadKey();
    option = '\0';

} while (option != '0');
