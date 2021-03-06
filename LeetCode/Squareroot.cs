﻿using System;

namespace LeetCode
{
	public class Squareroot
	{
		public int MySqrt(int x) 
		{
			if (x == 0) { return 0; }
			if (x >= 1 && x <= 3) { return 1; }
			if (x >= 4 && x < 9) { return 2; }
			if (x >= 9 && x < 16) { return 3; }
			if (x >= 16 && x < 25) { return 4; }
			if (x >= 25 && x < 36) { return 5; }

			int length = x / 5;

			return findSqrt (x, 0, length);
		}

		public int findSqrt(int x,int lo, int hi)
		{
			if (lo == hi) { return 0; }
			int mid = lo + (hi - lo) / 2;
			double pow = Math.Pow (mid, 2);

			double lowDiff = pow - ((mid - 1) + mid);
			double upperDiff = pow + (mid + mid + 1);

			if (x == pow || (x > pow && x < upperDiff)){
				return mid;
			} 

			if (x < pow &&  x > lowDiff ) {
				return mid - 1;
			}

			if (pow < x) {
				return findSqrt (x, mid + 1, hi);
			} else {
				return findSqrt (x, lo, mid);
			}
		
		}
	}
}

