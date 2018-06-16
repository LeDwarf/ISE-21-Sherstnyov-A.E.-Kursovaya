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
    public partial class FormCreateOrder : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IOrderService serviceO;

        public FormCreateOrder(IOrderService serviceO)
        {
            InitializeComponent();
            this.serviceO = serviceO;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Укажите стоимость", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Укажите количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxArticle.Text))
            {
                MessageBox.Show("Укажите изделие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCustomer.Text))
            {
                MessageBox.Show("Укажите клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                serviceO.CreateOrder(new OrderBindingModel
                {
                    Customer = textBoxCustomer.Text,
                    Article = textBoxArticle.Text,
                    Count = Convert.ToInt32(textBoxCount.Text),
                    Price = Convert.ToInt32(textBoxPrice.Text)
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

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
