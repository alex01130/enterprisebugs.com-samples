using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseBugs.MsTestRowTestSample.BusinessLogic
{
    public class CountryHandler
    {
        /// <summary>
        /// Get the Image for a given country
        /// </summary>
        /// <remarks>
        /// The following requirements must be fulfilled:
        /// <list type="bullet">
        /// <item>"germany" return "germany.gif"</item>
        /// <item>"usa" return "usa.gif"</item>
        /// <item>all other countries return "unknown.gif"</item>
        /// </list>
        /// </remarks>
        /// <param name="country"></param>
        /// <returns></returns>
        public string GetImageForCountry(string country)
        {
            if (country == "germany")
            {
                return "germany.gif";
            }
            if (country == "usa")
            {
                return "usa.gif";
            }

            return "unknown.gif";
        }
    }
}
