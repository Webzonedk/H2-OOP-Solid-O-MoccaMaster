using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoccaMaster
{//A Classs to be able to make a cup of coffe. This is basicly a mangager class connectet to a lot of the other clases
    public class MoccaMaster : IOnOff
    {
        public Water water = new Water();
        public FilterFunnel filterFunnel = new FilterFunnel(OpenClose.closed);
        public Filter filter = new Filter();
        public CoffeeBean coffeeBean = new CoffeeBean();
        public Brew brew = new Brew();
        public SelectBrew selectBrew = new SelectBrew();
        #region Fields
        private bool powerStatus;
        #endregion



        #region Properties

        public bool PowerStatus
        {
            get { return powerStatus; }
            set { powerStatus = value; }
        }

        #endregion



        #region Constructors
        public MoccaMaster(bool powerStatus)
        {
            this.powerStatus = powerStatus;
        }
        #endregion



        #region Methods

        public bool TurnOnOff()
        {
            Console.WriteLine("Press any key to turn on the MoccaMaster and get the best cup of coffe you have ever tasted.");
            Console.ReadKey();
            Console.WriteLine();
            if (PowerStatus == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
