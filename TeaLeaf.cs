using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//A Class to select and add Tea types
namespace MoccaMaster
{
    public class TeaLeaf: IBrewType // implementet in the IBrewType interface
    {

        #region Fields
        private string type;

        #endregion



        #region Properties
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        #endregion



        #region Constructors
        public TeaLeaf(string type)
        {
            this.type = type;
        }

        public TeaLeaf()
        {

        }

        #endregion


        //Method to add tea leafs to the machine
        #region Methods
        public void Add()
        {
            bool run = true;
            while (run)
            {

                Console.WriteLine("Which kind of Tea would you like? Please Chose: || 1: Forest Fruit || 2: Earl Gray || 3: Citrus ||");
                char input = Console.ReadKey(false).KeyChar;//Receive input
                Console.WriteLine();
                try
                {
                    switch (input)//Chose output dependant of the input
                    {
                        case '1':
                            Type = "Forest Fruit";
                            Console.WriteLine("You have choosen " + Type);
                            run = false;
                            break;
                        case '2':
                            Type = "Earl Gray";
                            Console.WriteLine("You have choosen " + Type);
                            run = false;

                            break;
                        case '3':
                            Type = "Citrus";
                            Console.WriteLine("You have choosen " + Type);
                            run = false;
                            break;

                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("The selected input is not valid!");
                }
            }

        }
        #endregion
    }
}
