using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            a--;
            a--;
            Console.WriteLine(a);

            a /=4;
            Console.WriteLine(a);
        }
    }
}
