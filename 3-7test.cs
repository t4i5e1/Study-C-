using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int PlayerePosX = 5;
            int enemyPosX = 10;

            //プレイヤーと敵の位置が等しい場合は敵と遭遇
            if (PlayerePosX == enemyPosX)
            {
                Console.WriteLine("敵と遭遇");
            }
        }
    }
}
