using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService orderService = new OrderService();

        [ClassInitialize]
        public static void initialize(TestContext context) {
            //create the first order
            List<Cargo> cargos1 = new List<Cargo>
            {
                new Cargo("Perfume", 2, 340),
                new Cargo("Shoes", 3, 780),
                new Cargo("Lipstick", 1, 180.5)
            };
            OrderDetails orderDetails1 = new OrderDetails(cargos1);
            Order order1 = new Order(new Client("JK"), orderDetails1);
            OrderService orderService = new OrderService(order1);

            //create the second order
            List<Cargo> cargos2 = new List<Cargo>
          {
            new Cargo("Flower", 6, 5.2),
            new Cargo("Book", 2, 15.8)
          };

            OrderDetails orderDetails2 = new OrderDetails(cargos2);
            Order order2 = new Order(new Client("V"), orderDetails2);
            orderService.AddOrder(order2);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddOrderTest()
        {
            orderService.AddOrder(null);
        }

        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void AddOrderTest1()
        {
            List<Cargo> cargosTest = new List<Cargo>
            {
                new Cargo("Perfume", 2, 340),
                new Cargo("Shoes", 3, 780),
                new Cargo("Lipstick", 1, 180.5)
            };
            OrderDetails orderDetailsTest = new OrderDetails(cargosTest);
            Order orderTest = new Order(new Client("JK"), orderDetailsTest);

            orderService.AddOrder(orderTest);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DeleteOrderTest()
        {
            orderService.DeleteOrder(3);//delete the third order in orders
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ModifyOrderTest()
        {
            orderService.ModifyOrder(5, "Lipstick", 2);
        }

        [TestMethod()]
        [ExpectedException(typeof(NotFoundException))]
        public void ModifyOrderTest1()
        {
            orderService.ModifyOrder(1, "Shampoo", 5);
        }

        [TestMethod()]
        public void QueryByOrderIDTest()
        {
            int result = 0;
            Assert.AreEqual(orderService.QueryByOrderID(5).Count(), result);
        }

        [TestMethod()]
        public void QueryByCargoTest()
        {
            int result = 0;
            Assert.AreEqual(orderService.QueryByCargo("Airpods").Count(), result);
        }

        [TestMethod()]
        public void QueryByClientTest()
        {
            int result = 0;
            Assert.AreEqual(orderService.QueryByClient("SUGA").Count(), result);
        }

        [TestMethod()]
        public void QueryByAmountTest()
        {
            int result = 0;
            Assert.AreEqual(orderService.QueryByAmount(5,10).Count(), result);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ExportTest()
        {
            orderService.Export("orders.xml");
            orderService.Export("orders.xml");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExportTest1()
        {
            orderService.Export(null);
        }

        [TestMethod()]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ImportTest()
        {
            orderService.Import("order.xml");
        }


    }
}