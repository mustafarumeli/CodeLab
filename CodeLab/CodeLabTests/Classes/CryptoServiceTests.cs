using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeLab.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes.Tests
{
    [TestClass()]
    public class CryptoServiceTests
    {

        [TestMethod()]
        public void CheckMatchTest_ReturnsTrue()
        {
            string testPassword = "123456Ömer";
            string encrypted = CryptoService.Encrypt(testPassword);

            var result = CryptoService.CheckMatch(encrypted, testPassword);

            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void CheckMatchTest_ReturnsFalse()
        {
            string testPassword = "123456Ömer";
            string encrypted = CryptoService.Encrypt(testPassword);
            testPassword = "123456Omer";

            var result = CryptoService.CheckMatch(encrypted, testPassword);

            Assert.IsTrue(!result);
        }
    }
}