using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToe
{

    public class TickTackToeRound
    {
        public string _whosTurn = "";
        public int _totalTurnsUsed = 0;
        public TickTackToeRound(string startingPlayer)
        {
            _whosTurn = startingPlayer;
        }
        public void TakeATurn(string nextPlayer)
        {
            _totalTurnsUsed++;
            _whosTurn = nextPlayer;
        }
    }
}
