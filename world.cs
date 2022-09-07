using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class world
    {
        public static void Main(string[] args)
        {
            int len;
            Console.Write("Enter the length of the Array:");
            len = int.Parse(Console.ReadLine());
            int[] arr = new int[len];
            for (int i = 0; i < arr.Length; i++)
            {
                int el = i + 1;
                Console.Write("Enter Element No." + el + ":");
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
        }
    }
}
