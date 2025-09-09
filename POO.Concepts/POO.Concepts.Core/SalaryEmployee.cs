using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Concepts.Core;

    public class SalaryEmployee : Employee
    {
        private const decimal MINIMUM_SALARY = 1500000;
        private decimal _salary;        //Por la validación se separa el atributo del privado
        public decimal Salary       //Propiedad pública
        {
            get => _salary;
            set => _salary = ValidateSalary(value);
        }
        public override decimal GetValueToPay() => Salary;
        public override string ToString() => $"{base.ToString()}\n\t"+
                               $"Salary.........: {GetValueToPay(),20:C2}"; //Toma el tostring de la clase padre y le agrega el getvaluetopay como el salario
    
        
    private decimal ValidateSalary(decimal salary)  //separado de la propiedad pública
        {
            if (salary < MINIMUM_SALARY)
            {
                throw new Exception($"The salary: {salary:C2}, is less than the minimum salary ({MINIMUM_SALARY:C2}).");
            }
            return salary;
        }

}