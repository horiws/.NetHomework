using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Client
    {
        private string name;

        public string Name { get => name; set => name = value; }
        public Client(string clientName)
        {
            this.name = clientName;
        }
    }
}
