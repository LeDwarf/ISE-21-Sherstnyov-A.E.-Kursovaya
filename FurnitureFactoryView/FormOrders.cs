using FurnitureFactoryService.Interfaces;
using FurnitureFactoryService.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using Unity.Attributes;

namespace FurnitureFactoryView
{
    public partial class FormOrders : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IOrderService service;

        public FormOrders(IOrderService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void LoadData()
        {
            try
            {
                List<OrderViewModel> list = service.GetList();
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[3].Visible = false;
                    dataGridView.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCreateOrder>();
            form.ShowDialog();
            LoadData();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonToWork_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormOrderToWork>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                form.ShowDialog();
                LoadData();
            }
        }

        private void buttonOrderReady_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                try
                {
                    service.FinishOrder(id);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
