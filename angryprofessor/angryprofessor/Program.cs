using System;

namespace angryprofessor
{
    class Program
    {
        public static object readLine { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Program to check whether the class will be cancelled or not");

            Console.WriteLine("Enter no. of test cases");
            int test_cases = Convert.ToInt32(Console.ReadLine());
            if (test_cases < 1 && test_cases > 10)
            {
                Console.WriteLine("Test case value should be 1 to 10");
                Console.WriteLine("in else");
                System.Environment.Exit(1);
            }
            else
            {
                for (int i = 0; i < test_cases; i++)
                {
                    
                    string[] tokens = Console.ReadLine().Split();
                    int no_of_student = int.Parse(tokens[0]);
                    //Console.WriteLine(no_of_student);
                    int cancellation_threshold = int.Parse(tokens[1]);
                    //Console.WriteLine(cancellation_threshold);

                    string readLine = Console.ReadLine();
                    string[] stringArray = readLine.Split(' ');
                  
                    //Console.WriteLine(stringArray);
                    int[] a = new int[stringArray.Length];
                     //Console.WriteLine(a);
                    for (int j = 0; j < stringArray.Length; j++)
                    {
                        a[j] = int.Parse(stringArray[j]);
                    }

                     angryprofessor(cancellation_threshold, a);
                }
            }
        }

        public static void angryprofessor(int cancellation_threshold, int[] a)
        {
            int count = 0;
            for (int i=0;i<a.Length; i++)
            {
                if(a[i]<1 || a[i]==0)
                {
                    count = count + 1;
                }
            }
            if (count >= cancellation_threshold)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }   
}

