using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOPClassAssignment
{
	internal class MyStack
	{


		readonly int MAX = 1000;
		int top;
		int[] stack = new int[1000];

		public MyStack()
		{
			top = -1;
		}
		public bool Push(int data)
		{
			if (top + 1 >= MAX)
			{
				Console.WriteLine("Stack is Full");
				return false;
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
				Console.WriteLine("Stack is Empty");
				return 0;
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
				Console.WriteLine("Stack is empty");
				return;
			}
			else
			{
				Console.WriteLine(" Stack  Items are :");
				for (int i = top; i >= 0; i--)
				{
					Console.WriteLine(stack[i]);
				}
			}
		}



		static void Main(string[] args)
		{
			MyStack myStack = new MyStack();

			myStack.Push(10);
			myStack.Push(20);
			myStack.Push(30);
			myStack.Push(40);
			myStack.Push(50);
			myStack.Push(100);
			myStack.PrintStack();
			Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
			myStack.PrintStack();
			Console.ReadKey();
		}
	}
}

