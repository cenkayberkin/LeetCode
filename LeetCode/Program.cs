﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			char[,] input = new char[9,9] {
//				{'7','2','.','.','3','9','.','.','6'},
//				{'.','.','.','.','5','.','3','.','1'},
//				{'.','.','.','.','.','7','.','.','5'},
//				{'.','.','.','.','.','.','1','.','.'},
//				{'9','.','6','.','.','.','.','.','2'},
//				{'.','3','.','.','.','.','5','.','.'},
//				{'3','7','.','.','.','4','8','.','.'},
//				{'6','.','8','9','7','.','.','3','.'},
//				{'5','.','.','.','.','.','.','.','.'}
//			};
//
//			Interval i1 = new Interval (1,3);
//			Interval i2 = new Interval (2,6);
//			Interval i3 = new Interval (8,10);
//			Interval i4 = new Interval (15,18);
//
//			List<Interval> list = new List<Interval> ();
//			list.Add (i1);

//			list.Add (i2);
//			list.Add (i3);
//			list.Add (i4);

		
			StringProblems s = new StringProblems ();
			int[] list = new int[]{1,2,3,5,5,5,5,5,6,7};
			Console.WriteLine (s.MajorityElement (list));
	
		}
	}
}
