using FurnitureFactoryModel;
using FurnitureFactoryService.BindingModels;
using FurnitureFactoryService.Interfaces;
using FurnitureFactoryService.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Data.Entity;

namespace FurnitureFactoryService.ImplementationsDB
{
    public class OrderServiceDB : IOrderService
    {
        private FurnitureFactoryDbContext context;

        public OrderServiceDB(FurnitureFactoryDbContext context)
        {
            this.context = context;
        }

        public List<OrderViewModel> GetList()
        {
            List<OrderViewModel> result = context.Orders
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    Customer = rec.Customer,
                    Article = rec.Article,
                    EmployeeId = rec.EmployeeId,
                    DateBegin = SqlFunctions.DateName("dd", rec.DateBegin) + " " +
                                SqlFunctions.DateName("mm", rec.DateBegin) + " " +
                                SqlFunctions.DateName("yyyy", rec.DateBegin),
                    DateDone = rec.DateDone == null ? "" :
                                        SqlFunctions.DateName("dd", rec.DateDone.Value) + " " +
                                        SqlFunctions.DateName("mm", rec.DateDone.Value) + " " +
                                        SqlFunctions.DateName("yyyy", rec.DateDone.Value),
                    Status = rec.Status.ToString(),
                    Count = rec.Count,
                    Price = rec.Price,
                    EmployeeFIO = rec.Employee.EmployeeFIO
                })
                .ToList();
            return result;
        }

        public void CreateOrder(OrderBindingModel model)
        {
            context.Orders.Add(new Order
            {
                Customer = model.Customer,
                Article = model.Article,
                DateBegin = DateTime.Now,
                Count = model.Count,
                Price = model.Price,
                Status = OrderStatus.Принят
            });
            context.SaveChanges();
        }

        public void TakeOrderInWork(OrderBindingModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    element.EmployeeId = model.EmployeeId;                    
                    element.Status = OrderStatus.Выполняется;
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void FinishOrder(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Order element = context.Orders.FirstOrDefault(rec => rec.Id == id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    element.DateDone = DateTime.Now;
                    element.Status = OrderStatus.Готов;
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
            
        }

        public decimal PayOrder(int id)
        {
            decimal salary = 11000; //минимальная
            List<OrderViewModel> listO = GetList();
            if (listO != null)
            {
                foreach (var order in listO)
                {
                    if (id == order.EmployeeId)
                    {
                        if (order.DateDone != null)
                        {
                            salary += order.Price / 100 * 15;
                        }
                    }
                }
            }
            return salary;
        }
    }
}
