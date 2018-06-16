using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureFactoryService.BindingModels;
using FurnitureFactoryService.ViewModels;

namespace FurnitureFactoryService.Interfaces
{
    public interface IEmployeeService
    {
        List<EmployeeViewModel> GetList();

        EmployeeViewModel GetElement(int id);

        void AddElement(EmployeeBindingModel model);

        void UpdElement(EmployeeBindingModel model);

        void DelElement(int id);

        void SetSalary(EmployeeBindingModel model);

        void SetBonus(EmployeeBindingModel model);

        void SetForfeit(EmployeeBindingModel model);        

    }
}
