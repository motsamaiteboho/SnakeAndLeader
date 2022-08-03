using SnakeAndLeaderGame;

namespace UnitsTestForSnakeAndLeaderGame;

public class TestSnakeAndLeaderBoard
{
    [Fact]
    public void ShouldReturn6WhenRoll3Then3OnDice()
    {
        SnakeAndLeaderBoard board = new SnakeAndLeaderBoard();
        board.RollDice(3);
        board.DefaultPositioning();
        board.RollDice(3);
        board.DefaultPositioning();
        Assert.Equal(6, board.getPosition());
    }
     [Fact]
    public void ShouldReturn2WhenRoll2OnDice()
    {
        SnakeAndLeaderBoard board = new SnakeAndLeaderBoard();
        board.RollDice(2);
        board.DefaultPositioning();
        Assert.Equal(2, board.getPosition());
    }

    [Fact]
    public void ShouldReturn42WhenRoll4Then6Then1OnDice()
    {
        SnakeAndLeaderBoard board = new SnakeAndLeaderBoard();
        board.RollDice(4);
        board.DefaultPositioning();
        board.RollDice(6);
        board.DefaultPositioning();
        board.RollDice(1);
        board.DefaultPositioning();
        Assert.Equal(42, board.getPosition());
    }

    [Fact]
    public void ShouldReturn38WhenRoll1OnDice()
    {
        SnakeAndLeaderBoard board = new SnakeAndLeaderBoard();
        board.RollDice(1);
        board.DefaultPositioning();
        Assert.Equal(38, board.getPosition());
    }

    [Fact]
    public void ShouldReturn32WhenRoll3ThenThen2OnDice()
    {
        SnakeAndLeaderBoard board2 = new SnakeAndLeaderBoard();
        board2.RollDice(3);
        board2.DefaultPositioning();
        board2.RollDice(5);
        board2.DefaultPositioning();
        board2.RollDice(2);
        board2.DefaultPositioning();
        Assert.Equal(10, board2.getPosition());

    }
     [Fact]
    public void ShouldReturn6WhenRoll3Then5Then6OnDice()
    {
        SnakeAndLeaderBoard board2 = new SnakeAndLeaderBoard();
        board2.RollDice(3);
        board2.DefaultPositioning();
        board2.RollDice(5);
        board2.DefaultPositioning();
        board2.RollDice(6);
        board2.DefaultPositioning();
        Assert.Equal(6, board2.getPosition());
    }
}