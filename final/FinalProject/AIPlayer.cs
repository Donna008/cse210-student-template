public class AIPlayer: Player
{
    public AIPlayer(char symbol)
    {
        _symbol = symbol;
    }
    public override Move MakeMove(Board board)
    {
        int cellNum;
        do
        {
            cellNum = new Random().Next(9);
        } while (!board.IsCellEmpty(cellNum));

        return new Move(cellNum, _symbol);
    }
}