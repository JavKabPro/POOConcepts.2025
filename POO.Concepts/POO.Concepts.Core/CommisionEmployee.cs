using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Concepts.Core;

public class CommisionEmployee : Employee
{
    private float _commissionPercentaje;
    private decimal _sales;

    public float CommissionPercentaje
    {
        get => _commissionPercentaje;
        set => _commissionPercentaje = ValidateCommissionPercentaje(value);
    }
    public decimal Sales
    {
        get => _sales;
        set => _sales = ValidateSales(value);
    }

    public override decimal GetValueToPay() => Sales * (decimal)CommissionPercentaje;

    public override string ToString() => $"{base.ToString()}\n\t" +
                               $"Comission %....: {CommissionPercentaje,20:P2}\n\t" +
                               $"Sales..........: {Sales,20:C2}\n\t" +
                               $"Salary.........: {GetValueToPay(),20:C2}";

    private decimal ValidateSales(decimal sales)  //separado de la propiedad pública
    {
        if (sales < 0)
        {
            throw new Exception($"The sales: {sales:C2}, is less or equals than zero.");
        }
        return sales;
    }
    private float ValidateCommissionPercentaje(float commissionPercentaje)  //separado de la propiedad pública
    {
        if (commissionPercentaje < 0 || commissionPercentaje > 100)
        {
            throw new Exception($"The commission Percentaje: {commissionPercentaje:P2}, is invalid.");
        }
        return commissionPercentaje;
    }

}