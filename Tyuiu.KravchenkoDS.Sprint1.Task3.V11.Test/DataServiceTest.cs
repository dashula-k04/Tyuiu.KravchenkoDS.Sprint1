using Tyuiu.KravchenkoDS.Sprint1.Task3.V11.Lib;
{
    
}

namespace Tyuiu.KravchenkoDS.Sprint1.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = -2, y1 = 5;
            double x2= 1, y2= 7;
            double x3= 5, y3= -3;

            double res = ds.TriangleArea(x1,y1,x2,y2,x3,y3);
            double wait = 19;
            Assert.AreEqual(wait, res);

        }
    }
}
