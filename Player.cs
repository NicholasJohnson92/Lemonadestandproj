using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public int pitchercounter;
        public string name;
        // constructor (SPAWNER)
        public Player()
        {
            Console.WriteLine("Please choose a Player name ");
            name = Console.ReadLine().ToUpper( );
            inventory = new Inventory();
            wallet = new Wallet();
        }

        // member methods (CAN DO)
        public int UseRecipe()
        { if (inventory.iceCubes.Count() > 0 && inventory.lemons.Count() > 0 && inventory.sugarCubes.Count() > 0 && inventory.cups.Count() > 0)
            {
                inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
                inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);
                inventory.iceCubes.RemoveRange(0, (recipe.amountOfIceCubes*10)); pitchercounter++;
                Console.WriteLine(" You mixed ingredient ratio of "+recipe.amountOfLemons+" lemons, to, " +recipe.amountOfSugarCubes+" sugar cubes, and " +recipe.amountOfIceCubes+"icecubes oper cup. ");
                Console.WriteLine(" You have " + recipe.amountOfLemons + " of lemons, " + recipe.amountOfSugarCubes + " sugar cubes, and " + recipe.amountOfIceCubes + " icecubes left. ");
            }
            else { Console.WriteLine(" Not enough ingredients!! "); }
            Console.WriteLine(" Would you like to Change recipe?? ");
            try
            {
                string ans = Console.ReadLine().ToLower();
                switch (ans)
                {
                    case "yes":
                    case "yeah":
                    case "yup":
                    case "1":
                    case "affirmative": { recipe.SetRecipie(); break; }
                    default: { Console.WriteLine("You will keep ingredient ratio of " + recipe.amountOfLemons + " lemons, to, " + recipe.amountOfSugarCubes + " sugar cubes, and " + recipe.amountOfIceCubes + " icecubes oper cup. "); break; }
                }



                return pitchercounter;
            }
            catch (Exception)
            {
                Console.WriteLine(" Error. please enter a yes or no input "); UseRecipe(); return pitchercounter; 
            }
        }
        public void CreatePitcher()
        {
            try
            {

                pitchercounter = UseRecipe(); Console.WriteLine("Would you like to create a new pitcher?");
                string ans = Console.ReadLine().ToLower();
                switch (ans)
                {
                    case "yes":
                    case "yeah":
                    case "yup":
                    case "1":
                    case "affirmative":
                        {

                            if (pitchercounter > 0) { Console.WriteLine("There is still " + pitcher.cupsLeftInPitcher + " cups left in open picture, please use this before creating a new pitcher. "); Console.ReadLine(); }
                            else { { pitcher = new Pitcher(); } Console.WriteLine(" A new picture is created!! There is  " + pitchercounter + " pitchers, with  " + pitcher.cupsLeftInPitcher + " cups left "); }
                            pitchercounter++;Console.ReadLine(); break; 
                        }
                    default: { Console.WriteLine("You elected to not create Pitcher"); Console.ReadLine(); break; }
                }
            }
            catch (Exception) { Console.WriteLine(" Error. please enter a yes or no input ");UseRecipe(); }
            
                

            



        }
        public void PourCup()
        {


            if (pitcher.cupsLeftInPitcher < 0) { Console.WriteLine(" The pitcher is Empty!! to Sell more lemonade make a new batch!! "); CreatePitcher(); }
            else { pitcher.cupsLeftInPitcher--;wallet.Money= wallet.Money+recipe.pricePerCup; Console.WriteLine(" You sold a cup of lemonade!  There are " + pitcher.cupsLeftInPitcher + " left." ); }
        }










        










    }
        
        
        
        
        
        
        
        
    
}
