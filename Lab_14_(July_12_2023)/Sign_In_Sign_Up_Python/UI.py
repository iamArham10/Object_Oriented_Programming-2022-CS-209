# This file contains functions that prints headers and options on console
# Creating a header function
class UI:
    @staticmethod
    def Print_Header():
        print("<--------------------------------------->")
        print("<----------Sign In Sign Up-------------->")
    @staticmethod
    # Creating a function that takes option from user
    def Take_Option():
        print("1. Sign In.")
        print("2. Sign Up.")
        print("3. Print Users.")
        print("4. Exit.")
        option = int(input("Select From Above Options "))
        return option
    @staticmethod
    # sign_in header
    def Print_Sign_In_Header():
        print("<--------------------------------------->")
        print("<----------------Sign In---------------->")
