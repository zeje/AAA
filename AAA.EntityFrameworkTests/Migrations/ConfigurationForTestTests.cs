using Microsoft.VisualStudio.TestTools.UnitTesting;
using AAA.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA.Migrations.Tests
{
    [TestClass()]
    public class ConfigurationForTestTests
    {
        [TestMethod()]
        public void InitTest()
        {
            ConfigurationForTest.Init();
        }
    }
}