'''SignIn and SignUp Application in Python'''
# importing libraries
from UserDL import UserDL
import os
from UI import UI
from UserUI import UserUI

# Creating a main function
def main():
    # credentials file path
    path = r'C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Lab_14_(July_12_2023)\Sign_In_Sign_Up_Python\credentials.txt'
    # reading user credentials 
    if UserDL.Read_UserData(path) == True:
        print("Users added")
        input() 
    # running signin signup application
    option = 0
    while (option != 4):
        # clears the console
        os.system("cls")
        # printing header
        UI.Print_Header
        # taking option from user
        option = UI.Take_Option()
        if option == 2: # sign Up
            os.system("cls")
            # inputs user data
            newuser = UserUI.Sign_Up()
            # checks if new user is not null
            if newuser != None:
                # adding user to users list and saving user credentials to files
                UserDL.Add_User(newuser)
                if UserDL.Save_User(newuser, path) == True:
                    print("User Added Succesfully")
            else:
                print("User is not Added")


        elif option == 1: # sign In
            os.system("cls")
            # get's user credentials and checks if it present in user list
            user = UserDL.Return_User(UserUI.Sign_In())
            # if user is present user will not be None
            if (user != None):
                print("Valid Credentials")
                if user.Is_Admin:
                    print("User is Admin")
            else:
                print("Invalid Credentials")

        elif option == 3: # Prints user credentials 
            os.system("cls")
            UserUI.Print_Users(UserDL.users)
        input("Press Any Key To Continue")

# Calling Main Function Autmoatically
if __name__ == "__main__":
    main()
