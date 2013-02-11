using EnterpriseBugs.WebServiceDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace EnterpriseBugs.FakeWebservice.FakeService
{
    /// <summary>
    /// Summary description for CountryInformationServiceFake
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CountryInformationService : ICountryInformationServiceSoap
    {
        public string GetServiceName()
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetCountries()
        {
            throw new NotImplementedException();
        }

        public string GetCountryByTwoLetterISOCode(string twoLetterISOCode)
        {
            throw new NotImplementedException();
        }

        public string GetTwoLetterISOCodeByCountry(string countryName)
        {
            throw new NotImplementedException();
        }

        public string GetCountryByThreeLetterISOCode(string threeLetterISOCode)
        {
            throw new NotImplementedException();
        }

        public string GetThreeLetterISOCodeByCountry(string countryName)
        {
            throw new NotImplementedException();
        }

        public string GetCapitalByCountry(string countryName)
        {
            throw new NotImplementedException();
        }

        public string GetAreaInKMByCountry(string countryName)
        {
            throw new NotImplementedException();
        }

        public string GetPopulationByCountry(string countryName)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetContinents()
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetCountriesByContinent(string continentCode)
        {
            throw new NotImplementedException();
        }

        public string GetCountryByCurrencyCode(string currencyCode)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet GetCurrencies()
        {
            throw new NotImplementedException();
        }

        public string GetCurrencyCodeByCountry(string countryName)
        {
            throw new NotImplementedException();
        }

        public string GetCurrencyNameByCountry(string countryName)
        {
            throw new NotImplementedException();
        }

        public string GetCurrencyByCurrencyCode(string currencyCode)
        {
            throw new NotImplementedException();
        }
    }
}
