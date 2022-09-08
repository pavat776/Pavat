using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests
{
    [TestClass()]
    public class storeTests
    {
        public void Store_NameTest()
        {
            store store = new store("MMI","", "", 0);
            Assert.AreEqual(store.Store_Name(), "MMI");
        }

        public void Store_NumberTest()
        {
            store store = new store("MMI","7124", "", 0);
            Assert.AreEqual(store.Store_Number(), "7124");
        }

        public void TestExchange()
        {
            store store = new store("", "", "", 0);

            Assert.AreEqual(store.exchange("7462.82"),[7,0,4,1,0,1,1,0,1,1]);
        }
       
    }
}