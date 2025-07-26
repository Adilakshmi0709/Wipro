using System;
class ExceptionExample
{
    static void Main()
    {

        try
        {
            int a = 10;
            int b = 0;
            int result = a / b;
            Console.WriteLine("The result is: " + result);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Cannot divide by zero and the exception is : "+e.Message);
        }
        Console.WriteLine("Normal Statement");
    }
}