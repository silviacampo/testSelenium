using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN.Core;

namespace testgossip.Watin.Login
{
    [TestClass]
    public class IETest
    {
        private IE browser;

        [TestMethod]
        public void TestEmptyLogin()
        {
            string message = "";
            Assert.IsTrue(WatinIEUtils.TestEmptyLogin(browser, Constants.GSWebLoginPage, out message), message);
        }

        [TestMethod]
        public void TestInvalidLogin()
        {
            string message = "";
            Assert.IsTrue(WatinIEUtils.TestInvalidLogin(browser, Constants.GSWebLoginPage, out message), message);
        }

        [TestMethod]
        public void TestInexistantLogin()
        {
            string message = "";
            Assert.IsTrue(WatinIEUtils.TestInexistantLogin(browser, Constants.GSWebLoginPage, out message), message);
        }
    }
}
