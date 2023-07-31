# importing User class from Userfile
from User import User
# importing operating system paths
import os.path
'''This program contains Data layer of User'''
# Creating a class userDl that contains user data related function
class UserDL:

    # Creating a list that saves users
    users = []

    # Creating a function that checks returns user if it is present
    @staticmethod
    def Return_User(user):
        for storeduser in UserDL.users: # in keyword helps us loops through each variable in users list
            # condition checks if user given in parameter is present in users list
            if storeduser.username == user.username and storeduser.password == user.password:
                return storeduser
        # is no user is found None will be returned
        return None
    
    # Creating a static function that adds user to list
    @staticmethod
    def Add_User(user):
        # if user is not present
        if (UserDL.Return_User(user) == None):
            # adds the use to the list
            UserDL.users.append(user)
    
    # this function returns requested data separated by comma
    @staticmethod
    def SeparateData(line):
        line = line.split(",")
        # returns multiple strings
        return line[0], line[1], line[2]

    # Read user Data from file
    @staticmethod
    def Read_UserData(path):
        # if file exists
        if (os.path.exists(path)):
            filevar = open(path, 'r') # r is for read mode
            records = filevar.read().split(',') # split("\n") splits lines at null char
            filevar.close
            for line in records:
                if line == '':continue
                username, password, role = UserDL.SeparateData(line)
                # creating a new user
                newuser = User(username, password, role)
                # adding the user to users list
                UserDL.Add_User(newuser)
                return True
        return False
 
    def Save_User(user, path):
        # checks if file exists
        if (os.path.exists(path)):
            filevar = open(path, 'a') # append is for append mode
            # saves the credentials of user 
            filevar.write("\n" + user.username + "," + user.password + "," + user.isadmin)
            filevar.close
            return True
        # if file doesn't exists return false
        return False
        

    
    
    
    


        
