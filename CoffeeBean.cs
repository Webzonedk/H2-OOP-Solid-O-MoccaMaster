using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This class is made to be able to create new coffebeans of different types
namespace MoccaMaster
{
    public class CoffeeBean
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
        public CoffeeBean(string type)
        {
            this.type = type;
        }

        public CoffeeBean()
        {

        }

        #endregion

        #region Methods
        public void AddBeans()
        {
            Console.WriteLine("Which kind of beans would you like? Please Chose: || 1: Arabika coffee || 2: Robusta coffe || 3: Liberica coffe ||");
            char input= Console.ReadKey(false).KeyChar;
            Console.WriteLine();
            try
            {
                switch (input)
                {
                    case '1':
                        Type = "Arabika coffee";
                        Console.WriteLine("You have choosen " + Type);

                        break;
                    case '2':
                        Type = "Robusta coffee";
                        Console.WriteLine("You have choosen " + Type);

                        break;
                    case '3':
                        Type = "Liberica coffee";
                        Console.WriteLine("You have choosen " + Type);
                        break;

                }
            }
            catch (Exception)
            {

                Console.WriteLine("The selected input is not valid!");
            }
          
        }
        #endregion
    }
}
