using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the first order
            List<Cargo> cargos1 = new List<Cargo>();

            cargos1.Add(new Cargo("Perfume", 2, 340));
            cargos1.Add(new Cargo("Shoes", 3, 780));
            cargos1.Add(new Cargo("Lipstick", 1, 180.5));

            OrderDetails orderDetails1 = new OrderDetails(cargos1);
            Order order1 = new Order(new Client("JK"), orderDetails1);

            //create the second order
            List<Cargo> cargos2 = new List<Cargo>();
            cargos2.Add(new Cargo("Flower", 6, 5.2));
            cargos2.Add(new Cargo("Book", 2, 15.8));

            OrderDetails orderDetails2 = new OrderDetails(cargos2);
            Order order2 = new Order(new Client("V"), orderDetails2);

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);

            Console.WriteLine(order1);
            Console.WriteLine(order2);
            orderService.Orders.Sort();

            orderService.ModifyOrder(1, "Lipstick", 10);
            orderService.ModifyOrder(1, "Flower", 5);

            
            Console.Read();
        }
    }
}
