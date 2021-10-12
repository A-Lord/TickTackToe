using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToe
{
    public class Player
    {
        private string _name;
        public string _playerSymbol = "X";
        public string Name {  get {  return _name; } }
        
        public Player(string symbol)
        {
            _playerSymbol = symbol;
            Console.WriteLine($"{_playerSymbol}  Write your name:");
            _name = Console.ReadLine();
            Console.Clear();
        }
        public int PlayersTurn()
        {
            Console.WriteLine($"\n{_name} its your turn, pick a number");
            int pickedNumb = int.Parse(Console.ReadLine());
            return pickedNumb;
        }
    }
}
