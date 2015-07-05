using System;

namespace LeetCode
{
	public class ReverseInteger
	{
		public ReverseInteger ()
		{
		}

		public int Reverse(int x) 
		{
			bool isNegative = false;

			if (x < 0) {
				isNegative = true;
			}

			char[] num;
			if (isNegative) {
				num = x.ToString ().Substring(1).ToCharArray();
			} else {
				num = x.ToString ().ToCharArray();
			}

			int end = num.Length - 1;
			int middle = num.Length / 2;

			for (int i = 0; i < middle; i++) 
			{
				swap (num, i, end - i);
			}

			var reversedInt = "";

			foreach (var item in num) {
				reversedInt += item;
			}

			long result = long.Parse (reversedInt);
			if (result > int.MaxValue) 
			{
				result = 0;	
			}

			int finalResult = (int)result;

			if (isNegative) 
			{
				return finalResult * -1;	
			}
			return finalResult;
		}

		void swap(char[] array,int s, int e)
		{
			char tmp = array [s];
			array [s] = array [e];
			array [e] = tmp;
		}
	}
}

