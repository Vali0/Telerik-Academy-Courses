using System;

class HowOldWillUBe
{
    static void Main(string[] args)
    {
        int age = 0; //Defining and initializing variable with default value

        do          //Loop starts here
        {
            Console.WriteLine("Enter your age: "); //Printing message to user
            age = int.Parse(Console.ReadLine()); //Getting user choice
        }
        while (age == 0); //Loop ends here (when age!=0)
        Console.WriteLine("Your age now is: " + age); //Printing user age
        age += 10; //Calculating new age after 10 years
        Console.WriteLine("After ten years your age will be: " + age); //Printing the new age
    }
}
