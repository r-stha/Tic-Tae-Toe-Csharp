class MainProgram
{

    public static void Main()
    {
        string? choice;
        do
        {
            Grid.UpdateGridNumber();
            Grid.Draw();
            Grid.UpdateGrid();
            
            Console.WriteLine("Do you want to play again(y/n):");
            choice = Console.ReadLine();

        } while (choice == "y" || choice == "Y" );
    }
}
