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
            Console.WriteLine("\n===============================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n===============================");

            //get array element
            for(int i =0;i < n;i++)
            {
                Console.Write("<" + (i+1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        //swaps the element at index x with the element at index y

        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, j;   
            if (low > high)
                return;

            //partition the list into two parts:
            //one containning elements less that or equal to pivot
            //outher containning elements greather than pivot

            i = low + 1;
            j = high ;

            pivot = arr[low];

            while (i <= j)
            {
                // Search for an element greather than pivot
                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;


            }
        }
        
    }
}

