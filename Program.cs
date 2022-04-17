using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Assignment
{
    public class StackException : Exception
    {
        public StackException(String message) : base(message) { }
    }

    public class MyStack
    {
        static readonly int MAX = 4;
        int top;
        int[] stack = new int[MAX];

        public MyStack()
        {
            top = -1;
        }

        public bool Push(int data)
        {
            if (top + 1 >= MAX)
            {
                throw new StackException("Stack is full");
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }



        public int Pop()
        {
            if (top < 0)
            {
                throw new StackException("Stack is empty");
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        public void PrintStack()
        {
            if (top < 0)
            {
                throw new StackException("Stack is empty");
            }
            else
            {
                Console.WriteLine("Stack Items: ");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();

            try
            {
                myStack.Push(10);
                myStack.Push(20);
                myStack.Push(30);
                myStack.Push(40);
                myStack.Push(50);
                //myStack.Push(60);
                //myStack.Push(70);
                myStack.PrintStack();
                Console.WriteLine("Popped item : {0}", myStack.Pop());
                Console.WriteLine("Popped item : {0}", myStack.Pop());
                Console.WriteLine("Popped item : {0}", myStack.Pop());
                Console.WriteLine("Popped item : {0}", myStack.Pop());
                Console.WriteLine("Popped item : {0}", myStack.Pop());
                myStack.PrintStack();
                Console.ReadKey();



            }
            catch (StackException e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
            Console.WriteLine("End of Main Method");
            
        }
    }
}
