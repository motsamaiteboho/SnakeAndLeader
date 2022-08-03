using SnakeAndLeaderGame;

namespace UnitsTestForSnakeAndLeaderGame;

public class TestSnakeAndLeaderBoard2
{
    [Fact]
    public void ShouldReturn4WhenRoll2Then2OnDice()
    {
        SnakeAndLeaderBoard2 board = new SnakeAndLeaderBoard2();
        board.RollDice(2);
        board.DefaultPositioning();
        board.RollDice(2);
        board.DefaultPositioning();
        Assert.Equal(4, board.getPosition());
    }

    [Fact]
    public void ShouldReturn5WhenRoll2Then3OnDice()
    {
        SnakeAndLeaderBoard2 board = new SnakeAndLeaderBoard2();
        board.RollDice(2);
        board.DefaultPositioning();
        board.RollDice(3);
        board.DefaultPositioning();
        Assert.Equal(5, board.getPosition());
    }
    //Leader
    [Fact]
    public void ShouldReturn31WhenRoll6Then3OnDice()
    {
        SnakeAndLeaderBoard2 board = new SnakeAndLeaderBoard2();
        board.RollDice(6);
        board.DefaultPositioning();
        board.RollDice(3);
        board.DefaultPositioning();
        Assert.Equal(31, board.getPosition());
    }

    [Fact]
    public void ShouldReturn64WhenRoll6Then6Then6OnDice()
    {
        SnakeAndLeaderBoard2 board = new SnakeAndLeaderBoard2();
        board.RollDice(6);
        board.DefaultPositioning();
          board.RollDice(6);
        board.DefaultPositioning();
          board.RollDice(6);
        board.DefaultPositioning();
        Assert.Equal(64, board.getPosition());
    }
//Snakes
    [Fact]
    public void ShouldReturn6WhenRoll6Then3Then1OnDice()
    {
        SnakeAndLeaderBoard2 board2 = new SnakeAndLeaderBoard2();
        board2.RollDice(6);
        board2.DefaultPositioning();
        board2.RollDice(3);
        board2.DefaultPositioning();
        board2.RollDice(1);
        board2.DefaultPositioning();
        Assert.Equal(6, board2.getPosition());

    }

    [Fact]
    public void ShouldReturn22WhenRoll6Then6Then6Then6Then4OnDice()
    {
        SnakeAndLeaderBoard2 board2 = new SnakeAndLeaderBoard2();
        board2.RollDice(6);
        board2.DefaultPositioning();
        board2.RollDice(6);
        board2.DefaultPositioning();
        board2.RollDice(6);
        board2.DefaultPositioning();
         board2.RollDice(6);
        board2.DefaultPositioning();
         board2.RollDice(4);
        board2.DefaultPositioning();
        Assert.Equal(22, board2.getPosition());
    }
    
}