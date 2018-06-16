using FurnitureFactoryService;
using FurnitureFactoryService.ImplementationsDB;
using FurnitureFactoryService.Interfaces;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace FurnitureFactoryView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<DbContext, FurnitureFactoryDbContext>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IAdminService, AdminServiceDB>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IEmployeeService, EmployeeServiceDB>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderService, OrderServiceDB>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IReportService, ReportServiceDB>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}
