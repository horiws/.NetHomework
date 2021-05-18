using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Order: IComparable
    {
        private int id = 0;                       //default value
        private string createTime;
        private Client client;
        private OrderDetails orderDetails;

        [Key]
        public int ID { get => id; set => id = value; }
        public Client _Client { get => client; set => client = value; }
        public OrderDetails _OrderDetails { get => orderDetails; set => orderDetails = value; }

        public Order() { }
        public Order(Client client, OrderDetails orderDetails)
        {
            this.client = client;
            this.createTime = System.DateTime.Now.ToString();
            this.orderDetails = orderDetails;
        }

        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            Console.WriteLine("Hi Equals() called!");
            return this.client.Name == order.client.Name && this.orderDetails.Equals(order.orderDetails);
        }

        public override string ToString()
        {
            return "NO." + id + " Client: " + client.Name + " " + createTime + "\n" + orderDetails.ToString();
        }

        public int CompareTo(object obj)
        {
            Order order = obj as Order;

            if (order == null) { throw new System.ArgumentException(); }

            return this.ID.CompareTo(order.ID);
        }
    }
}
