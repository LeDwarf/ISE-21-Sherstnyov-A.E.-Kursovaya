using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureFactoryService.BindingModels;
using FurnitureFactoryService.ViewModels;

namespace FurnitureFactoryService.Interfaces
{
    public interface IOrderService
    {
        List<OrderViewModel> GetList();

        void CreateOrder(OrderBindingModel model);

        void TakeOrderInWork(OrderBindingModel model);

        void FinishOrder(int id);

        decimal PayOrder(int id);
    }
}
