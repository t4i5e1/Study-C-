using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //所持金=15000、時給=1150、労働時間=5

            int money = 15000;
            int salary = 1150;
            int hour = 5;

            int total = money + salary * hour;
            Console.WriteLine(total);
        }
    }
}
