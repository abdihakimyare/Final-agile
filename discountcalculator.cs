using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.solid
{
    public class discountcalculator
    {
        public double discountvalue;
        public List<Idiscountcalcute> _discountservice;


        public discountcalculator()
        {
            _discountservice = new List<Idiscountcalcute>();
            _discountservice.Add(new summerdiscount());
            _discountservice.Add(new winterdiscount());



        }
        public double calculatediscount(int amount, string rule)
    {
        discountvalue = _discountservice.Find(i => i.rule(rule)).calculate(amount);
        return discountvalue;
    }
    }
}
