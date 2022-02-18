using System;
using System.Collections.Generic;

namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Here you can write console prints to test your implementation outside the testing environment");
           
            Stack<int> numbers = new Stack<int>();
            numbers.Push(26);
            numbers.Push(3);
            numbers.Push(6);
            numbers.Push(5);

       
            numbers=TestMethods.GetNextGreaterValue(numbers);
            while (numbers.Count != 0)
            {
                
                int  p = numbers.Pop();
                Console.WriteLine(p);
                
            }


        }
    }    
}
