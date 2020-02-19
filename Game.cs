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

        int currentDay = 0;

        public Game()
        {
            days = new List<Day> { new Day() };
            StartGame();
            while (currentDay <= 8){


                days[currentDay].dayCounter= days[currentDay].RunDay(player,currentDay);
               
                days[currentDay].StoreRunner(store, player);
                player.recipe.SetRecipie();
                
                player.CreatePitcher();
                days[currentDay].CreateCustomers(player);
                currentDay = days[currentDay].dayCounter;
                days.Add(new Day());

            } 
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
            store = new Store();
        }

       









            




        
        
        
            
           





        

            
            
            
            
            


            





        


            
            
            
            
            
            





        
    }
}
