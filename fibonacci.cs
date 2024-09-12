// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int myNum = 10;
        int firstN = 0;
        int secondN = 1;
        
        for(int i = 0; i < myNum; i++)
        {    
            Console.Write(firstN + " ");
            int output = firstN + secondN; // 1
            firstN = secondN; // 1
            secondN = output; // 1
        }
        
    }
}