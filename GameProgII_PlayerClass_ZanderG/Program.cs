using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_PlayerClass_ZanderG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Player player2 = new Player();

            player1.SetName("Zander");
            player2.SetName("Lucas");

            player1.
        }
    }

    class Player
    {
        string _name;
        int _health;
        int _level;

        public void TakeDamage(int damage)
        {
            _health -= damage;

            if(_health <= 0)
            {
                Console.WriteLine("GAME OVER");
            }
        }

        public void LevelUp()
        {
            _level++;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void PrintStats()
        {
            Console.WriteLine($"Name{_name} Health: {_health} Level: {_level}");
        }
    }
}
