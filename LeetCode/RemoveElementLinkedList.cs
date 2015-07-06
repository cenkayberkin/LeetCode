using System;

namespace LeetCode
{
	public class RemoveElementLinkedList
	{
		public RemoveElementLinkedList ()
		{
		}

		public ListNode RemoveElements(ListNode head, int val)
		{

			if (head == null) {
				return null;
			}
			var tmp = head;

			while (tmp != null) {
				if (tmp.val == val) {
					head = tmp.next;
					tmp = tmp.next;
				} else {
					break;
				}
			}

			if (head == null) {
				return null;
			}

			tmp = head;
			while (tmp.next != null)
			{
				if (tmp.next.val == val) {
					tmp.next = tmp.next.next;
				} else {
					tmp = tmp.next;
				}
			}
			return head;
		}
	}
}

