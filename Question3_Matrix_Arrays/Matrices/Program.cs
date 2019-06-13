using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {   //Name: Anya Webb
        //Student ID: 9946386
        static void Main(string[] args)
        {            
            Random rand = new Random(); //Creating a random number generator for the arrays
            Console.WriteLine("-------------Welcome-------------"); // Intro message
            Console.WriteLine("This is a Random Matrix Generator\n");
            Console.WriteLine("Press enter to display the first matrix");
            Console.ReadLine();

            Console.WriteLine("Matrix A:"); //Title for Matrix A
            int[,] a = new int[3,3]; //Creating the 3x3 array
            for (int x = 0; x < 3; x++) //Creating the loop to count through the array
            {
                for (int y = 0; y < 3; y++)
                {
                    a[x, y] = rand.Next(-10, 10); //Calling the random number generating and making it between -10 and 10                    
                    Console.Write("{0}\t",a[x,y]); //Displaying the matrix       
                }
                Console.WriteLine(); //Write line to put the row on a new line
            }
            Console.WriteLine("\nPress enter to display the second matrix");
            Console.ReadLine();

            Console.WriteLine("Matrix B:"); //Title for Matrix B
            int[,] b = new int[3, 3]; //Creating the 3x3 array
            for (int x = 0; x < 3; x++) //Creating the loop to count through the array
            {
                for (int y = 0; y < 3; y++) 
                {
                    b[x, y] = rand.Next(-10, 10); //Calling the random number generating and making it between -10 and 10
                    Console.Write("{0}\t", b[x, y]); //Displaying the matrix
                }
                Console.WriteLine(); //Write line to put the row on a new line
            }
            Console.WriteLine("\nPress enter to add the two matrices together");
            Console.ReadLine();

            Console.WriteLine("Matrix C:"); //Title for Matrix C
            int[,] c = new int[3, 3]; //Creating the 3x3 array
            for (int x = 0; x < 3; x++) //Creating the loop to count through the array
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write("{0}\t", a[x, y] + b[x, y]); //Adding matrix a and matrix b together and showing the results
                }
                Console.WriteLine(); //Write line to put the row on a new line
            }
            Console.WriteLine("\n-----------Thank you-----------");
            Console.WriteLine("Press enter to exit the program");
            Console.ReadLine();

        }
    }
        
}

