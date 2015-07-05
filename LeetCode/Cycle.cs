using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
	public class Cycle
	{
		public ListNode DetectCycle(ListNode head) 
		{
			HashSet<ListNode> set = new HashSet<ListNode> ();
			var tmp = head;

			while (tmp != null) {
				if (set.Contains(tmp)) {
					return tmp;
				}
				set.Add (tmp);
				tmp = tmp.next;
			}
			return null;
		}

		public bool HasCycle(ListNode head) 
		{
			var slow = head;
			var fast = head;

			while (slow != null) {
				slow = slow.next;

				if (fast == null || fast.next == null) {
					return false;
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

