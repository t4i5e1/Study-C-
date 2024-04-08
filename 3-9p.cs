using System;

namespace Example
{
    class Program
    {
        static void Main(string[ ]args)
        {
            int player1PosY = 3;

            //プレイヤー位置が0以上の場合は走り、そうでない場合は泳ぐ
            if (player1PosY >= 0)
            {
                Console.WriteLine("走る");
            }
            else
            {
                Console.WriteLine("泳ぐ");
            }
        }
    }
}
