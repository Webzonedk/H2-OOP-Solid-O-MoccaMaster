using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoccaMaster
{
    //Class to add a specified amount of water
    public class Water
    {
        #region Fields

        private int amount;

        #endregion

        #region Properties


        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        #endregion

        #region constructors        
        public Water(int amount)
        {
            this.amount = amount;
        }

        public Water()
        {
        }
        #endregion

        #region Methods
        //Adding the selected amount of water to the MoccaMaster Saving it for later use as well
        public void AddWater()
        {
            Console.WriteLine("Please add how many cups of water to use. Only whole numbers can be used");
            string amount = (Console.ReadLine());//Receive input from user

            try
            {
            Amount = Convert.ToInt32(amount);//Adding the input to the attribute

            }
            catch (Exception)
            {
                Console.WriteLine("The input supplied was not a valid number.");
            }
            Console.WriteLine("You have added " + Amount + " cups of water");//Return output to console
            Console.WriteLine();
        }
        #endregion
    }
}
