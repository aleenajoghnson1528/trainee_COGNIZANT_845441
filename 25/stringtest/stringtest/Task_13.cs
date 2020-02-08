using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringtest
{
    class Task_13
    {
        public static int[] Reverse_arrayy(int[] arr,int size)
        {
            int new_arr_index = 0;
            int[] new_arr = new int[size];
            for(int i=size-1;i>=0;i--)
            {
                new_arr[new_arr_index] = arr[i];
                new_arr_index = new_arr_index + 1;
            }
            return new_arr;
        }
    }
}
