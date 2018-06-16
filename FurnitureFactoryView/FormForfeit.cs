using FurnitureFactoryService.BindingModels;
using FurnitureFactoryService.Interfaces;
using FurnitureFactoryService.ViewModels;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Attributes;

namespace FurnitureFactoryView
{
    public partial class FormForfeit : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly IEmployeeService service;

        private int? id;

        public FormForfeit(IEmployeeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void FormForfeit_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    EmployeeViewModel view = service.GetElement(id.Value);
                    if (view != null)
                    {
                        textBoxFIO.Text = view.EmployeeFIO;                        
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
            try
            {
                service.SetForfeit(new EmployeeBindingModel
                {
                    Id = id.Value,
                    EmployeeFIO = textBoxFIO.Text,
                    Forfeit = Convert.ToInt32(textBoxForfeit.Text)
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
