using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactoryService.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public string Customer { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeFIO { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public string DateBegin { get; set; }
        public string DateDone { get; set; }
        public string Status { get; set; }
    }
}
