using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoccaMaster
{//A Class to be able to create a filer, and adding it to the filterFunnel
    public class Filter
    {
        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Constructors

        #endregion

        #region Methods
        public void InsertFilter()
        {
            Console.WriteLine("Press: 1 to insert filter");
            char input = Console.ReadKey(false).KeyChar;
            Console.WriteLine();
            try
            {

                if (input == '1')
                {
                    Console.WriteLine("You have added a filter");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("You need to press 1");
            }
        }
        #endregion
    }
}
