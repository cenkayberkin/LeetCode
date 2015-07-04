using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
	public class SudokuSolver
	{
		public bool IsValidSudoku(char[,] board)
		{
			for (int row = 0; row < 9; row++) {
				for (int col = 0; col < 9; col++) {
					if (board[row,col] != '.') {
						char val = board [row, col];
						if (!IsValid (row, col, val, board)) 
						{

							return false;
						}
					}
				}
			}
			return true;
		}

		public bool IsValid(int row,int col, char value,char[,] table)
		{
			if (IsValidByRow (row, col,value,table) && IsValidByCol (col, row,value,table) && IsValidBySquare (row, col, value,table)) {
				return true;
			} else {
				return false;
			}
		}

		public bool IsValidByRow(int row, int col,char value,char[,] table)
		{
			for (int i = 0; i < 9; i++) {
				if (table[row,i] == value && i != col) {
					return false;
				}
			}
			return true;

		}

		public bool IsValidByCol(int col,int row, char value, char[,] table)
		{
			for (int i = 0; i < 9; i++) {
				if (table[i,col] == value && i != row) {
					return false;
				}
			}
			return true;
		}

		public bool IsValidBySquare(int row, int col, char value, char[,] table)
		{
			int sectionCol = col / 3;
			int startCol = sectionCol * 3;
			int endCol = (sectionCol * 3) + 3;

			int sectionRow = row / 3;
			int startRow = sectionRow * 3;
			int endRow = (sectionRow * 3) + 3;

			for (int i = startRow; i < endRow; i++) {
				for (int z = startCol; z < endCol; z++) {
					if (table[i,z] == value && (row != i && col != z)) {
						return false;
					}
				}
			}

			return true;
		}

	}
}

