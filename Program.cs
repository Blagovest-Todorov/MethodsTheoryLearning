using System;

namespace _01.MethodTutorial
{
    class Program
    {

        static void Main(string[] args)
        {
            Multiply(1, 5);
        }
        static int Multiply(int firstNum, int secondNum)
        {

            Console.WriteLine("Hello World!"); // here we print this 
            Console.WriteLine(firstNum * secondNum);
            return firstNum * secondNum; //the program-current Method block code stops here
            Console.WriteLine("Hello World!"); //this here after return keyword is unreachable code, 

            //the program down the multiply code block is not performed;
            // return means stop give back a value result and get out of the current method;
        }
    }
