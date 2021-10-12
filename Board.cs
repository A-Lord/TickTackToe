using System;

namespace TickTackToe
{
    public class Board
    {
        public string _usedNumbers = "";
        private string[,] _testBoard = new string[,]
        {
            {" ","1", " | ",  "2"," | "," ","3"," ",},           
            {"-","-", "-+-",  "-","-+-","-","-","-",},
            {" ","4", " | ",  "5"," | "," ","6"," ",},
            {"-","-", "-+-",  "-","-+-","-","-","-",},
            {" ","7", " | ",  "8"," | "," ","9"," ",},
        };
        public Board()
        {
        }
        public bool DidPlayerWin(string playerSymbol)
        {
            if(playerSymbol == _testBoard[0,1] && playerSymbol == _testBoard[0, 3] && playerSymbol == _testBoard[0, 6])
            {
                return true;
            }
            else if(playerSymbol == _testBoard[2, 1] && playerSymbol == _testBoard[2, 3] && playerSymbol == _testBoard[2, 6])
            {
                return true;
            }
            else if(playerSymbol == _testBoard[4, 1] && playerSymbol == _testBoard[4, 3] && playerSymbol == _testBoard[4, 6])
            {
                return true;
            }
            else if(playerSymbol == _testBoard[0, 1] && playerSymbol == _testBoard[2, 3] && playerSymbol == _testBoard[4, 6])
            {
                return true;
            }
            else if(playerSymbol == _testBoard[4, 1] && playerSymbol == _testBoard[2, 3] && playerSymbol == _testBoard[0, 6])
            {
                return true;
            }
            else if(playerSymbol == _testBoard[0, 1] && playerSymbol == _testBoard[2, 1] && playerSymbol == _testBoard[4, 1])
            {
                return true;
            }
            else if(playerSymbol == _testBoard[0, 6] && playerSymbol == _testBoard[2, 6] && playerSymbol == _testBoard[4, 6])
            {
                return true;
            }

            return false;
        }
        public void ShowBoard()
        {
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();

                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write(_testBoard[i, j]);
                    }

                
            }

            
        }
        public bool PlayerTarget(int target, string playerSymbol)
        {

            if (_usedNumbers.Contains(target.ToString()) == false)
            {
                _usedNumbers += target.ToString();

                switch (target)
                {

                    case 1:
                        _testBoard[0, 1] = playerSymbol;
                        break;
                    case 2:
                        _testBoard[0, 3] = playerSymbol; ;
                        break;
                    case 3:
                        _testBoard[0, 6] = playerSymbol;
                        break;
                    case 4:
                        _testBoard[2, 1] = playerSymbol;
                        break;
                    case 5:
                        _testBoard[2, 3] = playerSymbol;
                        break;
                    case 6:
                        _testBoard[2, 6] = playerSymbol;
                        break;
                    case 7:
                        _testBoard[4, 1] = playerSymbol;
                        break;
                    case 8:
                        _testBoard[4, 3] = playerSymbol;
                        break;
                    case 9:
                        _testBoard[4, 6] = playerSymbol;
                        break;


                    default:
                        break;
                }
                return true;
            }
            else
            {
                return false;
                
            }
            
        }
    }
}
