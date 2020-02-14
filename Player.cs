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
        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        // member methods (CAN DO)
        public int UseRecipe()
        { if (inventory.iceCubes.Count() > 0 && inventory.lemons.Count() > 0 && inventory.sugarCubes.Count() > 0 && inventory.cups.Count() > 0)
            {
                inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
                inventory.sugarCubes.RemoveRange(0, recipe.amountOfSugarCubes);
                inventory.iceCubes.RemoveRange(0, recipe.amountOfIceCubes); pitchercounter++;
            }
            else { Console.WriteLine(" Not enough ingredients!! "); }


            return pitchercounter;
        }
        private void CreatePitcher(int num) 
        {
            num = pitchercounter;
            if (pitchercounter>0)


        
        
        
        
        
        
        
        }
        
        
        
        
        
        
        
        
    }
}
