using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoccaMaster
{//A Classs to be able to make a cup of coffe. This is basicly a mangager class connectet to a lot of the other clases
    public class MoccaMaster : IOnOff //Implemented in the IOnOff Interface

    {//Instantianting the objects
        public Water water = new Water();
        public FilterFunnel filterFunnel = new FilterFunnel(OpenClose.closed);
        public Filter filter = new Filter();
        public CoffeeBean coffeeBean = new CoffeeBean();
        public TeaLeaf teaLeaf = new TeaLeaf();
        public Brew brew = new Brew();
        public SelectBrew selectBrew = new SelectBrew();

        //Fields
        #region Fields
        private bool powerStatus;
        #endregion


        //Properties
        #region Properties

        public bool PowerStatus
        {
            get { return powerStatus; }
            set { powerStatus = value; }
        }

        #endregion


        //Constructors
        #region Constructors
        public MoccaMaster(bool powerStatus)
        {
            this.powerStatus = powerStatus;
        }
        #endregion


        //Method to Turn on the machine
        #region Methods
        public bool TurnOnOff()
        {
            Console.WriteLine("Press any key to start brewing.");
            Console.ReadKey(true);
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
