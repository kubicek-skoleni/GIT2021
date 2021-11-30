using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace Tests
{
    [TestClass]
    public class AppcultureTest
    {
        [TestMethod]
        public void TestCultureEN()
        {
            var culture = ConsoleApp1.AppCulture.VratCulturu("EN");

            var usCulture = new CultureInfo("en-US");

            Assert.AreEqual(culture.Name, usCulture.Name);
        }
    }
}