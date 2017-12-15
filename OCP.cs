using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.solid
{
    class OCP
    {
    }
    public interface Idiscountcalcute
    {
        bool rule(string Rulename);
        double calculate(int amount);

    }
    public class summerdiscount:Idiscountcalcute
    {
        public bool rule(string Rulename)
        {
            return "summer".Equals(Rulename);
        }
        public double calculate(int amount)
    {
        return amount * 0.15;
    }
        
    }
    public class winterdiscount : Idiscountcalcute
    {
        public bool rule(string Rulename)
        {
            return "winter".Equals(Rulename);
        }
        public double calculate(int amount)
        {
            return amount * 0.20;
        }

    }
}
