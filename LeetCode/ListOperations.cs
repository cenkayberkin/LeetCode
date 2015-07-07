using System;

namespace LeetCode
{
	public class ListOperations
	{

		public ListNode ReverseListRecursive(ListNode head) 
		{
			ReverseListRecursiveHelper (head);
			return last;
		}

		ListNode last = null;
		public ListNode ReverseListRecursiveHelper(ListNode head)
		{
			if (head.next == null) {
				last = head;
				return head;	
			}

			var nextTmp = head.next;
			var nextNode = ReverseListRecursiveHelper (nextTmp);
			nextNode.next = head;
			head.next = null;

			return head;
		}

		//Iterative approach
		public ListNode ReverseList(ListNode head) 
		{
			if ( head == null || head.next == null) {
				return head;
			}	

			var newHead = head;
			var cur = newHead.next;
			var tmp = cur.next;

			newHead.next = null;

			while (cur != null) {
				cur.next = newHead;
				newHead = cur;
				cur = tmp;
				if (tmp == null) {
					break;
				} else {
					tmp = tmp.next;
				}
			}

			return newHead;
		}

		public ListNode AddToHead(ListNode head, ListNode newItem)
		{
			head.next = null;
			newItem.next = head;

			return newItem;
		}

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

