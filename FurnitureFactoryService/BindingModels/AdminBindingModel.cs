﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactoryService.BindingModels
{
    public class AdminBindingModel
    {
        public int Id { get; set; }
        public string AdminFIO { get; set; }
        public string Password { get; set; }
    }
}
