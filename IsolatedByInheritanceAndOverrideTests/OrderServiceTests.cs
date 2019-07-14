using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsolatedByInheritanceAndOverride.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        /// <summary>
        /// Tests the synchronize book orders 3 orders only 2 book order.
        /// ProductName, Type, Price, CustomerName
        /// 商品1,        Book,  100, Kyo
        /// 商品2,        DVD,   200, Kyo
        /// 商品3,        Book,  300, Joey
        /// </summary>
        [TestMethod()]
        public void Test_SyncBookOrders_3_Orders_Only_2_book_order()
        {
            //Try to isolate dependency to unit test
            //var target = new OrderService();
            //target.SyncBookOrders();
            //verify bookDao.Insert() twice
            //Assert.Fail();
            //最終目標，他要能跑:)
            //now:GetOrders()不work,  BookDao物件不能用(insert的方法)

            //arrange:
            //act:
            //assert:
        }
    }
}