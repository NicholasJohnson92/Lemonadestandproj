using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    { //member Variables

        public string condition;
        public int tempature;

        List<string> weatherConditions;

        




        //Constructor


        public Weather()
        {
            
        
        
        
        
        
        
        
        
        
        
        }













        //Member Methods


        public void ChooseWeather()
        {
            Random random = new Random();
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Rainy/Overcast" };
            int i = random.Next(0, 2);
            tempature = random.Next(32, 105);
            condition = weatherConditions[i];
            Console.WriteLine( " Today the temp is " +tempature+" and the forecast is " +weatherConditions[i]);
            Console.ReadLine(); 
            

        
        
        
        
        }












    }
}
