using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseBugs.ControllingWithTypemock.BusinessLogic
{
    public static class DateTimeHelper
    {
        /// <summary>
        /// Returns an text according to the current time
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Uhrzeiten die unterschieden werden sollen:
        /// <list type="bullet">
        /// <item>23-6: night</item>
        /// <item>7-10: morning</item>
        /// <item>11-13: noon</item>
        /// <item>14-22: evening</item>
        /// </list>
        /// </remarks>
        public static string GetTextForCurrentDate()
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime.Hour >= 23 || currentTime.Hour <= 6)
            {
                return "night";
            }
            if (currentTime.Hour >= 7 && currentTime.Hour <= 10)
            {
                return "morning";
            }
            if (currentTime.Hour >= 11 && currentTime.Hour <= 13)
            {
                return "noon";
            }
            if (currentTime.Hour >= 14 && currentTime.Hour <= 22)
            {
                return "evening";
            }

            throw new NotImplementedException("This sould never happen");
        }
    }
}
