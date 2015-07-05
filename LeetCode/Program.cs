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

			ListNode n1 = new ListNode (1);
			ListNode n2 = new ListNode (5);
			ListNode n3 = new ListNode (10);
			ListNode n4 = new ListNode (15);

			ListNode n7 = new ListNode (2);
			ListNode n8 = new ListNode (3);
			ListNode n9 = new ListNode (7);
			ListNode n10 = new ListNode (12);
			ListNode n11 = new ListNode (16);
			ListNode n12 = new ListNode (32);

			n1.next = n2;
			n2.next = n3;
			n3.next = n4;

			n7.next = n8;
			n8.next = n9;
			n9.next = n10;
			n10.next = n11;
			n11.next = n12;


			ListNode specialNode = new ListNode (0);

			ListMerger m = new ListMerger ();
			var start = m.MergeTwoLists (null, specialNode);

			while (start != null) {
				Console.WriteLine (start.val);
				start = start.next;
			}

		}
	}
}
