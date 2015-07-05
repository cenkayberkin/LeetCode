using System;

namespace LeetCode
{
	public class ListNode 
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}
 
	public class RemoveNthNode
	{
		public ListNode RemoveNthFromEnd(ListNode head, int n) 
		{	
			var firstPointer = head;
			var secondPointer = head;

			int i = 0;
			while (i < n) {
				firstPointer = firstPointer.next;
				i += 1;
			}

			if (firstPointer == null) {
				return head.next;
			}

			while (firstPointer.next != null) {
				firstPointer = firstPointer.next;
				secondPointer = secondPointer.next;
			}

			secondPointer.next = secondPointer.next.next;

			return head;
		}
	}
}

