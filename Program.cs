using System;
using System.Net.NetworkInformation;
using System.Security.Principal;

namespace Module_1_Review_Exercise___C_
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a while loop that allows user to have at least 5 attempts to compute a shape's area
            //Establishes the variable 'i' that serves as a 'counter' for attempts within the program
            int i = 5; 
            while (i > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"You have {i} attempts remaining");
                Console.WriteLine("Type the name of 1 shape whose area you want to caculate: circle, triangle, rectangle, or square.");
                Console.WriteLine();

                i--;

                //Turns user's input into a variable
                string userInput = Console.ReadLine();


                //Begins the selection statement, which provides the logic for the user to type in the name of the shape to compute
                //Creates 'userInput' variable


                if (userInput == "circle")


                // AREA of a CIRCLE

                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("AREA of a CIRCLE:");
                    Console.WriteLine();

                    // Code to ask the user to provide input

                    Console.WriteLine("Enter a number for the circle's RADIUS: ");

                    //Create a variable called 'radius'
                    //Converting user input to the 'double' variable type

                                                         
                    double radius = double.Parse(Console.ReadLine());
                    

                    
                
                    //Calling the method 'CircleArea' and printing the method's result to the console
                    Console.WriteLine($"The circle's area = {CircleArea(radius)}");
                   

                }

                else if (userInput == "triangle")

                // AREA of a TRIANGLE

                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("AREA of a TRIANGLE:");

                    Console.WriteLine();
                    //Code to ask the user to provide input
                    Console.WriteLine("Enter a number for the triangle's BASE: ");

                    //Converting the user's input into double format
                    //Obtaining inputs for the method's parameters by using variables: baseLength & height
                    double baseLength = double.Parse(Console.ReadLine());


                    Console.WriteLine("Enter a number for the triangle's HEIGHT: ");


                    double height = double.Parse(Console.ReadLine());

                    //Calling the method 'TriangleArea' and displaying the result to the console
                    Console.WriteLine($"The triangle's area = {TriangleArea(baseLength, height)}");


                }

                else if (userInput == "rectangle")

                //AREA of a RECTANGLE

                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("AREA of a RECTANGLE:");

                    Console.WriteLine();

                    Console.WriteLine("Enter a number for the rectangle's LENGTH: ");

                    //Converts user inuput into double variable type
                    //Creates variables 'length' and 'width'
                    double length = double.Parse(Console.ReadLine());


                    Console.WriteLine("Enter a number for the rectangle's WIDTH: ");


                    double width = double.Parse(Console.ReadLine());

                    //Calling the method 'RectangleArea' and displaying the result to the console
                    Console.WriteLine($"The rectangle's area =  {RectangleArea(length, width)}");


                }

                else if (userInput == "square")

                // AREA of a SQUARE

                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("AREA of a SQUARE:");
                    Console.WriteLine();

                    // Code to ask the user to provide input

                    Console.WriteLine("Enter a number for the square's side: ");

                    //Create a variable called 'side'
                    //Converting user input to the 'double' variable type

                    double side = double.Parse(Console.ReadLine());

                    //Calling the method 'SquareArea' and printing the method's result to the console

                    Console.WriteLine($"The circle's area = {SquareArea(side)}");


                }
                //Creating the final selection statement, which provides a message for any user input not in correct format
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("START OVER and re-enter the shape's name in the correct format.");
                    Console.WriteLine();
                }
            }


        }
        // All Methods were placed in the Class of the Project
        // Creating the method 'CircleArea' within the class of the project
        static double CircleArea(double radius)

        {

            // Coding the body of the method to calculate the area, using 'radius' as a parameter

            return (Math.PI) * Math.Pow(radius, 2);

        }

        // Creating the method 'TriangleArea' within the class of the project

        static double TriangleArea(double baseLength, double height)
        {
            //Codeblock for the TriangleArea method to calculate area
            //TriangleArea method uses 2 parameters: baseLength and height

            return (baseLength / 2) * height;

        }

        //Creating the method 'RectangleArea' within the class of the project

        static double RectangleArea(double length, double width)
        {
            //Codeblock for the RectangleArea method to calculate area
            //RectangleArea method uses 2 parameters: length and width

            return length * width;

        }

        //Creating the method 'SquareArea' within the class of the project
        static double SquareArea(double side)
        {
            //Codeblock for the SquareArea method to calculate area
            //SquareArea method uses 1 parameter: side

            return Math.Pow(side, 2);

        }

    }




}
