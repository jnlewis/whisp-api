using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Whisp.Infrastructure;

namespace Whisp.Tests.Infrastructure.Logging
{
    [TestClass]
    public class AppLoggerTests
    {
        [TestMethod]
        public void InitAppLoggerTest()
        {
            var logger = new AppLogger();
        }

        [TestMethod]
        public void AppLoggerWriteTest()
        {
            var logger = new AppLogger();
            logger.Info("Write info test");
            logger.Trace("Write Trace test");
            logger.Error("Write Error test");
            logger.Fatal("Write Fatal test");
            logger.Warn("Write Warninfo test");
            logger.Exception(new Exception("Write Exception test"));
        }
    }
}
