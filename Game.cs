using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        Player player;
        Store store;

        List<Day> days;
        int currentDay;

        public Game()
        {




        }





        public void StartGame()
        {
            Console.WriteLine(" Welcome to Lemondade Stand!! Would you like to play (Y/N) ");
            string ans = Console.ReadLine().ToLower();
            switch (ans)
            {
                case "yes":
                case "yeah":
                case "yup":
                case "y":
                    Console.WriteLine("Great!! Lets get started!! "); /*next method here*/ break;
                default:
                    Console.WriteLine(" Well it seems you chose not to play enjoy your day!!"); Environment.Exit(0); break;
            }
            player = new Player();
            
        }
        public void InitalDay()
        {
            Console.WriteLine(" Today is the first day of your lemonade stand. " + player.name + " , I think you would be best served by looking at the forecast. ");
            Console.ReadLine();
            days = new List<Day>();
            currentDay++;
            Console.WriteLine(" Now that we have a idea of what kind if weather " + currentDay + " is supposed to have, Would you like to visit the Store?(Y/N) ");
            string ans = Console.ReadLine().ToLower();
            switch (ans)
            {
                case "yes":
                case "yeah":
                case "yup":
                case "yea":
                case "y":
                case " ":

                    StoreRunner();
                    break;
                default: Console.WriteLine("Alrighty then."); break;
            }
        }
        public void StoreRunner()
        {
            Console.WriteLine(" Great!! Firstly, before we start buying up some shhhh, lets take stock of our inventory. ");
            Console.WriteLine(player.name + " currently has " + player.inventory.lemons + " lemons, " + player.inventory.sugarCubes + " sugar cubes, and " + player.inventory.iceCubes + " icecubes left. You also have " + player.inventory.cups + " cups.");
            Console.ReadLine();
            Console.WriteLine(" Now that you have taken stock, lets look at the price of materials.");
            Console.WriteLine(" Lemons are $.05 a piece. Sugar is $.10 per cube. Ice cubes are priced at $.01 per cube. Cups are $.25 a piece. " + player.pitcher.cupsLeftInPitcher + " cups make a pitcher. ");
            Console.ReadLine();
            Console.WriteLine(" First is lemons Cost: 5 cents, Current supply " + player.inventory.lemons + " You funds are currently: $" + player.wallet.Money);
            store.SellLemons(player);
            Console.WriteLine(" Next lets buy some sugar!! Cost: 10 cents per cube, Current supply " + player.inventory.lemons + " You funds are currently: $" + player.wallet.Money);
            store.SellSugarCubes(player);
            Console.WriteLine(" Now, lets buy some ice!! cost 1 cent per cube, Current supply " + player.inventory.iceCubes + " You funds are currently: $" + player.wallet.Money);
            store.SellIceCubes(player);
            Console.WriteLine(" Finnaly, lets get some cups. 25 cents per cup, Current supply " + player.inventory.cups + " You funds are currently: $" + player.wallet.Money);
            store.SellCups(player); Console.WriteLine(" Thanks for shooping at the store!! You have$" + player.wallet.Money+" left. ");
            Console.WriteLine(player.name + " currently has " + player.inventory.lemons + " lemons, " + player.inventory.sugarCubes + " sugar cubes, and " + player.inventory.iceCubes + " icecubes left. You also have " + player.inventory.cups + " cups.");
            Console.ReadLine();
        }
            
           





        

            
            
            
            
            


            





        


            
            
            
            
            
            





        
    }
}
