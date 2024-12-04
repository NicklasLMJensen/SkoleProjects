using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineConsol
{
    internal class snack
    {
        public class Snack : Product
        {
            public double Weight { get; set; }

            public Snack(string name, decimal price,  double weight) 
                : base(name, price)
            {
                Weight = weight;
            }

            public override string Describe()
            {
                return $"{base.Describe()}, Weight: {Weight}g";
            }


        }
    }
}
