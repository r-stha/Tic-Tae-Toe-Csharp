using Microsoft.Win32.SafeHandles;

class Grid
{
    static string[] str = ["1", "2", "3"," 4", "5", "6", "7", "8", "9"];
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

    public static void MakeMove()
    {
        int numberOfMoves = 0;
        string playerTurn = "0";

        while (numberOfMoves != 9)
        {
            Console.WriteLine("Enter the Move");
            int move = Convert.ToInt32(Console.ReadLine());
            if (move == 1 || move == 2 || move == 3 || move == 4 || move == 5 || move == 6 || move == 7 || move == 8 || move == 9)
            {
                    if(str[move-1] =="0" || str[move-1] == "X")
                    {
                        Console.WriteLine("Invalid move");
                        numberOfMoves--;
                    }
                    else if(playerTurn== "0"){
                        str[move-1] = "0";
                        playerTurn = "X";
                        Draw();
                    }
                    else{
                        str[move-1] = "X";
                        Draw();
                        playerTurn = "0";
                    }
            }
            numberOfMoves++;
        }
    }
}