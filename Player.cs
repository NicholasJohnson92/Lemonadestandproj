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
            
            recipe = new Recipe();

        }

        // member methods (CAN DO)
        public int UseRecipe()
        { try
            {
                if (inventory.iceCubes.Count() > 0 && inventory.lemons.Count() > 0 && inventory.sugarCubes.Count() > 0 && inventory.cups.Count() > 0)
                {
                    inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
                    inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);
                    inventory.iceCubes.RemoveRange(0, (recipe.amountOfIceCubes * 10)); pitchercounter = 0;
                    Console.WriteLine(" You mixed ingredient ratio of " + recipe.amountOfLemons + " lemons, to, " + recipe.amountOfSugarCubes + " sugar cubes, and " + recipe.amountOfIceCubes + " icecubes per cup. ");
                    Console.WriteLine(" You have " + inventory.lemons.Count + "  lemons, " + inventory.sugarCubes.Count + " sugar cubes, and " + inventory.iceCubes.Count + " icecubes left. ");
                }
                else { Console.WriteLine(" Not enough ingredients!! "); }
            }
            catch (Exception) { { Console.WriteLine(" Not enough ingredients!! Lets go back to the store "); recipe.SetRecipie(); } }
            /* Console.WriteLine(" Would you like to Change recipe?? ");
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
                     default: { Console.WriteLine("You will keep ingredient ratio of " + recipe.amountOfLemons + " lemons, to, " + recipe.amountOfSugarCubes + " sugar cubes, and " + recipe.amountOfIceCubes + " icecubes per cup. "); break; }
                 }



                 return pitchercounter;
             }
             catch (Exception)
             {
                 Console.WriteLine(" Error. please enter a yes or no input "); UseRecipe();  
             }*/
            return pitchercounter;
        }
        public void CreatePitcher()
        {
            try
            {
                if (inventory.lemons.Count <= 0 || inventory.sugarCubes.Count <= 0 || inventory.iceCubes.Count <= 0 || inventory.cups.Count <= 9)
                { Console.WriteLine(" You dont have enough items in your inventory to create a pitcher. The key to a successful enterprise is proper preparation. Come back next week"); Console.ReadLine(); Environment.Exit(0);
                    
                }
                else
                {

                    pitchercounter = UseRecipe(); Console.WriteLine("Would you like to create a new pitcher?");
                    string ans = Console.ReadLine().ToLower();
                    switch (ans)
                    {
                        case "y":
                        case "yes":
                        case "yeah":
                        case "yup":
                        case "1":
                        case "affirmative":
                            {

                                if (pitchercounter >= 1) { Console.WriteLine("There is still " + pitcher.cupsLeftInPitcher + " cups left in open picture, please use this before creating a new pitcher. "); Console.ReadLine(); }
                                else { pitcher = new Pitcher(); pitchercounter++; Console.WriteLine(" A new pitcher is created!! There is  " + pitchercounter + " pitchers, with  " + pitcher.cupsLeftInPitcher + " cups left "); }
                                Console.ReadLine(); break;
                            }
                        default: { Console.WriteLine("You elected to not create Pitcher so mom made it for you"); pitcher = new Pitcher(); Console.ReadLine(); break; }
                    }
                }
            }
            catch (Exception) { Console.WriteLine(" Error. please enter a yes or no input "); UseRecipe(); }
        
            
                

            



        }
        public void PourCup()
        {


            if (pitcher.cupsLeftInPitcher<= 0) { Console.WriteLine(" The pitcher is Empty!! to Sell more lemonade make a new batch!! "); CreatePitcher(); }
            else { pitcher.cupsLeftInPitcher--;wallet.Money= wallet.Money+recipe.pricePerCup; inventory.cups.RemoveAt(0);  }
        }










        










    }
        
        
        
        
        
        
        
        
    
}
