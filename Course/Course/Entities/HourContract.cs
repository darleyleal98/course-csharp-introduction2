using System;

namespace Course.Entities
{
    public class HourContract
    {
        public DateTime Date {  get; set; }
        public double ValuePerHour { get; set; }
        public int Hours {  get; set; }

        public HourContract() { }
        public HourContract(DateTime Date, double ValuePerHour, int hours)
        {
            Date = Date;
            ValuePerHour = ValuePerHour;
            Hours = hours;
        }

        public double TotalValue() 
        {
            return Hours * ValuePerHour;
        }
    }
}
