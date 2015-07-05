using System;

namespace LeetCode
{
	public class ListMerger
	{
		public ListNode MergeTwoLists(ListNode l1, ListNode l2) 
		{
			ListNode head1 = l1;
			ListNode head2 = l2;

			ListNode newHead = null;
			ListNode newLast = null;

			while (head1 != null && head2 != null) 
			{
				if (head1.val < head2.val) {
					if (newHead == null) {
						newHead = head1;
						newLast = head1;
					} else {
						newLast.next = head1;
						newLast = newLast.next;
					}
					head1 = head1.next;
				} else {
					if (newHead == null) {
						newHead = head2;
						newLast = head2;
					} else {
						newLast.next = head2;
						newLast = newLast.next;
					}
					head2 = head2.next;
				}
			}

			if (head1 != null && head2 == null) {
				if (newHead == null) {
					newHead = head1;
					newLast = head1;
				} else {
					newLast.next = head1;
				}
			}else if(head1 == null && head2 != null){
				if (newHead == null) {
					newHead = head2;
					newLast = head2;
				} else {
					newLast.next = head2;
				}
			}

			return newHead;
		}

	}
}

