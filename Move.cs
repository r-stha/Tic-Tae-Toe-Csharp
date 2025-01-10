class Move
{
    public static int TakeMoveInput()
    {
        Console.WriteLine("Enter the Move");
        int move = Convert.ToInt32(Console.ReadLine());
        return move;
    }

    public static bool CheckMove(int move)
    {

        return move == 1 || move == 2 || move == 3
            || move == 4 || move == 5 || move == 6
            || move == 7 || move == 8 || move == 9;
    }

    public static bool IsValidMove(int move)
    {
        return Grid.str[move - 1] == "0" ||
               Grid.str[move - 1] == "X";
    }

    public static bool IsSpotFree(int move)
    {
        return Grid.str[move - 1] != "0" && Grid.str[move - 1] != "X";
    }
}