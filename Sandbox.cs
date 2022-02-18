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



            Stack<int>  numbers1 =TestMethods.GetNextGreaterValue(numbers);

            Console.WriteLine("el ultimo numero es " + numbers.Peek());
            while (numbers1.Count != 0)
            {
                int  p = numbers1.Pop();
                Console.WriteLine(p);
            }
            Console.WriteLine("Hello world");
            

        }
    }    
}
