using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace CodeWars2
{
    public class Sudoku
    {
        public static bool Arraysplitter(int[][] board)
        {
            var ValidDict0 = new Dictionary<int, int>();
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = count; j < count+3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (!ValidDict0.ContainsKey(board[j][k])) ValidDict0[board[j][k]] = 0;
                        ValidDict0[board[j][k]] += 1;

                    }
                }

                if (ValidDict0.Count(a => a.Value > 1) != 0)
                {
                    return false;
                }
                ValidDict0.Clear();
            }
            count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = count; j < count + 3; j++)
                {
                    for (int k = 3; k < 6; k++)
                    {
                        if (!ValidDict0.ContainsKey(board[j][k])) ValidDict0[board[j][k]] = 0;
                        ValidDict0[board[j][k]] += 1;

                    }
                }

                if (ValidDict0.Count(a => a.Value > 1) != 0)
                {
                    return false;
                }
                ValidDict0.Clear();
            }
            count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = count; j < count + 3; j++)
                {
                    for (int k = 6; k < 9; k++)
                    {
                        if (!ValidDict0.ContainsKey(board[j][k])) ValidDict0[board[j][k]] = 0;
                        ValidDict0[board[j][k]] += 1;

                    }
                }

                if (ValidDict0.Count(a => a.Value > 1) != 0)
                {
                    return false;
                }
                ValidDict0.Clear();
            }
            return true;
        }
        public static bool ValidateSolution(int[][] board)
        {
            //int[] countarray = new int[9];
            var ValidDict = new Dictionary<int, int>();
            var ValidDict2 = new Dictionary<int, int>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == 0 || board[j][i] ==0)
                    {
                        return false;
                    }
                    if (!ValidDict.ContainsKey(board[i][j])) ValidDict[board[i][j]] = 0;
                    ValidDict[board[i][j]] += 1;
                    if (!ValidDict2.ContainsKey(board[j][i])) ValidDict2[board[j][i]] = 0;
                    ValidDict2[board[j][i]] += 1;
                }

                if (ValidDict.Count(a => a.Value > 1)!=0 || ValidDict2.Count(a => a.Value > 1)!=0)
                {
                    return false;
                }
                ValidDict.Clear();
                ValidDict2.Clear();
            }
            return Arraysplitter(board);
        }
    }
}
