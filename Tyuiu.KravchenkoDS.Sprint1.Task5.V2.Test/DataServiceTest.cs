using Tyuiu.KravchenkoDS.Sprint1.Task5.V2.Lib;

namespace Tyuiu.KravchenkoDS.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 72;
            DataService ds = new DataService();
            double res = ds.FahrenheitToСelsius(x);
            int result = Convert.ToInt32(res);
            int wait = 22;
            Assert.AreEqual(result, wait);

        }
    }
}
