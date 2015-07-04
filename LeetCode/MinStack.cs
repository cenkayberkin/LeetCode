//TODO: 155 Question
using System;

namespace LeetCode
{
	public class MinStack {
		long[] list ;
		long[] minStack;

		long min = long.MaxValue;
		long top = 0;

		public MinStack()
		{
			list = new long[10];
			minStack = new long[10];
		}

		public void Push(int x) 
		{
			list [top] = x;
			if (x < min) {
				min = x;
				minStack [top] = min;
			} else {
				minStack [top] = min;
			}
			top += 1;
		}

		public void Pop() {
			top -= 1;
			if (top < 0) {
				top = 0;
			}

			if (top == 0) {
				min = int.MaxValue;
			} else {
				min = GetMin ();
			}

			list [top] = 0;
			minStack [top] = 0;

		}

		public int Top() {
			if (top == 0) {
				return (int)list [0];

			}
			return (int)list [top -1];
		}

		public int GetMin() {
			if (top == 0) {
				return (int)minStack [top];	
			}
			return (int)minStack [top -1];
		}
	}
}

