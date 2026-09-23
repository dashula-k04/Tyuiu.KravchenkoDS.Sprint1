using Tyuiu.KravchenkoDS.Sprint1.Task7.V12.Lib;

namespace Tyuiu.KravchenkoDS.Sprint1.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 333.000;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
                

        }
    }
}
