using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Order: IComparable
    {
        private int no = 0;                       //default value
        private string createTime;
        private Client client;
        private OrderDetails orderDetails;

        public int NO { get => no; set => no = value; }
        public Client _Client { get => client; set => client = value; }
        public OrderDetails _OrderDetails { get => orderDetails; set => orderDetails = value; }

        public Order(Client client, OrderDetails orderDetails)
        {
            this.client = client;
            this.createTime = System.DateTime.Now.ToString();
            this.orderDetails = orderDetails;
        }

        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return this.client == order.client && this.orderDetails.Equals(order.orderDetails);
        }

        public override string ToString()
        {
            return "NO." + no + " Client: " + client.Name + " " + createTime + "\n" + orderDetails.ToString();
        }

        public int CompareTo(object obj)
        {
            Order order = obj as Order;

            if (order == null) { throw new System.ArgumentException(); }

            return this.NO.CompareTo(order.NO);
        }
    }
}
