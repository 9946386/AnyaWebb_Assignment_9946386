using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1_Methods
{   //Name: Anya Webb
    //Student ID: 9946386

    class Program
    {
        static void Main(string[] args)
        {
            bool _username = true; 
            bool _password = true;

            //Welcome message
            Console.WriteLine("Rotorua Thermal Holiday Park");
            Console.WriteLine("--------Login System--------");
            Console.WriteLine("Please enter details below..");

            //Stating requirments for username and password
            Console.WriteLine("\nUsername requirements: Must be 8 characters or more.");
            Console.WriteLine("Password requirements: Both passwords must match and be 8 characters or more.\n");


            while (_username) //While loop for username input
            {
                Console.Write("Please enter your username: "); //Asking user for username
                string username = Console.ReadLine(); //Assigning the username a variable
                _username = validateUsername(username); //Calling the method useing the username provided

                //If statement to check that the username is valid                
                if (_username == false) //If username is false (valid) run...
                {
                    Console.WriteLine("That is a valid username\n");
                }
                
                else //If it is anything else run...
                {
                    Console.WriteLine("That is an invalid username, please try again.\n");
                }
            }
            while (_password)
            {
                Console.Write("Please enter your password: "); //Asking user for first password
                string password1 = Console.ReadLine(); //Assigning the first password a variable
                Console.Write("Please re-enter your password: "); //Asking user for the second password
                string password2 = Console.ReadLine(); //Assigning the second password a variable
                _password = validatePassword(password1, password2); //Calling the method using the two passwords provided   
            }

            Console.ReadLine();
        }

        //Validate username method to check that username meets requirements
        public static bool validateUsername(string username)
        {
            if (username.Length >= 8) //If the username is 8 characters or more run..
            {                
                return false; //Valid
            }
            
            else //If it does not meet requirements run..
            {
                return true; //Invalid
            }
        }

        //Validate Password method to check that both passwords meet requirements
        public static bool validatePassword(string input1, string input2)
        {
            if (input1.Length >= 8 && input1 == input2) //If the first password is longer than 8 characters and the two passwords match run..
            {
                Console.WriteLine("\n-------------------Thank you--------------------\n" +
                                  "Username and Password have been accepted and set"); //Message to run if valid                
                return false; //Valid
            }


            else //If passwords don't meet requirements run..
            {
                Console.WriteLine("Those passwords were invalid please try again.\n"); //Error message for invalid passwords
                return true; //Invalid
            }
        }
    }
        
}
