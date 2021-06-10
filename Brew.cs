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

        //Method to start the brewing
        #region Methods
        public void BrewStart()
        {
            Console.WriteLine("The Moccamaster multibrewer is now brewing");
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(" Blob ");//Blobbing 20 times
                Thread.Sleep(250);///Pausing the thread.
            }
            Console.WriteLine();
            Console.WriteLine("Concratulation. Your drink is now ready. Enjoy");
        }
        #endregion
    }
}
