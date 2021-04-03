using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class OrderDetails
    {
        private List<Cargo> cargos;
        private double amount;//total amount of an entire order
        private int kinds;          //how many kinds of cargos

        public OrderDetails(List<Cargo> cargos)
        {
            this.cargos = cargos;
            this.kinds = cargos.Count;
        }

        public List<Cargo> _Cargo { get => cargos; set => cargos = value; }

        public override bool Equals(Object obj)
        {
            OrderDetails orderDetails = obj as OrderDetails;
            if (this.kinds == orderDetails.kinds)
            {
                int temp = 0;
                
                foreach(Cargo c1 in this.cargos)
                {
                    foreach(Cargo c2 in orderDetails.cargos)
                    {
                        if (c1.Equals(c2)) { temp++; }
                    }
                }
                return temp == this.kinds;
                
            }
            else { return false; }
        }

        public override string ToString()
        {
            string s = "";
            foreach(Cargo cargo in cargos)
            {
                s += cargo.ToString();
            }
            return s;
        }

        public double GetAmount()
        {
            double sum = 0;
            foreach(Cargo c in cargos)
            {
                sum += c.Quantity * c.Price;
            }
            return sum;
        }
    }
}
