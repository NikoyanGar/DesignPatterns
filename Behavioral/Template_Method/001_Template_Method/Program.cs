﻿namespace _001_Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());
        }
    }
}
