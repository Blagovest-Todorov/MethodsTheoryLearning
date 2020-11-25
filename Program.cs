using System;

namespace _01.MethodTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            //console.ReadLine(); returns a string
            //float price = GetPrice() * quantity * 1.20 ; //can be used in expression
            //can be used to another method
            int age = int.Parse(Console.ReadLine()); //used into /to another method Console.ReadLine() -returns string
                                                     //this strong is passed to method int.Parse and int.Parse returns number
                                                     // if we want to retur a value we then dotn write "void" --we write return keyword, and we specify: 
                                                     //the type of data that our method will return
                                                     //
            static int Multiply(int firstNum, int secondNum)
            {
                return firstNum * secondNum; //return means give us back a value;
                                             // in return keyword it is importatn to return the same typeor compatible to  method type;
                                             //Method type here is int -then we return a value result in  type result;

                //the combination of methods name + methods parameters is called methods signature//method signature
                //method signature = methods name + methods parameters , so we call them-methods signature;
            }
        }
}
