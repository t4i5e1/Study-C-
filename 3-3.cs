using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //変数の初期化
            int money = 15000; //現在の所持金
            int salary = 1000; //時給
            int hour = 5; //働いた時間

            //現在の所持金の合計を計算して表示
            int sumMoney = money + salary * hour;
            Console.WriteLine(sumMoney);
        }
    }
}
