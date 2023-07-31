''' user class'''
# Creating a class of user
class User:
    # Attributes of user class
    username = ""
    password = ""
    isadmin = "NA"

    # Constructor of user class
    # assigns attributes username and password and isAdmin given in arguments
    # of
    def __init__(self, username, password, isadmin):
        self.username = username
        self.password = password
        self.isadmin = isadmin
    # assigns attribute username and password of object  given in parameters
    # # isadmin attribute sets to default
    # def __init__(self, username, password):
    #     self.username = username
    #     self.password = password

    # a function that checks if user is admin 
    def Is_Admin(self):
        if self.isadmin == "Admin":
            return True
        return False