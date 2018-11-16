using System;

namespace TestArrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5];
            a[0] = 4;

            for (int i = 0; i < a.Length; i++){
                Console.WriteLine(a[i]);
            }

            var b = new bool[5];
            b[1] = true;

            for (int i = 0; i < b.Length; i++){
                Console.WriteLine(b[i]);
            }

            string[] s = new string[3] { "john", "gosia", "kròlic" };

            for (int i = 0; i < s.Length; i++){
                Console.WriteLine(s[i]);
            }
        }
    }
}
