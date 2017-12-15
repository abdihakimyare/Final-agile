 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.solid
{
    class SRP
    {
    }
    public class calculatesalary
    {
        public double perdayrate { get; set; }
        public double numberofdays { get; set; }

        public Double calcuatesal()
        {
            return this.perdayrate * this.numberofdays;
        }



        internal object calcuatesal(double perdayrate, double numberofdays)
        {
            throw new NotImplementedException();
        }
    }
    public class printsalary
    {
        public void printslary(double salary)
        {

           this.printslary(salary);
           // Console.WriteLine("the salary is:" + salary);
        }
    }
}