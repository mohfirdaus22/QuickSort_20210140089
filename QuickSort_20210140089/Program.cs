﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
class program
    {
        // array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0;  //number of comparation
        private int mov_count = 0;  // number of data movement

        //Numbers of elements in array
        private int n;

        void input()
        {
            while (true)
            {
                Console.Write("Enter the number of element in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\n Array can have maximum 20 elements \n");
            }
            
        }
    }
}

