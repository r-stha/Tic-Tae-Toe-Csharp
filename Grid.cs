class Grid
{
    public static string[] str = ["1", "2", "3",
                                  "4", "5", "6",
                                  "7", "8", "9"];


    public static void UpdateGridNumber()
    {
        str = ["1", "2", "3",
               "4", "5", "6",
               "7", "8", "9"];
    }

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
        Player player1 = new Player("0");
        Player player2 = new Player("X");

        int numberOfMoves = 0;

        while (numberOfMoves < 9)
        {

            do
            {
                Console.WriteLine($"Player {player1.Symbol} turn:");
            } while (!player1.MakeAMove());

            numberOfMoves++;

            if (player1.WonGame())
            {
                break;
            }

            if (Winner.Tie(numberOfMoves))
            {
                Console.WriteLine("TIE...");
                break;

            }


            do
            {
                Console.WriteLine($"Player {player2.Symbol} turn:");

            }
            while (!player2.MakeAMove());

            numberOfMoves++;



            if (player2.WonGame())
            {
                break;
            }
        }


    }
}
