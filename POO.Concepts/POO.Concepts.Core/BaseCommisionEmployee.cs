using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Concepts.Core;

public class BaseCommisionEmployee : CommisionEmployee
{
    private decimal _salary;        //Por la validación se separa el atributo del privado
    public decimal Salary       //Propiedad pública
    {
        get => _salary;
        set => _salary = ValidateSalary(value);
    }
    public override decimal GetValueToPay() => base.GetValueToPay() + Salary;
    private decimal ValidateSalary(decimal salary)  //separado de la propiedad pública
    {
        if (salary < 300000)
        {
            throw new Exception($"The base: {salary:C2}, is less than the minimum salary ({300000:C2}).");
        }
        return salary;
    }
}
