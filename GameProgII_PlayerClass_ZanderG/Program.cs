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
            //Player player1 = new Player(100, 1);
            //Player player2 = new Player();
            List<Player> list = new List<Player>(100);
            Random random = new Random();

            
            /*
            player1.SetName("Zander");
            player2.SetName("Lucas");

            player1.PrintStats();
            player2.PrintStats();
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine($"{player2.GetName()} took damage!");
            Console.WriteLine($"{player1.GetName()} leveled up!");
            player2.TakeDamage(30);
            player1.LevelUp();
            Console.ReadKey(true);
            Console.Clear();

            player1.PrintStats();
            player2.PrintStats();
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Hitting enter will generate 100 players and display their stats");
            Console.ReadKey(true);
            Console.Clear();
            */

            for (int i = 0; i < 100; i++)
            {
                
                int health = random.Next(100);
                int level = random.Next(100);
                list.Add(new Player(health, level));
                list[i].SetName($"Player{i + 1}");
                list[i].PrintStats();
            }

            /*
            for (int i = 0; i < list.Count; i++)
            {
                list[i].SetName($"Player{i}");

                
                

                //list[i].TakeDamage(damage);

                int level = random.Next(100);

                for (int j = 0; j < level; j++)
                {
                    list[i].LevelUp();
                }

                list[i].PrintStats();
            }
            */
        }
    }

    class Player
    {
        string _name;
        int _health = 100;
        int _level = 1;

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
            Console.WriteLine($"Name: {_name} Health: {_health} Level: {_level}");
        }

        public string GetName()
        {
            return _name;
        }

        public Player(int health, int level)
        {
            _health = health;
            _level = level;
        }
    }
}
