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
			ListNode n2 = new ListNode (2);
			ListNode n3 = new ListNode (3);
			ListNode n4 = new ListNode (4);
			ListNode n5 = new ListNode (5);


			RemoveNthNode r = new RemoveNthNode ();

			var head = r.RemoveNthFromEnd (n1, 1);
			while (head != null) {
				Console.WriteLine (head.val);
				head = head.next;
			}
		
		}
	}
}
