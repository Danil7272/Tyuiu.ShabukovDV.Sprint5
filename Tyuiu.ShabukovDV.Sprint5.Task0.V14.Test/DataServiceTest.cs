using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabukovDV.Sprint5.Task0.V14.Lib;

namespace Tyuiu.ShabukovDV.Sprint5.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            FileInfo fileI = new FileInfo(path);
            bool fileE = fileI.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileE);
        }
    }
}
