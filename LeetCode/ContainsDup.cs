using System;
using System.Collections.Generic;
using System.Collections;

namespace LeetCode
{
	public class ContainsDup
	{
		public ContainsDup ()
		{
		}

		public bool ContainsDuplicate(int[] nums) 
		{
			HashSet<int> set = new HashSet<int> ();
			foreach (var item in nums) 
			{
				if (set.Contains (item)) {
					return true;
				} else {
					set.Add (item);
				}
			}
			return false;
		}
	}
}

