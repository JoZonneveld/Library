﻿using System;

namespace C_Lib
{
    class Program
    {
        static void Main(string[] args)
        {
            ILinkedList<string> test = new Node<string>("test", new Node<string>("test1", new Empty<string>()));   

            while (!test.IsEmpty())
            {
                System.Console.WriteLine(test.Value);

                test = test.Tail;
            }
        }
    }
}
