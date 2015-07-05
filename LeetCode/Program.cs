using System;

namespace LeetCode
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			char[,] input = new char[9,9] {
//				{'7','2','.','.','3','9','.','.','6'},
//				{'.','.','.','.','5','.','3','.','1'},
//				{'.','.','.','.','.','7','.','.','5'},
//				{'.','.','.','.','.','.','1','.','.'},
//				{'9','.','6','.','.','.','.','.','2'},
//				{'.','3','.','.','.','.','5','.','.'},
//				{'3','7','.','.','.','4','8','.','.'},
//				{'6','.','8','9','7','.','.','3','.'},
//				{'5','.','.','.','.','.','.','.','.'}
//			};

			ListNode n1 = new ListNode (3);
			ListNode n2 = new ListNode (2);
			ListNode n3 = new ListNode (0);
			ListNode n4 = new ListNode (-4);
			ListNode n5 = new ListNode (1);
			ListNode n6 = new ListNode (22);
			ListNode n7 = new ListNode (-1);
			ListNode n8 = new ListNode (-2);
			ListNode n9 = new ListNode (-3);
			ListNode n10 = new ListNode (4);
			ListNode n11 = new ListNode (-5);
			ListNode n12 = new ListNode (-6);

			n1.next = n2;
			n2.next = n3;
			n3.next = n4;
			n4.next = n5;
			n5.next = n6;
			n6.next = n7;
			n7.next = n8;
			n8.next = n9;
			n9.next = n10;
			n10.next = n11;
			n11.next = n12;
			n12.next = n6;

			Cycle c = new Cycle ();

			Console.WriteLine (c.DetectCycle(n1).val);
		}
	}
}
