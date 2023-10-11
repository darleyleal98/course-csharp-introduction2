using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    public class HourContract
    {
        private DateTime Date {  get; set; }
        private double ValuePerHour { get; set; }
        private int Hours {  get; set; }

        public double TotalValue() { }
    }
}
