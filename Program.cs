using System;

namespace MoccaMaster
{
    class Program
    {
        //Create Moccamaster
        public static MoccaMaster moccaMaster = new(false);
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Moccamaster multibrewer");
            Console.WriteLine();

            //Add amoun of water
            moccaMaster.water.AddWater();

            //Open the filter funnel
            moccaMaster.filterFunnel.OpenCloseFilterFunnel();

            //Insert a filter
            moccaMaster.filter.InsertFilter();

            //Select if the mashine should brew coffee or tea. More options can be easely added through the IBrewType Interface
            moccaMaster.selectBrew.Select();
            switch (moccaMaster.selectBrew.Selection)
            {
                case "Coffee":
                    moccaMaster.coffeeBean.Add();//If coffee, add beans
                    break;

                case "Tea":
                    moccaMaster.teaLeaf.Add();//If tea add tea leafs
                    break;
            }

            //Close the filter funnel
            moccaMaster.filterFunnel.OpenCloseFilterFunnel();

            //Turn on the brewer
            moccaMaster.TurnOnOff();

            //The machine is brewing
            moccaMaster.brew.BrewStart();

            Console.ReadLine();
        }
    }
}
