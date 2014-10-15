using System;

class PrintingASequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i < 12; i++)     //Loop starts here
        {
            if (i % 2 == 0)              //If the member of the sequence is even
                Console.Write(i + " ");  //Printing the member
            else                         //If the member of the sequence is odd
                Console.Write(-i + " "); //Printing negative value of the member
        }

    }
}
