using System;

namespace TimGiaTriNhoNhatTrongMang
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 4, 12, 7, 8, 1, 0, 9 };
            int index = MinValue(arr);
            Console.WriteLine("The smallest element in the array is: " + arr[index]);

        }
        public static int MinValue(int[] array)
        {

            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }

            return index;
        }
    }
}
