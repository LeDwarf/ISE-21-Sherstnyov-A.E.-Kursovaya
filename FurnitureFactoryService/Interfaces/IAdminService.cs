using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureFactoryService.BindingModels;
using FurnitureFactoryService.ViewModels;

namespace FurnitureFactoryService.Interfaces
{
    public interface IAdminService
    {
        List<AdminViewModel> GetList();

        AdminViewModel GetElement(int id);

        void AddElement(AdminBindingModel model);

        void UpdElement(AdminBindingModel model);

        void DelElement(int id);

        bool Login(int id, string password);

    }
}
