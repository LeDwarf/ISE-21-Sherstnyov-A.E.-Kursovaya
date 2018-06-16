using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureFactoryModel;

namespace FurnitureFactoryService
{
    class DataListSingleton
    {
        private static DataListSingleton instance;

        public List<Employee> Employees { get; set; }

        public List<Admin> Admins { get; set; }

        public List<Order> Orders { get; set; }

        private DataListSingleton()
        {
            Employees = new List<Employee>();
            Admins = new List<Admin>();
            Orders = new List<Order>();
        }

        public static DataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleton();
            }

            return instance;
        }
    }
}
