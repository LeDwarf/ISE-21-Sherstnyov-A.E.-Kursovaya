using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactoryModel
{
    public class Order
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public string Customer { get; set; }
        public int? EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime? DateDone { get; set; }
        public OrderStatus Status { get; set; }
    }
}
