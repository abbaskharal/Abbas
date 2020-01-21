using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Cafe_Management_Systems
{
    class Cafe
    {
        //Default Constructor
        public Cafe()
        {
            newChicBur = 0.0;
            newChicMeal = 0.0;
            newCheeseBur = 0.0;
            newstraSha = 0.0;
            newmanShak = 0.0;
            neworaShake = 0.0;

        }
        //overload Constructor
        public Cafe(double ChicBur, double ChicMeal, double CheeseBur, double straSha, double manShak, double oraShake)
        {
            newChicBur = ChicBur;
            newChicMeal = ChicMeal;
            newCheeseBur = CheeseBur;
            newstraSha = straSha;
            newmanShak = manShak;
            neworaShake = oraShake;
        }
        //Accesor function

        public double getChicBur()
        {
            return newChicBur;
        }
        public double getChicMeal()
        {
            return newChicMeal;
        }
        public double getCheeseBur()
        {
            return newCheeseBur;
        }
        public double getstraSha()
        {
            return newstraSha;
        }
        public double getoraShake()
        {
            return neworaShake;
        }
        public double getmanShak()
        {
            return newmanShak;
        }


        //Member variables declared for Burgers
       private double newChicBur;
       private double newChicMeal;
       private double newCheeseBur;
       private double newstraSha;
       private double newmanShak;
       private double neworaShake;
    }
}
