using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Concepts.Core
{
    public abstract class Employee  //Esta clase va hacer abstracta
    {
        public int Id { get; set; } //No me interesa validar el Id solo que crando la propiedad sea privada, es suficiente
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public bool IsActive { get; set; }
        public Date BornDate { get; set; } = null!;
        public Date HireDate { get; set; } = null!;
        public abstract decimal GetValueToPay(); //Este GetValidToPlay no lo voy a e implimentear en la clase employee porque no se como le 
                                                 //voy a pagar. Significa que yo no lo tengo que implementar aquí, lo tienen que implementar 
                                                 //las clases que hereden de empleado
                                                 //**Tienes que implementar los métodos abstractos en las clases que hereden de la clase abstracta**//
        public override string ToString() =>
                $"{Id}\t{FirstName} {LastName}\n\t" +
                $"Hire date..: {HireDate}\n\t" +
                $"Salary.....: {GetValueToPay():C2}";

    }
}