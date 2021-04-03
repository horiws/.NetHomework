using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class OrderService
    {
        private List<Order> orders;

        public OrderService()
        {
            orders = new List<Order>();
        }

        public List<Order> Orders { get => orders; }

        public bool AddOrder(Order newOrder)
        {
            foreach(Order order in orders)
            {
                if (newOrder.Equals(order)) { return false; }
            }

            orders.Add(newOrder);
            newOrder.NO = orders.Count;

            return true;
        }

        public void DeleteOrder(int orderNo)
        {
            try
            {
                orders.Remove(orders[orderNo]);
                Console.WriteLine($"The NO.{orderNo} order has been deleted.");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Exception caught: {e}");
            }
        }

        public void ModifyOrder(int orderNo, string name, int newQuantity)
        {
            try
            {
                var cargo = from c in orders[orderNo-1]._OrderDetails._Cargo
                            where c.Name == name
                            select c;
               
                if (cargo == null)
                {
                    new NotFoundException($"The cargo {name} was not found.");
                }
                else
                {
                    //how to transfer IEnumerable<Cargo> cargo to Cargo cargo
                    /*Cargo cargo1 = cargo as Cargo;

                    cargo1.Quantity = newQuantity;*/
                    foreach(Cargo c in cargo)
                    {
                        c.Quantity = newQuantity;
                    }
                    Console.WriteLine($"The quantity of the {name} has been modified.");
                }
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Exception caught: {e}");
            }
        }

        public List<Order> Search(int orderNo)
        {
            var order = orders.Where(o => o.NO == orderNo).OrderBy(o => o._OrderDetails.GetAmount());
            return (List<Order>)order;
        }

        //Through the parameter 'searchItem' to decide whether to search the client's name or the cargo's name
        public List<Order> Search(string searchItem, string name)
        {
            switch (searchItem)
            {
                case "client":
                    var order = orders.Where(o => o._Client.Name == name).
                           OrderBy(o => o._OrderDetails.GetAmount());
                    return (List<Order>)order;

                case "cargo":
                    List<Order> orderList = null;
                    foreach (Order o in orders)
                    {
                        var cargo = o._OrderDetails._Cargo.Where(c => c.Name == name);
                        if (cargo != null)
                        {
                            orderList.Add(o);
                        }
                    }
                    orderList.OrderBy(o => o._OrderDetails.GetAmount());
                    return orderList;

                default:
                    return null;
            }
        }

        public List<Order> Search(double amount)
        {
            var order = orders.Where(o => o._OrderDetails.GetAmount()==amount).
                OrderBy(o => o._OrderDetails.GetAmount());
            return (List<Order>)order;
        }

        /*public List<Order> Search(string cargoName)
        {
            List<Order> orderList = null;
            foreach(Order order in orders)
            {
                var cargo = order._OrderDetails._Cargo.Where(c => c.Name == cargoName);
                if(cargo != null)
                {
                    orderList.Add(order);
                }
            }
            return orderList;
        }*/
    }

    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message) { }
    }
}
