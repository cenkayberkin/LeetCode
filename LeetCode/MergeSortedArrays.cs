using System;

namespace LeetCode
{
	public class MergeSortedArrays
	{
		public void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			int pointer1 = m - 1;
			int pointer2 = n - 1;
			int insertLocation = nums1.Length - 1;

			while (pointer1 >= 0 && pointer2 >= 0) 
			{
				if (nums1[pointer1] < nums2[pointer2]) {
					nums1 [insertLocation] = nums2 [pointer2];
					pointer2 -= 1;
					insertLocation -= 1;
				}else{
					nums1 [insertLocation] = nums1 [pointer1];
					pointer1 -= 1;
					insertLocation -= 1;
				}
			}

			if (pointer1 < 0 && pointer2 >= 0) {
				while (pointer2 >= 0) 
				{
					nums1 [insertLocation] = nums2 [pointer2];
					pointer2 -= 1;
					insertLocation -= 1;
				}	
			} else {
				while (pointer1 >= 0) 
				{
					nums1 [insertLocation] = nums1 [pointer1];
					pointer1 -= 1;
					insertLocation -= 1;
				}
			}
		}
	}
}

