using System;

namespace Example
{
    class Program
    {
        static void Main (string[] args)
        {
            int player1PosX = 2;
            int player2PosX = 6;

            if ((player1PosX == 2 && player2PosX == 6) || (player1PosX == 6 && player2PosX == 2))
            {
                Console.WriteLine("クリア");
            }
        }
    }
}