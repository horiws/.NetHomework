using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class Cargo
    {

        private string name;
        private int quantity;
        private double price;

        [Key]
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }

        public Cargo() { }
        public Cargo(string name, int quantity, double price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public override bool Equals(Object obj)
        {
            Cargo c = obj as Cargo;
            return name == c.name;
        }

        public override string ToString()
        {
            return name + " /Price: " + price + " / Quantity: " + quantity + "\n";
        }
    }
}
