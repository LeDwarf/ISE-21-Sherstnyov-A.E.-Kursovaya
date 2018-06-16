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
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IEmployeeService serviceE;
        private readonly IOrderService serviceO;

        public FormMain(IEmployeeService serviceE, IOrderService serviceO)
        {
            InitializeComponent();
            this.serviceE = serviceE;
            this.serviceO = serviceO;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormLogin>();
            form.ShowDialog();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<EmployeeViewModel> list = serviceE.GetList();
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void администраторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAdmins>();
            form.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormEmployee>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormEmployee>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        serviceE.DelElement(id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormOrders>();
            form.ShowDialog();
        }

        private void buttonBonus_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormBonus>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonForfeit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormForfeit>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void FormMain_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSalary_Click(object sender, EventArgs e)
        {
            try
            {
                List<EmployeeViewModel> listS = serviceE.GetList();
                if (listS != null)
                {
                    foreach (var elem in listS)
                    {
                        int salaryI = Decimal.ToInt32(serviceO.PayOrder(elem.Id));
                        serviceE.SetSalary(new EmployeeBindingModel
                        {
                            Id = elem.Id,                          
                            Salary = salaryI
                        });                       
                    }
                }
                MessageBox.Show("Расчет зарплаты произведен успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReport>();
            form.ShowDialog();
        }
    }
}
