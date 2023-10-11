using Course.Entities.Enums;
using System;

namespace Course.Entities
{
    public class Worker
    {
        private string Name {  get; set; }
        private WorkerLevel Level { get; set; }
        private double BaseSalary { get; set; }

        //Composição entre as classes
        private Departament Departament { get; set; }
        //Composição -> Um trabalhador poderá ter vários contratos
        private List<HourContract> Contracts { get; set; } = new List<HourContract>();
        
        public Worker() { }
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract) 
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
