using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp
{
    internal class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override string ToString()
        {
            return "First Name: "+this.firstName+" \nLast Name: "+this.lastName;
        }
    }
}
