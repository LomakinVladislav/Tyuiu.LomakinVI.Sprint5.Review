using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint5.TaskReview.V17.Lib;
using System.IO;

namespace Tyuiu.LomakinVI.Sprint5.TaskReview.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistFile()
        {
            string path = @"C:\Users\OneSmiLe\source\repos\Tyuiu.LomakinVI.Sprint5.Review\Tyuiu.LomakinVI.Sprint5.TaskReview.V17\bin\Debug\OutPutDataFileTask7V17.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
