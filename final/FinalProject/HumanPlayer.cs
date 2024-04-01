public class HumanPlayer: Player
{
    public HumanPlayer(char symbol)
    {
        _symbol = symbol;
    }
    public override Move MakeMove(Board board)
    {
        while (true)
        {
            try
            {
                Console.Write("Enter cell number (0-8): ");
                int cellNum = int.Parse(Console.ReadLine());
                if (board.IsCellEmpty(cellNum))
                {
                    return new Move(cellNum,_symbol);
                }
                else
                {
                    Console.WriteLine("Cell is not empty");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}