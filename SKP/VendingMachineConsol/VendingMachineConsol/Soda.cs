using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineConsol
{
    internal class soda
    {
        public class Soda : Product
        {
            public int SugarContent { get; set; } 

            public Soda(string name, decimal price, int sugarContent)
                : base(name, price)
            {
                SugarContent = sugarContent;
            }

            public override string Describe()
            {
                return $"{base.Describe()}, Sugar Content: {SugarContent}g";
            }
        }
    }
}
