using System;
//Create a class. In that class, create a void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the second integer to the screen.

//In the Main() method of the console app, instantiate the class.

//Call the method in the class, passing in two numbers.

//Call the method in the class, specifying the parameters by name.

//PART TWO BELOW 

//Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.

//In the Main() method, instantiate that class.

//Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.

//Create a method with output parameters.

//Overload a method.

//Declare a class to be static


namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Grape = new Class1();




            Console.WriteLine("Please enter a number to be used in the program");
            int answer1 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Please enter a second number to be used in the program. NOT REQUIRED");
                int answer2 = Convert.ToInt32(Console.ReadLine());
                int result = Grape.Method1(answer1, answer2);
                Console.WriteLine("Your two numbers ran through the program return " + result);
            }
            catch
            {
                int result = Grape.Method1(answer1);
                Console.WriteLine("The result of your number is " + result);
                Console.ReadLine();
            }
        }
    }
}
