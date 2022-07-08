using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBrew.Core
{
    public class Game
    {
        Player player;

        public Game()
        {
            CreatePlayer();

            Run();
        }

        private void Run()
        {
            bool running = true;

            Console.WriteLine("Name: " + player.Name + " / Money: " + player.Money);
            Console.WriteLine("1/ Brewery");
            Console.WriteLine("2/ Shop");
            Console.WriteLine("3/ Exit game");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    DrawBrewery();
                    break;
                case 2:
                    DrawShop();
                    break;
                case 3:
                    running = false;
                    break;
                default:
                    break;
            }

            if (running)
            {
                Run();
            }
        }

        private void DrawBrewery()
        {
            
        }

        private void DrawShop()
        {
            Console.WriteLine("Name: " + player.Name + " / Money: " + player.Money);
            Console.WriteLine("1/ Brewing machines shop");
            Console.WriteLine("2/ Market");
            Console.WriteLine("3/ Back");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    DrawBrewingMachineShop();
                    break;
                case 2:
                    DrawMarket();
                    break;
                case 3:
                    break;
                default:
                    DrawShop();
            }
        }

        private void DrawBrewingMachineShop()
        {

        }

        private void DrawMarket()
        {

        }

        private bool CreatePlayer()
        {
            Console.WriteLine("Player name: ");
            string name = Console.ReadLine();

            player = new Player(name);

            return true;
        }

    }
}
