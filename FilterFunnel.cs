using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoccaMaster
{
    //A class to make a method to open/close filterfunnel
    public enum OpenClose { opened, closed }
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

        #region Methods
        public void OpenCloseFilterFunnel()
        {
            switch (OpenCloseStatus)
            {
                case OpenClose.opened:
                    Console.WriteLine("Press any key to close the filter Funnel");
                    Console.ReadKey();
                    Console.WriteLine("You have closed the Filter Funnel");
                    openCloseStatus = OpenClose.closed;
                    break;
                case OpenClose.closed:
                    Console.WriteLine("Press any key to open the filter Funnel");
                    Console.ReadKey();
                    Console.WriteLine("You have opened the Filter Funnel");
                    openCloseStatus = OpenClose.opened;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
