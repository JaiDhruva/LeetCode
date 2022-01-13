using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class TwoDRotate
    {
        public void Rotate(int[,] matrix)
        {
            int left = 0;
            int right = matrix.GetLength(0) - 1;
            while (left < right)
            {
                int top = left;
                int bottom = right;

                for (int i = 0; i < right - left; i++)
                {
                    var topLeft = matrix[top,left + i];
                    matrix[top,left + i] = matrix[bottom - i,left];
                    matrix[bottom - i,left] = matrix[bottom,right - i];
                    matrix[bottom,right - i] = matrix[top + i,right];
                    matrix[top + i,right] = topLeft;
                }
                left++;
                right--;
            }
        }
    }
}
