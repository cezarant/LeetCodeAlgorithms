using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Problems.Arrays
{
    public static class arrayRotationImplementation
    {
        public static  int[] implementation(int[] arr)
        {
            int numberRotations = 2;
            int aux = 0;            
            do
            {
                aux = arr[0];
                for (int j = 0 ; j < arr.Length - 1; j++)                                    
                    arr[j] = arr[j + 1];                                    
                
                arr[arr.Length - 1] = aux;
                numberRotations--;                
            } while (numberRotations > 0);    
            return arr; 
        }
    }
}
