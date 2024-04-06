public class GameController
{
    private Board _board;
    private Player _player1;
    private Player _player2;
    private Player _currentPlayer;

    public GameController(Player player1, Player player2)
    {
        _board = new Board();
        _player1 = player1;
        _player2 = player2;
        _currentPlayer = player1;
    }

    public void SwitchPlayers()
    {
        if (_currentPlayer == _player1)
        {
            _currentPlayer = _player2;
        }
        else
        {
            _currentPlayer = _player1;
        }
    }

    public bool IsGameOver()
    {
        return _board.IsWinner(_player1.Symbol) ||
               _board.IsWinner(_player2.Symbol) ||
               _board.IsFull();
    }

    public void Play()
    {
        while (!IsGameOver())
        {
            _board.Display();
            Console.WriteLine($"\nPlayer {_currentPlayer.Symbol}'s turn\n");
            Move move = _currentPlayer.MakeMove(_board);
            _board.UpdateCell(move.CellNum, move.Symbol);
            SwitchPlayers();
        }
        _board.Display();
        if(_board.IsWinner(_player1.Symbol))
        {
            Console.WriteLine("\nPlayer 1 wins\n");
        }
        else if (_board.IsWinner(_player2.Symbol))
        {
            Console.WriteLine("\nPlayer 2 wins\n");
        }
        else
        {
            Console.WriteLine("\nOops, no winner");
        }
    }
}