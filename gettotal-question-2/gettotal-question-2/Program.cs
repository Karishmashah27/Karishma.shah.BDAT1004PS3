using System;

namespace gettotal_question_2
{
    class Program
    {
        static void Main()
        {
            string[] tokens = Console.ReadLine().Split();
            int n = int.Parse(tokens[0]);
            int m = int.Parse(tokens[1]);
            //Console.WriteLine(n);
            //Console.WriteLine(m);

            string a = Console.ReadLine();
            string[] StrArray_a = a.Split(' ');


            int[] array_a = new int[StrArray_a.Length];
            //Console.WriteLine(a);
            for (int j = 0; j < StrArray_a.Length; j++)
            {
                array_a[j] = int.Parse(StrArray_a[j]);
            }

            string b = Console.ReadLine();
            string[] StrArray_b = b.Split(' ');

            int[] array_b = new int[StrArray_b.Length];
            //Console.WriteLine(b);
            for (int j = 0; j < StrArray_b.Length; j++)
            {
                array_b[j] = int.Parse(StrArray_b[j]);
            }

            GetTotalX(array_a, array_b);
        }


        public static void GetTotalX(int[] array_a, int[] array_b)
        {

            int x = 1, r = 0, j = 0, count = 0;
            int[] d = new int[100];
            for (x = 1; x < 100; x++)
            {
                int c = 0;
                for (int i = 0; i < array_a.Length; i++)
                {
                    if (x % array_a[i] == 0 && x >= array_a[i])
                    {
                        c++;
                    }
                }
                if (c == array_a.Length)
                {
                    d[j] = x;
                    r++;
                    j++;
                }
            }
            for (j = 0; j < r; j++)
            {
                int c = 0;
                for (int i = 0; i < array_b.Length; i++)
                {
                    if (array_b[i] % d[j] == 0)
                    {
                        c++;
                    }
                }
                if (c == array_b.Length)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}


      
      


