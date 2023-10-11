using Course.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    public class Worker
    {
        private string Name {  get; set; }
        private WorkerLevel Level { get; set; }
        private double BaseSalary { get; set; }

        public void AddContract(HourContract contract) { }
        public void RemoveContract(HourContract contract) { }
        public double Income(int year, int month) { }
    }
}
