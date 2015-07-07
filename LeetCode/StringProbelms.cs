using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
	public class StringProblems
	{
		public int RemoveDuplicates(int[] nums) 
		{


			return 0;
		}

		public int MajorityElement(int[] nums) 
		{
			Dictionary<int,int> dic = new Dictionary<int, int> ();
			double mid = nums.Length / 2;
			int reachPoint = (int)Math.Ceiling(mid);

			for (int i = 0; i < nums.Length; i++) 
			{
				if (dic.ContainsKey (nums [i])) {
					dic [nums [i]] += 1;

				} else {
					dic [nums [i]] = 1;
				}

				if (dic [nums [i]] > reachPoint) {
					return nums [i];
				}
			}

			return -1;
		}

		public bool IsIsomorphic(string s, string t) 
		{
			return IsIsomorphicAux (s, t) && IsIsomorphicAux (t, s);
		}

		public bool IsIsomorphicAux(string s, string t) 
		{
			if (s.Length != t.Length) {
				return false;
			}

			Dictionary<char,List<int>> dic1 = new Dictionary<char, List<int>> ();

			for (int i = 0; i < s.Length; i++) {
				if (dic1.ContainsKey (s[i])) {
					dic1 [s[i]].Add (i);
				} else {
					dic1 [s[i]] = new List<int> (){ i };	
				}
			}

			for (int i = 0; i < t.Length; i++) 
			{
				List<int> rules = dic1 [s [i]];
				foreach (var rule in rules) {
					if (t[i] != t[rule]) {
						return false;
					}
				}
			}

			return true;

		}

		public int LengthOfLastWord(string s) 
		{
			int lastChar = s.Length -1;
			char[] text = s.ToCharArray ();

			int counter = 0;
			bool whiteSpaceDetected = false;
			bool charDetected = false;

			for (int i = lastChar; i >= 0 ; i -= 1) 
			{
				if (whiteSpaceDetected)
				{
					break;
				}
			
				if (text[i] != ' ')
				{
					counter += 1;
					charDetected = true;
				}else if(text[i] == ' ' && charDetected == true){
					whiteSpaceDetected = true;
				}
			}

			return counter;
		}
	}
}

