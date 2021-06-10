using System;

namespace MoccaMaster
{
    class Program
    {
            //Create Moccamaster
        public static MoccaMaster moccaMaster = new(false);
        static void Main(string[] args)
        {
          
            //Water(AddWater)
            //FilterFunnel
            //filter
            //AddCoffeeBeans
            //OnOff (Interface)
            //BrewCoffee

            Console.WriteLine("Welcome to the Moccamaster multibrew");


            moccaMaster.water.AddWater();

            moccaMaster.filterFunnel.OpenCloseFilterFunnel();
            
            moccaMaster.filter.InsertFilter();
            Console.WriteLine("Please Choose you drink");

            moccaMaster.coffeeBean.AddBeans();


            moccaMaster.filterFunnel.OpenCloseFilterFunnel();


            moccaMaster.TurnOnOff();

            moccaMaster.brew.BrewStart();




            Console.ReadLine();
        }
    }
}
