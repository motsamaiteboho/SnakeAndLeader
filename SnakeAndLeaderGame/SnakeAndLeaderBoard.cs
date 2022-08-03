using System.IO.Pipes;
using System.Linq.Expressions;
using System.Diagnostics;
using System.Collections;
namespace SnakeAndLeaderGame;
public class SnakeAndLeaderBoard
{
    public int DiceNum = 0;
    public int Position = 0;
    Hashtable Leader = new Hashtable(){ 
        {1,38}, {4,14}, {8,30},{21,42},{28,76},{50,67},{71,92},{80,99}
    };
    Hashtable Snake = new Hashtable(){
        {36,6},{32,10},{48,26},{62,18},{88,24},{95,56},{97,78}
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

    public void RollDice(int _DiceNum){
        DiceNum = _DiceNum;
    }


}
