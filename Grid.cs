
class Grid
{
    public static string[] str = ["1", "2", "3",
                                 " 4", "5", "6",
                                 "7", "8", "9"];
    public static void Draw()
    {
        Console.Clear();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(str[i * 3 + j] + " | ");
            }
            Console.Write("\n");
            Console.WriteLine("-----------");
        }
    }

    public static void UpdateGrid()
    {
        int numberOfMoves = 0;
        string playerTurn = "0";


        while (numberOfMoves != 9)
        {
            int move = Move.TakeMoveInput();
            if (Move.CheckMove(move))
            {
                if (!Move.IsSpotFree(move))
                {
                    Console.WriteLine("Invalid move");
                    numberOfMoves--;
                }
                else if (playerTurn == "0")
                {
                    str[move - 1] = "0";
                    playerTurn = "X";
                    Draw();
                    if (Winner.CheckWinner(str))
                    {
                        Console.WriteLine("Winner is 0");
                        break;
                    }
                }
                else
                {
                    str[move - 1] = "X";
                    Draw();
                    playerTurn = "0";
                    if (Winner.CheckWinner(str))
                    {
                        Console.WriteLine("Winner is X");

                        break;
                    }
                }
            }
            numberOfMoves++;
        }
    }
}