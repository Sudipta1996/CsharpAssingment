using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    abstract class Employee
    {
         public abstract string Name (string name);
        public abstract int Payment(int pay);

        public string Location()
        {
            return "Blr in office";
        }
       public class PrintOffer : Employee
        {
            public override string Name(string name)
            {
                return name;
            }

            public override int Payment(int pay)
            {
                return pay;
            }
        }
    }
}
