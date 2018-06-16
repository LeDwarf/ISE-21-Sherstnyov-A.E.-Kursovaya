using FurnitureFactoryService.BindingModels;
using FurnitureFactoryService.Interfaces;
using FurnitureFactoryService.ViewModels;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Attributes;

namespace FurnitureFactoryView
{
    public partial class FormAdmin : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly IAdminService service;

        private int? id;

        public FormAdmin(IAdminService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    AdminViewModel view = service.GetElement(id.Value);
                    if (view != null)
                    {
                        textBoxFIO.Text = view.AdminFIO;
                        textBoxPassword.Text = view.Password;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Введите ФИО!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Введите пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (id.HasValue)
                {
                    service.UpdElement(new AdminBindingModel
                    {
                        Id = id.Value,
                        AdminFIO = textBoxFIO.Text,
                        Password = textBoxPassword.Text
                    });
                }
                else
                {
                    service.AddElement(new AdminBindingModel
                    {
                        AdminFIO = textBoxFIO.Text,
                        Password = textBoxPassword.Text
                    });
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
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
    }
}
