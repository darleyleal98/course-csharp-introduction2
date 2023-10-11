using System;

namespace Course.Entities
{
    public class HourContract
    {
        private DateTime Date {  get; set; }
        private double ValuePerHour { get; set; }
        private int Hours {  get; set; }

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
