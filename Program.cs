﻿using System;

namespace structures_c_
{   
    class Program
    {
     static void Main(string[] args)
        {
            LinkedLIsts<int> Lists = new LinkedLIsts<int>();
            Lists.Add(12);
            Lists.Add(6);
            Lists.Add(64);
            Lists.Add(124);
            Lists.Add(256);
            Lists.Add(512);
            Lists.Add(1084);
            //System.Console.WriteLine(Lists.Size() + " test");
            //System.Console.WriteLine(Lists.Get(3));

            CustomQueue<int> Queuery = new CustomQueue<int>();

            Queuery.Add(14);
            Queuery.Add(18);
            Queuery.Add(19);
            Queuery.Add(20);
            Queuery.Add(21);
            //Queuery.Peek();
            //System.Console.WriteLine(Queuery.QueueSize() + " - QueueSize");
            //Queuery.Peek();
            Queuery.Remove();
            //System.Console.WriteLine(Queuery.QueueSize() + " - QueueSize 2 2 2 2");

            StackBasedOnArray<int> StackOnArray = new StackBasedOnArray<int>();

            StackOnArray.Push(15);
            StackOnArray.Push(20);
            StackOnArray.Push(25);

            StackOnArray.Pop();
            StackOnArray.Pop();
            int StackItem = StackOnArray.Pop();
            System.Console.WriteLine("Stack item: " + StackItem);

            StackOnArray.Push(30);
            StackOnArray.Push(35);

            System.Console.WriteLine("Stack size: " + StackOnArray.Size());
        }
    }
}
