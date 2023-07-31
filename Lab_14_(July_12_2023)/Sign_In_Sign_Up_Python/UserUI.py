''' UserUI Class contains functions related to input and output data from user'''
# importing user class
from User import User # this line imports UserClass from Userfile
class UserUI:

    # Taking user input
    @staticmethod
    def Sign_In():
        # inputs user name and password from user
        username = input("Enter Your Name : ")
        password = input("Enter Password : ")
        # creates User object and returns it 
        newuser = User(username, password, "NA")
        return newuser
    
    # signup function
    @staticmethod
    def Sign_Up():
        # taking username, password and usertype from user
        username = input("Enter Your Name : ")
        password = input("Enter your Password : ")
        usertype = input("Enter Usertype admin - 'Admin' or employee - 'Employee'")
        # creating a new user and returning it
        user = User(username, password, usertype)
        return user
    
    # prints all of the users on console
    @staticmethod 
    def Print_Users(users):
        for user in users:
            print("Username : " + user.username + " Password : " + user.password + " UserType : " + user.isadmin)

