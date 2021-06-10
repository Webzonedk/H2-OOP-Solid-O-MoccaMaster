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
        //Method to insert filter into the machine
        #region Methods
        public void InsertFilter()
        {
            Console.WriteLine("Press any key to insert filter");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("You have added a filter");
            Console.WriteLine();
        }
        #endregion
    }
}
