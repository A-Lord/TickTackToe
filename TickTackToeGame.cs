using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToe
{
    public class TickTackToeGame
    {
        private Board _tickTackBoard;
        private Player _player1;
        private Player _player2;
        private TickTackToeRound _round;
        private bool GameWon = false;
        public TickTackToeGame()
        {
            _player1 = new Player("x");
            _player2 = new Player("O");
        }
        public void StartNewGame()
        {
            _tickTackBoard = new Board();
            _round = new TickTackToeRound(_player1.Name);
            this.PlayTheGame();
        }
        public void PlayTheGame()
        {
            while (GameWon == false)
            {
                Console.Clear();
                _tickTackBoard.ShowBoard();
                            
                if (_tickTackBoard._usedNumbers.Length == 9)
                {
                    Console.WriteLine("Game Over, No more moves");
                    Console.ReadKey();
                    GameWon = true;
                    break;
                    
                }
                if (_round._whosTurn == _player1.Name)
                {
                    while (true)
                    {
                        if (_tickTackBoard.PlayerTarget(_player1.PlayersTurn(), _player1._playerSymbol) == true)
                        {
                            if(_tickTackBoard.DidPlayerWin(_player1._playerSymbol))
                            {
                                _tickTackBoard.ShowBoard();
                                Console.WriteLine($"\n{_player1.Name} Won!");
                                Console.ReadKey();
                                GameWon = true;
                                break;
                            }
                            _round.TakeATurn(_player2.Name);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That one is taken. try again:!");
                            Console.ReadKey();
                            Console.Clear();
                            _tickTackBoard.ShowBoard();

                        }
                    }



                }
                else if (_round._whosTurn == _player2.Name)
                {
                    while (true)
                    {
                        if (_tickTackBoard.PlayerTarget(_player2.PlayersTurn(), _player2._playerSymbol) == true)
                        {
                            if (_tickTackBoard.DidPlayerWin(_player2._playerSymbol))
                            {
                                _tickTackBoard.ShowBoard();
                                Console.WriteLine($"\n{_player2.Name} Won!");
                                Console.ReadKey();
                                GameWon = true;
                                break;
                            }
                            _round.TakeATurn(_player1.Name);
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("That one is taken. try again:!");
                            Console.ReadKey();
                            Console.Clear();
                            _tickTackBoard.ShowBoard();
                        }
                    }
 

                }

            }

        }

    }
}
