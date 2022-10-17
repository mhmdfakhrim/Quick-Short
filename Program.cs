using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Short
{
    class program
    {
        //array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; // number of comparison
        private int mov_count = 0; // number of data movements

        // Number of elements in array
        private int n;

            void read ()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array :");
                string s= Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements \n");
            }
            Console.WriteLine("\n=================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n=================");

            //get array elements
            for(int i = 0;i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        //swaos the element at index x with the element at index y
        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        public void q_sort(int low,int high)
        {
            int pivot, i, j;
            if (low > high)
                return;

            //Partition the list into two parts;
            //One containing elements less that or equal to pivot
            //Outher containing elements greater than pivot

            i= low + 1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                //Search for an element greater than pivot
                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                if (i < j) //if the greater element is on the left of the element
                {
                    //swap the element at index i with the element at index j
                    swap(i, j);
                    cmp_count++;
                }
            }
        }
    }
}
   
