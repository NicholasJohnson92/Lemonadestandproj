using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customers
    { 
        public string name;
        List<string> names = new List<string>() { "Ashley", "MacKenzie", "Greta", "Tom", "Sam", "Wolfie", "Max", "Grom", "Sharon", "Kim", "Pam", "Liz", "Ang", "Hunter", "Candice" };
        Random random = new Random();
        Wallet wallet;
        public int buyChance;
        int i;
        public Customers()
        {
            i = random.Next(0, 14);         
            name = names[i];
            Console.ReadLine();
            buyChance = random.Next(0, 10);
            wallet = new Wallet();


            
           





        }

        


            
            
        
        
        
        
        
        
        






        
            
            
               
        
        
        
        
        
        
        
        
        
        
    }
}
