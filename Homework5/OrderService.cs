using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Homework5
{
    [Serializable]
    public class OrderService
    {
        private List<Order> orders;

        public OrderService()
        {
            orders = new List<Order>();
        }

        public OrderService(Order order)
        {
            if (order == null)
            {
                //Console.WriteLine("Failed to add. The order is null.");
                throw new ApplicationException("Failed to add. The order is null.");
            }
            else
            {
                orders = new List<Order> { order };
                order.ID = orders.Count;
            }
        }

        public List<Order> Orders { get => orders; }

        public bool AddOrder(Order newOrder)
        {
            if (newOrder == null)
            {
                throw new ArgumentNullException("Failed to add. The order is null.");
            }
            else
            {
                foreach(Order order in orders)
                {
                    if (order.Equals(newOrder))
                    {
                        throw new ApplicationException($"The same order already exists.");
                    }
                }
                orders.Add(newOrder);
                newOrder.ID = orders.Count;
                return true;
            }
        }

        public void DeleteOrder(int orderID)
        {
            if(orderID > orders.Count())
            {
                throw new ArgumentOutOfRangeException($"There's only {orders.Count()} order(s).");
            }
            orders.Remove(orders[orderID - 1]);
            Console.WriteLine($"The NO.{orderID} order has been deleted.");
        }

        public void ModifyOrder(int orderID, string name, int newQuantity)
        {
            if (orderID > orders.Count())
            {
                throw new ArgumentOutOfRangeException($"There's only {orders.Count()} order(s).");
            }
            var cargo = from c in orders[orderID - 1]._OrderDetails._Cargo
                        where c.Name == name
                        select c;
            if (cargo.Count() < 1)
            {
                throw new NotFoundException($"The cargo {name} was not found.");
            }
            else
            {
                //how to transfer IEnumerable<Cargo> cargo into Cargo cargo
                foreach (Cargo c in cargo)
                {
                    c.Quantity = newQuantity;
                }
                Console.WriteLine($"The quantity of the {name} has been modified to {newQuantity}.");
            }
        }

        public List<Order> QueryByOrderID(int orderID)
        {
            if(orderID > orders.Count())
            {
                Console.WriteLine($"There's only {orders.Count()} order(s).");
                //throw new ArgumentOutOfRangeException($"The NO.{orderID} order does not exist.");
            }
            var order = orders.Where(o => o.ID == orderID).OrderBy(o => o._OrderDetails.GetAmount());
            return order.ToList();
        }

        public List<Order> QueryByCargo(string cargoName)
        {
            var order = orders.Where(o => o._OrderDetails._Cargo.Any(c => c.Name == cargoName));
            if (order.ToList().Count() <= 0)
            {
                Console.WriteLine($"The cargo {cargoName} does not exist.");
            }
            return order.ToList();
        }

        public List<Order> QueryByClient(string clientName)
        {
            var order = orders.Where(o => o._Client.Name == clientName);
            if (order.ToList().Count() <= 0)
            {
                Console.WriteLine($"The order placed by {clientName} does not exist.");
            }
            return order.ToList();
        }

        public List<Order> QueryByAmount(double lowerLimit, double upperLimit)
        {
            var order = orders.Where(o => o._OrderDetails.GetAmount()>=lowerLimit &&
                o._OrderDetails.GetAmount() <= upperLimit). 
                OrderBy(o => o._OrderDetails.GetAmount());
            if (order.ToList().Count() <= 0)
            {
                Console.WriteLine($"The order whose amount between {lowerLimit} ~ {upperLimit} does not exist.");
            }
            return order.ToList();
        }

        //homework6
        public void Export(string path)
        {
            string fullPath = @"D:\whu\sophomore2\C#\source\Homework5\Homework5\bin\Debug\" + path;
            if (File.Exists(fullPath))
            {
                throw new ArgumentException($"The file {path} already exists.");
            }else if(path == null)
            {
                throw new ArgumentNullException("The file is null.");
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using(FileStream fs = new FileStream(path, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
            Console.WriteLine(File.ReadAllText(path));
        }

        public void Import(string path)
        {
            string fullPath = @"D:\whu\sophomore2\C#\source\Homework5\Homework5\bin\Debug\" + path;
            Console.WriteLine(fullPath);
            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException($"The path {path} does not exist.");
            }else if(path == null)
            {
                throw new ArgumentNullException("The file is null.");
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> ordersDes = (List<Order>)xmlSerializer.Deserialize(fs);
                foreach(Order order in ordersDes)
                {
                    Console.WriteLine(order);
                }
            }
        }
    }

    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message) { }
    }

    
}
