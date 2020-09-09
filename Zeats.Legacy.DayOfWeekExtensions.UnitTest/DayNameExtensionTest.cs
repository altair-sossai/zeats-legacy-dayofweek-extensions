using System;
using System.Globalization;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Legacy.DayOfWeekExtensions.UnitTest
{
    [TestClass]
    public class DayNameExtensionTest
    {
        [TestMethod]
        public void DayNameEnUs()
        {
            var cultureInfo = new CultureInfo("en-us");

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            Assert.AreEqual("Sunday", DayOfWeek.Sunday.DayName());
            Assert.AreEqual("Monday", DayOfWeek.Monday.DayName());
            Assert.AreEqual("Tuesday", DayOfWeek.Tuesday.DayName());
            Assert.AreEqual("Wednesday", DayOfWeek.Wednesday.DayName());
            Assert.AreEqual("Thursday", DayOfWeek.Thursday.DayName());
            Assert.AreEqual("Friday", DayOfWeek.Friday.DayName());
            Assert.AreEqual("Saturday", DayOfWeek.Saturday.DayName());
        }

        [TestMethod]
        public void DayNamePtBr()
        {
            var cultureInfo = new CultureInfo("pt-br");

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            Assert.AreEqual("Domingo", DayOfWeek.Sunday.DayName());
            Assert.AreEqual("Segunda-feira", DayOfWeek.Monday.DayName());
            Assert.AreEqual("Terça-feira", DayOfWeek.Tuesday.DayName());
            Assert.AreEqual("Quarta-feira", DayOfWeek.Wednesday.DayName());
            Assert.AreEqual("Quinta-feira", DayOfWeek.Thursday.DayName());
            Assert.AreEqual("Sexta-feira", DayOfWeek.Friday.DayName());
            Assert.AreEqual("Sábado", DayOfWeek.Saturday.DayName());
        }
    }
}