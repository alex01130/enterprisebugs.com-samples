using EnterpriseBugs.WebServiceDemo.WebServiceClient.com.ezzylearning.www;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseBugs.WebServiceDemo.WebServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // get a instance of the webservice
            CountryInformationService service = new CountryInformationService();
            // call the method
            string result = service.GetPopulationByCountry("Germany");

            Console.WriteLine("Germany has a population of: " + result);
            Console.ReadLine();

        }
    }
}
