﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    internal class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue program using Linked List");
            CallStackQueue();
            Console.ReadLine();
        }
        /// <summary>
        /// Calls the stack queue.
        /// </summary>
        public static void CallStackQueue()
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("\nEnter your option!");
                Console.WriteLine("1=Stack , 2=Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("<---Creating A Stack---> \n");
                        linkedListStack.Push(70);
                        linkedListStack.Push(30);
                        linkedListStack.Push(56);
                        linkedListStack.Display();
                        Console.WriteLine("\n<---PeekOperationInStack--->\n");
                        linkedListStack.Peek();
                        linkedListStack.Display();
                        Console.WriteLine("\n<---PopOperation--->\n");
                        linkedListStack.Pop();
                        linkedListStack.Display();
                        Console.WriteLine("\n<---PopTillStackBecomesEmpty--->\n");
                        linkedListStack.IsEmpty();
                        linkedListStack.Display();
                        break;
                    case 2:
                        CONTINUE = false;
                        break;
                    default:
                        Console.WriteLine("Enter correct option!");
                        break;
                }
            }
        }
    }
}
