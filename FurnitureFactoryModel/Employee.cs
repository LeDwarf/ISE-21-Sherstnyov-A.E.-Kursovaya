using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactoryModel
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string EmployeeFIO { get; set; }
        public int? Salary { get; set; }
        public int? Bonus { get; set; }
        public int? Forfeit { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual List<Order> Orders { get; set; }
    }
}
