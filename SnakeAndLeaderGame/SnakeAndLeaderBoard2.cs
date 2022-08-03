using System.IO.Pipes;
using System.Linq.Expressions;
using System.Diagnostics;
using System.Collections;
namespace SnakeAndLeaderGame;
public class SnakeAndLeaderBoard2
{
    public int DiceNum = 0;
    public int Position = 0;
    Hashtable Leader = new Hashtable(){ 
        {9,31}, {16,45}, {18,64},{48,66},{50,93},{63,81}
    };
    Hashtable Snake = new Hashtable(){
        {32,6},{74,22},{86,51},{99,39}
    };


    public void SpecialBoardPositioning(int _position ){

        if(Leader.ContainsKey(_position)){
            Position = (int)Leader[_position];
        }

        if(Snake.ContainsKey(_position)){
            Position = (int)Snake[_position];
        }
    }

    public void DefaultPositioning(){
        switch (DiceNum)
        {
            case 1:
                Position +=1;
                SpecialBoardPositioning(Position);
            break;
             case 2:
                Position +=2;
                SpecialBoardPositioning(Position);
            break;
             case 3:
                Position +=3;
                 SpecialBoardPositioning(Position);
            break;
             case 4:
                Position +=4;
                SpecialBoardPositioning(Position);
            break;
             case 5:
                Position +=5;
                 SpecialBoardPositioning(Position);
            break;
             case 6:
                Position +=6;
                SpecialBoardPositioning(Position);
            break;
        }
    }
    
    public int getPosition(){
        return Position;
    }

    public void RollDice(int Num){
        DiceNum = Num;
    }

    public int  RollDice2(){
        Random rd = new Random();
        DiceNum = rd.Next(1,7);
        return DiceNum;
    }


}
