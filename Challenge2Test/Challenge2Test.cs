using System;
using System.Security.Cryptography.X509Certificates;
using Challenge2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge2Test
{
    [TestClass]
    public class Challenge2Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var challenge2 = new Encryption();
            challenge2.Encrypt("have a nice day");
        }

        [TestMethod]
        public void DecryptMessage()
        {
            var decryption = new Decryption();

            decryption.Decrypt("hae and via ecy numsp 5 6 10");

        }
    }
}
