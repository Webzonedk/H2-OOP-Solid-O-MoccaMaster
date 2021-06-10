using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoccaMaster
{
    //A class to make a method to open/close filterfunnel
    public enum OpenClose { opened, closed }//Enum to apply values to the openclose switch
    public class FilterFunnel
    {
        #region Fields
        private OpenClose openCloseStatus;
        #endregion



        #region Properties
        public OpenClose OpenCloseStatus
        {
            get { return openCloseStatus; }
            set { openCloseStatus = value; }
        }

        #endregion



        #region Constructors
        public FilterFunnel(OpenClose openCloseStatus)
        {
            this.openCloseStatus = openCloseStatus;
        }
        #endregion


        //Method to open or close the filter funnel
        #region Methods
        public void OpenCloseFilterFunnel()
        {
            switch (OpenCloseStatus)
            {
                case OpenClose.opened://If filter funnel is open
                    Console.WriteLine("Press any key to close the filter Funnel");
                    Console.ReadKey(true);
                    Console.WriteLine("You have closed the Filter Funnel");
                    openCloseStatus = OpenClose.closed;//Changing the filter funnel status to closed
                    Console.WriteLine();
                    break;
                case OpenClose.closed://If filter funnel is closed
                    Console.WriteLine("Press any key to open the filter Funnel");
                    Console.ReadKey(true);
                    Console.WriteLine("You have opened the Filter Funnel");
                    openCloseStatus = OpenClose.opened;//Changing the filter funnel status to open
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
