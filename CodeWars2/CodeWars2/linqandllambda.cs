using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars2
{
    using System.Linq;
    using System.Collections.Generic;

    public class Sudoku2
    {
        // public = global, static makes it callable
        public static bool ValidateSolution(int[][] board)
        {
            // board.SelectMany(row => row) selects all elemnts in the array and names them row and then it returns row, .Any(x => x == 0) checks if any of the elements which are all put into x are equal to 0, then return true
            // therefore it then returns false
            if (board.SelectMany(row => row).Any(x => x == 0))
                return false;

            // returns all number from 0 to 9 and then into i idividually then loops and increments i 
            return Enumerable.Range(0, 9).All(i =>
                // calls cellinrow fuction passing on the board and the i which is used as an index for each row which is passed back, disntict then return number of unique characters, count then counts them, if == 9 then it passes
                CellsInRow(board, i).Distinct().Count() == 9
                //same as the one above but checks the columns
                && CellsInCol(board, i).Distinct().Count() == 9
                // same as above but checks every 3x3 box in the board
                && CellsInBox(board, i).Distinct().Count() == 9
            );
        }
        // static, makes the function callable, ienumerable is a standard which allows the itteration which is used to return a whole row as an integer(?) by using the parameter from the called funtion with => and board[row] to give the whole row not just one element
        // OR ienumerable is the standard that allows the conversion of the return value to an int(?)
        static IEnumerable<int> CellsInRow(int[][] board, int row) => board[row];
        //same as above but board is selected and put into the parameter row then => then the column based on i is return since row[col] is basically board[col]
        static IEnumerable<int> CellsInCol(int[][] board, int col) => board.Select(row => row[col]);
        // mathematical logic to find every 3x3 box per run based on the value i which is passed down as box
        static IEnumerable<int> CellsInBox(int[][] board, int box) => Enumerable.Range(0, 9)
            .SelectMany(i => CellsInRow(board, (box - box % 3) + i / 3).Skip(3 * (box % 3)).Take(3));
    }
}