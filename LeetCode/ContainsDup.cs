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

		public bool ContainsNearbyDuplicate(int[] nums,int k) 
		{
			Dictionary<int,string> dic = new Dictionary<int, string> ();

			for (int i = 0; i < nums.Length; i++) 
			{
				if (!dic.ContainsKey (nums [i])) 
				{
					dic [nums [i]] = i + " ";
				} else {
					var indexes = dic [nums [i]].Trim().Split (' ');
					int lastIndex = int.Parse (indexes [(indexes.Length - 1)]);
					if ((i - lastIndex) <= k) {
						return true;
					}
					dic [nums [i]] = i + " ";
				}
			}
			return false;
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

