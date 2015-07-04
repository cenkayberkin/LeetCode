using System;

namespace LeetCode
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ContainsDup d = new ContainsDup ();
			int[] list = new int[5]{ 1,2,3,4,5};

			Console.WriteLine (d.ContainsDuplicate (list));
		}
	}
}
