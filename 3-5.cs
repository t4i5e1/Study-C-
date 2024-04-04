using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 480;
            int t = 513;
            int w = 500;
            int t2 = 480;
            int f = 490;

            float average = (m + t + w + t2 + f) / 5.0f;
            Console.WriteLine(average);
        }
    }
}
