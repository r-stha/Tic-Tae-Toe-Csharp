class Winner
{
    public static bool CheckWinner()
    {
        if (IsGridMatch(Grid.str))
        {
            return true;
        }
        return false;
    }

    public static bool IsGridMatch(string[] str)
    {
        bool row1 = str[0] == str[1] && str[1] == str[2];
        bool row2 = str[3] == str[4] && str[4] == str[5];
        bool row3 = str[6] == str[7] && str[6] == str[8];

        bool colum1 = str[0] == str[3] && str[3] == str[6];
        bool colum2 = str[1] == str[4] && str[4] == str[7];
        bool colum3 = str[2] == str[5] && str[5] == str[8];

        bool diagonal1 = str[0] == str[4] && str[4] == str[8];
        bool diagonal2 = str[2] == str[4] && str[4] == str[6];

        return row1 || row2 || row3 || colum1 || colum2 || colum3 || diagonal1 || diagonal2;
    }

    public static bool Tie(int numberOfMoves)
    {
        return numberOfMoves >= 9;
    }
}