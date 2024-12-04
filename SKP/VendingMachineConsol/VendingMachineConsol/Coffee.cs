using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineConsol
{
    internal class coffee
    {

        public class Coffee : Product
        {
            public string Strength { get; set; } 

            public Coffee(string name, decimal price, string strength)
                : base(name, price)
            {
                Strength = strength;
            }

            public override string Describe()
            {
                return $"{base.Describe()}, Strength: {Strength}";
            }
        }


    }
}
