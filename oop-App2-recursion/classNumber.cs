using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oop_App2_recursion
{
    public class classNumber
    {
        public static int SearchNumberIndex(int[] array,int searchedNumber, int i=0 ) 
        {
            if (i  < array.Length-1)
            {
                if (array[i] == searchedNumber)
                {
                    return i;
                }
               
                    return SearchNumberIndex(array, searchedNumber, i + 1);
            }
            
                return -1;
        }

        

    }


}
