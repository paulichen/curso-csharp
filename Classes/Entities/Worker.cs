using System.Collections.Generic;
using Classes.Entities.Enums;

namespace Classes.Entities {
    class Worker {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contrato) {
            Contracts.Add(contrato);
        }

        public void RemoveContract(HourContract contrato) {
            Contracts.Remove(contrato);
        }

        public double Income(int year, int month) {
            double sum = BaseSalary;

            foreach(HourContract c in Contracts) {
                if(c.Date.Year == year && c.Date.Month == month) {
                    sum += c.TotalValue();
                }
            }

            return sum;
        }
    }
}
