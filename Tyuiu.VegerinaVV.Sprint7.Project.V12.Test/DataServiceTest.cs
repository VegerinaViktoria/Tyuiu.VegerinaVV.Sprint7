using System.IO;
using Tyuiu.VegerinaVV.Sprint7.Project.V12.Lib;
namespace Tyuiu.VegerinaVV.Sprint7.Project.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\vvvik\source\repos\Tyuiu.VegerinaVV.Sprint7\Tyuiu.VegerinaVV.Sprint7.Project.V12\PersonalComputer.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void CheckedExistsFirmsFile()
        {
            string path = @"C:\Users\vvvik\source\repos\Tyuiu.VegerinaVV.Sprint7\Tyuiu.VegerinaVV.Sprint7.Project.V12\Firms.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void CheckedMinValue()
        {
            DataService ds = new DataService();
            int[] minValueTest = { 4, 3, 7, 1, 8 };
            double wait = 1;
            double res = ds.MinValue(minValueTest);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckedMaxValue()
        {
            DataService ds = new DataService();
            int[] maxValueTest = { 3, 8, 5, 4, 10 };
            double wait = 10;
            double res = ds.MaxValue(maxValueTest);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckedAverageValue()
        {
            DataService ds = new DataService();
            int[] averageValueTest = { 2, 5, 6, 9, 12 };
            double wait = 6.8;
            double res = ds.AverageValue(averageValueTest);
            Assert.AreEqual(wait, res);
        }
    }
}
