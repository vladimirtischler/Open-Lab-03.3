using System;

namespace Open_Lab_03._3
{
    class Program
    {
        public static bool CompareCharactersCount(string a, string b)
        {
            return (a.Length == b.Length);
        }
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            Console.WriteLine(CompareCharactersCount(name1, name2));
        }
    }
}
