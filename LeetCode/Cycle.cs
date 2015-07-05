using System;

namespace LeetCode
{
	public class Cycle
	{
		public bool? HasCycle(ListNode head) 
		{
			var slow = head;
			var fast = head;

			while (slow != null) {
				slow = slow.next;

				if (fast == null || fast.next == null) {
					return null;
				}
				fast = fast.next.next;
				if (slow == fast) {
					return true;
				}
			}
			return false;
		}
	}
}

