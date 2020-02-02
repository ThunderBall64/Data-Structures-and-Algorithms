using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class quickSort
    {
        private int[] array = new int[20];
        private int len;
        public void QuickSort()
        {
            
        }
        public void sort(int left, int right)
        {
            int pivot, leftend, rightend;
            leftend = left;
            rightend = right;
            pivot = array[left];
            while (left < right)
            {
                while ((array[right] >= pivot) && (left < right))
                {
                    right--;
                }
                if (left != right)
                {
                    array[left] = array[right];
                    left++;
                }
                while ((array[left] <= pivot) && (left < right))
                {
                    left++;
                }
                if (left != right)
                {
                    array[right] = array[left];
                    right--;
                }
            }

            array[left] = pivot;
            pivot = left;
            left = leftend;
            right = rightend;
            if (left < pivot)
            {
                sort(left, pivot - 1);
            }
            if (right > pivot)
            {
                sort(pivot + 1, right);
            }
        }
    }
}
