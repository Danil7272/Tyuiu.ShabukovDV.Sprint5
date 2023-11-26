using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabukovDV.Sprint5.Task4.V7.Lib;

namespace Tyuiu.ShabukovDV.Sprint5.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            {
                string path = @"C:\DataSprint5\InPutDataFileTask4V7.txt";
                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                Assert.AreEqual(true, fileExists);
            }
        }
    }
}
