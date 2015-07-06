using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
	public class RomanAlph
	{
		public int RomanToInt2(string s) 
		{
			if (string.IsNullOrWhiteSpace(s)) {
				return 0;
			}

			Dictionary<char,int> romanAlph = new Dictionary<char, int> ();
			romanAlph ['C'] = 100;
			romanAlph ['X'] = 10;
			romanAlph ['V'] = 5;
			romanAlph ['D'] = 500;
			romanAlph ['M'] = 1000;
			romanAlph ['I'] = 1;
			romanAlph ['L'] = 50;

			int result = 0;
			int i = 0;

			while(i  < s.Length)
			{
				if (i + 1 == s.Length) {
					result += romanAlph [s [i]];
					i += 1;
				} else {
					if (romanAlph [s [i]] < romanAlph [s [i + 1]]) {
						int val = romanAlph [s [i + 1]] - romanAlph [s [i]];
						result += val;
						i += 2;
					} else {
						result += romanAlph [s [i]];
						i += 1;
					}
				}
			}

			return result;
		}

		public int RomanToInt(string s) 
		{
			if (string.IsNullOrWhiteSpace(s)) {
				return 0;
			}

			Dictionary<char,int> romanAlph = new Dictionary<char, int> ();
			romanAlph ['C'] = 100;
			romanAlph ['X'] = 10;
			romanAlph ['V'] = 5;
			romanAlph ['D'] = 500;
			romanAlph ['M'] = 1000;
			romanAlph ['I'] = 1;
			romanAlph ['L'] = 50;


			int result = 0;
			int i = 0;

			if (s.Length == 1) {
				return romanAlph [s [0]];
			}

			while(i + 1 < s.Length)
			{
				if (romanAlph [s [i]] < romanAlph [s [i + 1]]) {
					int val = romanAlph [s [i + 1]] - romanAlph [s [i]];
					result += val;
					i += 2;
				} else {
					result += romanAlph [s [i]];
					i += 1;
				}
			}


			int end = s.Length - 1;
			int end_prev = s.Length - 2;
			if (romanAlph [s [end_prev]] >=
				
				romanAlph [s [end]]) {
				result += romanAlph [s [end]];
			}

			return result;
		}


	}
}

