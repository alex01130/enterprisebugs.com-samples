using EnterpriseBugs.FakeWebservice.WebServiceClient.localhost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseBugs.FakeWebservice.WebServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryInformationService service = new CountryInformationService();
            service.GetCountries();
        }
    }
}
