using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        public int sellCount;
        public int sellChance;
        public int dayCounter = 0;
        public Weather weather;
        Random random = new Random();
        public List<Customers> customers = new List<Customers>();
        public int i;
        public int pplCount = 0;
        
        //Constructor
        public Day()
        {




            weather = new Weather();







        }
        //Member Methods
        public int BuildDay(Player player)
        {

            if (dayCounter >= 7) { Console.WriteLine(" Game Over!! This run You made $"+(player.wallet.Money-20)+" in a week (maybe you should stick to Coding) "  ); Console.ReadLine(); Environment.Exit(0); }
            else { Console.WriteLine("Good Morning!! Today is day : " + (dayCounter+1) + " Lets look at the Forecast. "); dayCounter++; new Day(); weather.ChooseWeather(); }



            Console.WriteLine(" Now that we have a idea of what kind of weather day: " + dayCounter+ " is supposed to have, Would you like to visit the Store?(Y/N) ");
            string ans = Console.ReadLine().ToLower();
            switch (ans)
            {
                case "yes":
                case "yeah":
                case "yup":
                case "yea":
                case "y":
                case " ":


                    break;
                default: Console.WriteLine("Alrighty then."); break;
            }

            return dayCounter;
        }
        public void CreateCustomers(Player player)
        {
            i = random.Next(5,20);


            while (pplCount <= i)
            {

                customers.Add(new Customers());
                
                Console.WriteLine(customers[pplCount].name+ " maybe a new  customer !! There have been " + customers.Count() + " people to walk by today.");
                BuyIncentives(player);pplCount++;
            }


            Console.ReadLine();
            EndDay(player);


        }
        public int RunDay(Player player ,int daycounter)
        {
            this.dayCounter = daycounter;
            if (dayCounter <= 0)
            {
                InitalDay(player);

            }
            else { BuildDay(player); }



            return dayCounter;



        }
        public void StoreRunner(Store store, Player player)
        {
            Console.WriteLine(" Great!! Firstly, before we start buying up some shhhh, lets take stock of our inventory. ");
            Console.WriteLine(player.name + " currently has " + player.inventory.lemons.Count + " lemons, " + player.inventory.sugarCubes.Count + " sugar cubes, and " + player.inventory.iceCubes.Count + " icecubes left. You also have " + player.inventory.cups.Count + " cups.");
            Console.ReadLine();
            Console.WriteLine(" Now that you have taken stock, lets look at the price of materials.");
            Console.WriteLine(" Lemons are $.50 a piece. Sugar is $.10 per cube. Ice cubes are priced at $.01 per cube. Cups are $.25 a piece. 10 cups make a pitcher. ");
            Console.ReadLine();
            Console.WriteLine(" First is lemons Cost: 50 cents, Current supply " + player.inventory.lemons.Count + " You funds are currently: $" + player.wallet.Money);
            store.SellLemons(player);
            Console.WriteLine(" Next lets buy some sugar!! Cost: 10 cents per cube, Current supply " + player.inventory.sugarCubes.Count + " You funds are currently: $" + player.wallet.Money);
            store.SellSugarCubes(player);
            Console.WriteLine(" Now, lets buy some ice!! cost 1 cent per cube, Current supply " + player.inventory.iceCubes.Count + " You funds are currently: $" + player.wallet.Money);
            store.SellIceCubes(player);
            Console.WriteLine(" Finnaly, lets get some cups. 25 cents per cup, Current supply " + player.inventory.cups.Count + " You funds are currently: $" + player.wallet.Money);
            store.SellCups(player); Console.WriteLine(" Thanks for shooping at the store!! You have $" + player.wallet.Money + " left. ");
            Console.WriteLine(player.name + " currently has " + player.inventory.lemons.Count + " lemons, " + player.inventory.sugarCubes.Count + " sugar cubes, and " + player.inventory.iceCubes.Count + " icecubes left. You also have " + player.inventory.cups.Count + " cups.");
            Console.ReadLine();
        }
        public void BuyIncentives(Player player)
        {
            switch (weather.condition)
            {
                case "Sunny":
                    sellChance = 4;
                    break;
                case "Rainy/Overcast":
                    sellChance = 8; break;
                case "Cloudy":
                    sellChance = 6; break;

            }
            if (player.recipe.amountOfSugarCubes >= 4)
            {
                sellChance = sellChance - 2;
            }
            if (player.recipe.amountOfLemons >= 5)
            {
                sellChance = sellChance + 2;
            }
            if (weather.tempature >= 80)
            {
                sellChance = sellChance - 2;

            }
            if (weather.tempature <= 50)
            {
                sellChance = sellChance + 3;

            }
            if (player.recipe.amountOfLemons <= 2) { sellChance = sellChance + 1; }
            if (player.recipe.amountOfSugarCubes <= 2) { sellChance = sellChance + 2; }
            if (player.recipe.pricePerCup<=1) { sellChance = sellChance - 1; }
            else if (player.recipe.pricePerCup >= 1.5) { sellChance = sellChance + 2; }
            else { sellChance = sellChance + 1; } 
            if (sellChance <= 4&& pplCount==0) { Console.WriteLine(" gonna be a HOT market today boss!! "); }
            else if (sellChance > 4 && sellChance <= 7 && pplCount ==0) { Console.WriteLine(" Might catch a few today. meh."); }
            else if (sellChance >= 8 && pplCount ==0) { Console.WriteLine("Prolly wasted your time today boss "); }
            Console.ReadLine();
            

             if(sellChance <= customers[pplCount].buyChance) 
            {player.PourCup(); Console.WriteLine(customers[pplCount].name + " bought a glass!! you made $" + player.recipe.pricePerCup + " dollars total funds: $" + player.wallet.Money);
              sellCount++; Console.WriteLine("You made " + sellCount + " sales so far today"); Console.ReadLine(); }

            else { Console.WriteLine(customers[pplCount].name+" elected to keep it pushing. you missed "+(pplCount+1-sellCount)+" sales today. "); }

            //go to store
            //set recipe
            //open for sales
            //statictistics
            //end of day
        }
        public void EndDay(Player player)
        {
            Console.WriteLine(" Congrats " + player.name + "!! another day another dollar! You finished day: " + dayCounter + " . You made $" + player.recipe.pricePerCup * sellCount);
            player.pitcher.cupsLeftInPitcher = 0;
            Console.WriteLine(" Had to throw out remaining lemonade. ");
        }

        public int InitalDay(Player player)
        {
            Console.WriteLine(" Today is the first day of your lemonade stand. " + player.name + " , I think you would be best served by looking at the forecast. ");
            Console.ReadLine();
            weather.ChooseWeather();
            dayCounter++;
            Console.WriteLine(" Now that we have a idea of what kind if weather day: " + dayCounter + " is supposed to have, Would you like to visit the Store?(Y/N) ");
            string ans = Console.ReadLine().ToLower();
            switch (ans)
            {
                case "yes":
                case "yeah":
                case "yup":
                case "yea":
                case "y":
                case " ":
                    return dayCounter;

                    
                default: Console.WriteLine("Alrighty then."); return dayCounter; 
                    
            }
        }
    }
}
