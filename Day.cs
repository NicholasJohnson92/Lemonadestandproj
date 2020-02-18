using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        public int dayCounter = 0;
        public Weather weather;
        Random random = new Random();
        public List<Customers> customers = new List<Customers>();
        public int i;
        public int pplCount=0;

        //Constructor
        public Day()
        {
            weather.ChooseWeather();
        
        
        
        
        
        
        
        
        
        
        
        }
        //Member Methods
        public int BuildDay() 
        {

            if (dayCounter >= 7) { Console.WriteLine(" Trial over !!"); Environment.Exit(0); }
            else { dayCounter++; weather.ChooseWeather(); }





            return dayCounter;
        } 
        public void CreateCustomers()
        {
            i = random.Next(10, 25);

            
            while (pplCount <= i)
            {

                customers.Add(new Customers());
                pplCount++;
                Console.WriteLine("new Custo!! THere have been " +customers.Count()+" people to walk by today?" ) ;
                
            }


            Console.ReadLine();



        }





    }
}
