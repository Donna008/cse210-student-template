public class TicTacToe
{
  public void Start()
  {
    Player player1 = new HumanPlayer('X');
    Player player2 = new AIPlayer('O');
    GameController controller = new GameController(player1,player2);
    controller.Play();
  }

}