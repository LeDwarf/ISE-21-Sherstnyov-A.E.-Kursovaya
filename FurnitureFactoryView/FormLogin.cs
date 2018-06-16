using FurnitureFactoryService.ImplementationsDB;
using FurnitureFactoryService.Interfaces;
using FurnitureFactoryService.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using Unity.Attributes;

namespace FurnitureFactoryView
{
    public partial class FormLogin : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IAdminService serviceA;

        public FormLogin(IAdminService serviceA)
        {
            InitializeComponent();
            this.serviceA = serviceA;
        }

        //разрешение на вход
        private bool accsessGranted = false;

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                List<AdminViewModel> listA = serviceA.GetList();
                if (listA != null)
                {
                    comboBoxAdmin.DisplayMember = "AdminFIO";
                    comboBoxAdmin.ValueMember = "Id";
                    comboBoxAdmin.DataSource = listA;
                    comboBoxAdmin.SelectedItem = null;
                }
                if (listA.Count == 0)
                {
                    //разрешение добавить админа при первом входе
                    buttonFirst.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                List<AdminViewModel> list = serviceA.GetList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Close(object sender, FormClosedEventArgs e)
        {
            if (!accsessGranted) Application.Exit();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormFirstRun>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (comboBoxAdmin.SelectedValue == null)
            {
                MessageBox.Show("Выберите учетную запись администратора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string id = comboBoxAdmin.SelectedValue.ToString();
                accsessGranted = serviceA.Login(Convert.ToInt32(id), textBoxPassword.Text);
                if (accsessGranted)
                {
                    MessageBox.Show("Авторизация прошла успешно. Добро пожаловать!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Clear();
            }
        }
    }
}
