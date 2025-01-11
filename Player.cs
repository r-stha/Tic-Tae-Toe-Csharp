class Player
{
    public string Symbol
    {
        get;
        set;
    }

    public Player(string symbol)
    {
        Symbol = symbol;
    }

    public bool MakeAMove()
    {
       
        int move = Move.TakeMoveInput();
        if (Move.IsSpotFree(move))
        {
            Grid.str[move - 1] = Symbol;
            Grid.Draw();
            return true;
        }
        else
        {
            Console.Clear();
            Grid.Draw();
            Console.WriteLine("Already played Move.");
            return false;
        }
          

    }


    public bool WonGame()
    {
        if (Winner.CheckWinner())
        {
            Console.WriteLine($"{Symbol} has won the game");
            return true;
        }

        return false;
    }
}