
using EnterpriseBugs.FakeWebservice.WebServiceClient.localhost;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;

namespace EnterpriseBugs.FakeWebservice.WebServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Get a instance of the service
            CountryInformationService service = new CountryInformationService();

            // 2. Call a method on the service
            // notice that it will throw a NotImplementedException.
            try
            {
                service.GetServiceName();
            }
            catch (SoapException soapEx)
            {
                // for the Demonstration this is supposed to happen
            }


            // 3. Call another method on the service
            // in this case a fake is returned.
            // now you can implement the GetCountries method in CountryInformationService.asmx.cs
            // to return values you want
            DataSet serviceCall = service.GetCountries();
            DataTable allCountries = serviceCall.Tables["Countries"];
            foreach (DataRow country in allCountries.Rows)
            {
                string line = string.Format("ISO2: {0}, ISO3: {1}, Country:{2}", country["ISO2"], country["ISO3"], country["Country"]);
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }
    }
}
