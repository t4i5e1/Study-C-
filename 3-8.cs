using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1PosX = 2;
            int player2PosX = 6;

            //プレイヤー1の位置が2かつプレイヤー2の位置が6の場合クリア
            if (player1PosX == 2)
            {
                if(player2PosX == 6)
                {
                    Console.WriteLine("クリア");
                }
            }
        }
    }
}