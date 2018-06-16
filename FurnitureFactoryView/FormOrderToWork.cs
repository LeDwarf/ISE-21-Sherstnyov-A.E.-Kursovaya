using FurnitureFactoryService.BindingModels;
using FurnitureFactoryService.Interfaces;
using FurnitureFactoryService.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using Unity.Attributes;

namespace FurnitureFactoryView
{
    public partial class FormOrderToWork : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly IEmployeeService serviceE;

        private readonly IOrderService serviceO;

        private int? id;

        public FormOrderToWork(IEmployeeService serviceE, IOrderService serviceO)
        {
            InitializeComponent();
            this.serviceE = serviceE;
            this.serviceO = serviceO;
        }

        private void FormTakeContractInWork_Load(object sender, EventArgs e)
        {
            try
            {
                if (!id.HasValue)
                {
                    MessageBox.Show("Не указан заказ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                List<EmployeeViewModel> listI = serviceE.GetList();
                if (listI != null)
                {
                    comboBoxEmployee.DisplayMember = "EmployeeFIO";
                    comboBoxEmployee.ValueMember = "Id";
                    comboBoxEmployee.DataSource = listI;
                    comboBoxEmployee.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployee.SelectedValue == null)
            {
                MessageBox.Show("Выберите исполнителя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                serviceO.TakeOrderInWork(new OrderBindingModel
                {
                    Id = id.Value,
                    EmployeeId = Convert.ToInt32(comboBoxEmployee.SelectedValue)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
