using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{// I believe the set recipe function follows the S principle and the O principle.
    class Recipe
    {
      public  int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;




        public Recipe()
        {


         
        
        
        
        
        }









        public void SetRecipie()
        {
            Console.WriteLine(" Please set a Recipe "); Console.ReadLine();
            Console.WriteLine(" How many lemons do you want to use per pitcher? (max-9) " );
            try
            {
                string lemNums = Console.ReadLine().ToLower();
                if (lemNums.Length >= 2) { Console.WriteLine(" Incorrect format please Enter a single digit "); }
                else { amountOfLemons = int.Parse(lemNums); }
                Console.WriteLine(" You chose to use " + amountOfLemons + " lemons per pitcher ");
                Console.WriteLine(" Next, Choose the amount of sugar cubes you want to use per pitcher?? (max-9) ");

                string sugNums = Console.ReadLine().ToLower();
                if (sugNums.Length >= 2) { Console.WriteLine(" Incorrect format please Enter a single digit "); }
                else { amountOfSugarCubes = int.Parse(sugNums); }
                Console.WriteLine(" You chose to use " + amountOfSugarCubes + " sugar cubes per pitcher ");
                Console.WriteLine(" Now, how many Ice Cubes do you want per cup? (max-9) ");
                string iceNums = Console.ReadLine().ToLower();
                if (iceNums.Length >= 2) { Console.WriteLine(" Incorrect format please Enter a single digit "); }
                else { amountOfIceCubes = int.Parse(iceNums); }


                Console.WriteLine(" You chose to use " + amountOfIceCubes + " Ice cubes per pitcher ");
                Console.WriteLine(" Lastly, set the price you want to sell cups of Lemonade for (enter " + "'25'" + " for 25 cents ect.) ");
                double cprice = double.Parse(Console.ReadLine().ToLower());
                pricePerCup = cprice / 100;
                Console.WriteLine(" price is now set to $" + pricePerCup);
                Console.ReadLine();
            }

            catch (Exception) { Console.WriteLine(" Input should be numbers only within accpeted ranges please try again. "); SetRecipie(); }





        }

















    }
}
