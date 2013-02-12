using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnterpriseBugs.MsTestRowTestSample.BusinessLogic.Test
{
    [TestClass]
    public class CountryHandlerTest
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }


        [TestMethod]
        [DeploymentItem("BusinessLogic.Test\\TestData\\GetImageForCountry.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\GetImageForCountry.xml", "Row", DataAccessMethod.Sequential)]
        public void GetImageForCountry_SeveralTests()
        {
            // Get data out of the XML File
            string country = testContextInstance.DataRow["Country"].ToString();
            string image = testContextInstance.DataRow["Image"].ToString();

            Execute_GetImageForCountry_SeveralTests(country, image);
        }

        /// <summary>
        /// Helper Method that executes the test
        /// </summary>
        /// <param name="country"></param>
        /// <param name="image"></param>
        private void Execute_GetImageForCountry_SeveralTests(string country, string image)
        {
            #region Arrange

            string expected = image;
            CountryHandler target = new CountryHandler();

            #endregion

            #region Act

            string actual = target.GetImageForCountry(country);

            #endregion

            #region Assert

            Assert.AreEqual(expected, actual);

            #endregion
        }
    }
}
