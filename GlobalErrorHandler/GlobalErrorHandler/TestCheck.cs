using NUnit.Framework;

namespace GlobalErrorHandler
{
    [TestFixture]
    public class TestCheck
    {
        #region 1st Test Case


        [Test]
        public void TestMethod1([Values(1, 2)] int x)
        {
            Assert.Pass(); 
        }

        #endregion



    }
}
