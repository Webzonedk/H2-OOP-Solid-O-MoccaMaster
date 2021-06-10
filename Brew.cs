using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MoccaMaster
{
    public class Brew
    {
        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Constructors

        #endregion

        #region Methods
        public void BrewStart()
        {
            Console.WriteLine("The coffeemachine is now brewing");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(" Blob ");
                Thread.Sleep(250);
            }
            Console.WriteLine();
            Console.WriteLine("Concratulation. You now have the best cup of coffee in the world. Enjoy");
        }
        #endregion
    }
}
