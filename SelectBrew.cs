using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoccaMaster
{
    public class SelectBrew
    {

        #region Fields
        private string selection;
        #endregion



        #region Properties

        public string Selection
        {
            get { return selection; }
            set { selection = value; }
        }
        #endregion



        #region Constructors

        #endregion


        //Method to add drinks. relative easy to add additional drink types
        #region Methods
        public void Select()
        {
            bool run = true;
            while (run)//Just a loop (basicly not nessesary. but its getting late. So it stays.
            {

                Console.WriteLine("Please Choose you drink || press: 1 for coffee || press: 2 for Tea ||");
                char input = Console.ReadKey(false).KeyChar;//Receive input
                Console.WriteLine();
                try
                {
                    switch (input)
                    {
                        case '1':
                            Selection = "Coffee";//Adding the value to the Attribute
                            Console.WriteLine("You have choosen " + Selection);
                            run= false;
                           break;
                            
                        case '2':
                            Selection = "Tea";//Adding the value to the Attribute
                            Console.WriteLine("You have choosen " + Selection);
                            run = false;
                            break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("The selected input is not valid!");
                }
                Console.WriteLine();

            }
        }
        #endregion
    }
}
