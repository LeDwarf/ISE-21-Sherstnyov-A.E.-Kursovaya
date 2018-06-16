using FurnitureFactoryModel;
using FurnitureFactoryService.BindingModels;
using FurnitureFactoryService.Interfaces;
using FurnitureFactoryService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureFactoryService.ImplementationsDB
{
    public class EmployeeServiceDB : IEmployeeService
    {
        private FrnitureFactoryDbContext context;

        public EmployeeServiceDB(FrnitureFactoryDbContext context)
        {
            this.context = context;
        }

        public List<EmployeeViewModel> GetList()
        {
            List<EmployeeViewModel> result = context.Employees
                .Select(rec => new EmployeeViewModel
                {
                    Id = rec.Id,
                    EmployeeFIO = rec.EmployeeFIO,
                    Salary = rec.Salary,
                    Bonus = rec.Bonus,
                    Forfeit = rec.Forfeit
                })
                .ToList();
            return result;
        }

        public EmployeeViewModel GetElement(int id)
        {
            Employee element = context.Employees.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new EmployeeViewModel
                {
                    Id = element.Id,
                    EmployeeFIO = element.EmployeeFIO
                };
            }
            throw new Exception("Элемент не найден");
        }

        public void AddElement(EmployeeBindingModel model)
        {
            Employee element = context.Employees.FirstOrDefault(rec => rec.EmployeeFIO == model.EmployeeFIO);
            if (element != null)
            {
                throw new Exception("Уже есть сотрудник с таким ФИО");
            }
            context.Employees.Add(new Employee
            {
                EmployeeFIO = model.EmployeeFIO
            });
            context.SaveChanges();
        }

        public void UpdElement(EmployeeBindingModel model)
        {
            Employee element = context.Employees.FirstOrDefault(rec =>
                                        rec.EmployeeFIO == model.EmployeeFIO && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть сотрудник с таким ФИО");
            }
            element = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.EmployeeFIO = model.EmployeeFIO;
            element.Salary = model.Salary;
            element.Bonus = model.Bonus;
            element.Forfeit = model.Forfeit;
            context.SaveChanges();
        }

        public void DelElement(int id)
        {
            Employee element = context.Employees.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Employees.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public void SetBonus(EmployeeBindingModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Employee element = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    element.Bonus = model.Bonus;
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

        public void SetForfeit(EmployeeBindingModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Employee element = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    element.Forfeit = model.Forfeit;
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
    }
}
