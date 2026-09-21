using Tyuiu.KravchenkoDS.Sprint1.Task6.V11.Lib;

namespace Tyuiu.KravchenkoDS.Sprint1.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckeFirstLetterRepetition()
        {
           DataService ds = new DataService();
            string strTest = "арка";
            bool res = ds.CheckeFirstLetterRepetition( strTest );
            Assert.AreEqual( true, res );

        }
    }
}
