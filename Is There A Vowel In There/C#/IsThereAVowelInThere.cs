using System;

namespace IsThereAVowelInThere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public static object[] IsVow(object[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                switch ((int) a[i])
                {
                    case 97:
                        a[i] = "a";
                        break;
                    case 101:
                        a[i] = "e";
                        break;
                    case 105:
                        a[i] = "i";
                        break;
                    case 111:
                        a[i] = "o";
                        break;
                    case 117:
                        a[i] = "u";
                        break;
                }
            }

            return a;
        }
        
    }
    
}