using EnterpriseBugs.WebServiceDemo;
using System;
using System.Collections.Generic;
using System.Data;
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
            // Just return some dummy values in order the method to work
            return PopulateDataSet();
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

        /// <summary>
        /// Returns the Fake Countries
        /// </summary>
        /// <returns></returns>
        private static DataSet PopulateDataSet()
        {
            DataSet ds = new DataSet();

            #region Countries

            DataTable dtCountries = new DataTable("Countries");
            dtCountries.Columns.Add(new DataColumn("ISO2", typeof(string)));
            dtCountries.Columns.Add(new DataColumn("ISO3", typeof(string)));
            dtCountries.Columns.Add(new DataColumn("Country", typeof(string)));

            DataRow drCountries = dtCountries.NewRow();
            drCountries["ISO2"] = "AX";
            drCountries["ISO3"] = "ALA";
            drCountries["Country"] = "Aland Islands";
            dtCountries.Rows.Add(drCountries);

            drCountries = dtCountries.NewRow();
            drCountries["ISO2"] = "CN";
            drCountries["ISO3"] = "CHN";
            drCountries["Country"] = "China";
            dtCountries.Rows.Add(drCountries);

            drCountries = dtCountries.NewRow();
            drCountries["ISO2"] = "DE";
            drCountries["ISO3"] = "DEU";
            drCountries["Country"] = "Germany";
            dtCountries.Rows.Add(drCountries);

            drCountries = dtCountries.NewRow();
            drCountries["ISO2"] = "FR";
            drCountries["ISO3"] = "FRA";
            drCountries["Country"] = "France";
            dtCountries.Rows.Add(drCountries);

            ds.Tables.Add(dtCountries);

            #endregion

            #region Population

            DataTable dtPopulation = new DataTable("Population");
            dtPopulation.Columns.Add(new DataColumn("Country", typeof(string)));
            dtPopulation.Columns.Add(new DataColumn("Population", typeof(string)));

            DataRow drPopulation = dtPopulation.NewRow();
            drPopulation["Country"] = "Aland Islands";
            drPopulation["Population"] = "26711";
            dtPopulation.Rows.Add(drPopulation);

            drPopulation = dtPopulation.NewRow();
            drPopulation["Country"] = "China";
            drPopulation["Population"] = "1330044000";
            dtPopulation.Rows.Add(drPopulation);

            drPopulation = dtPopulation.NewRow();
            drPopulation["Country"] = "Germany";
            drPopulation["Population"] = "82369000";
            dtPopulation.Rows.Add(drPopulation);

            drPopulation = dtPopulation.NewRow();
            drPopulation["Country"] = "France";
            drPopulation["Population"] = "64094000";
            dtPopulation.Rows.Add(drPopulation);

            ds.Tables.Add(dtPopulation);

            #endregion

            return ds;
        }
    }
}
