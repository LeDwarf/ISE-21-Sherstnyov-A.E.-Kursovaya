﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactoryService.BindingModels
{
    public class EmployeeBindingModel
    {
        public int Id { get; set; }
        public string EmployeeFIO { get; set; }
        public int? Salary { get; set; }
        public int? Bonus { get; set; }
        public int? Forfeit { get; set; }
    }
}
