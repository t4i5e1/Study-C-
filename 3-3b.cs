using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //所持金=5000、時給800、労働時間=2

            int money = 5000;
            int salary = 800;
            int hour = 2;

            int totalMoney = money + salary * hour;
            Console.WriteLine(totalMoney);
        }
    }
}
