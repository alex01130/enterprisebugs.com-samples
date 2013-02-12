using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeMock.ArrangeActAssert;

namespace EnterpriseBugs.ControllingWithTypemock.BusinessLogic.Test
{
    [TestClass, Isolated(DesignMode.Pragmatic)]
    public class DateTimeHelperTest
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        /// <summary>
        ///A test for GetImageForCurrentTime
        ///</summary>
        [TestMethod()]
        [DeploymentItem("BusinessLogic.Test\\TestData\\GetImageForCurrentTime_TestBoundaries.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\GetImageForCurrentTime_TestBoundaries.xml", "Row", DataAccessMethod.Sequential)]
        public void GetTextForCurrentDateTest()
        {
            int hourToTest = Int32.Parse((string)TestContext.DataRow["HourToTest"]);
            string assertValue = (string)TestContext.DataRow["AssertValue"];

            Execute_GetTextForCurrentDateTest(hourToTest, assertValue);
        }

        private void Execute_GetTextForCurrentDateTest(int hourToTest, string assertValue)
        {
            #region Arrange

            string expected = assertValue;
            // If DateTime.Now is called, our DateTime wil be returned
            DateTime controlledDate = new DateTime(2013, 1, 1, hourToTest, 0, 0);
            // This is very the Typemock magic happens!
            Isolate.WhenCalled(() => DateTime.Now).WillReturn(controlledDate);

            #endregion

            #region Act

            string actual = DateTimeHelper.GetTextForCurrentDate();

            #endregion

            #region Assert

            Assert.AreEqual(expected, actual);

            #endregion
        }
    }
}
