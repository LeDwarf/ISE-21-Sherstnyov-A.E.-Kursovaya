namespace FurnitureFactoryView
{
    partial class FormCreateOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCansel = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Изделие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заказчик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Стоимость";
            // 
            // textBoxArticle
            // 
            this.textBoxArticle.Location = new System.Drawing.Point(103, 13);
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.Size = new System.Drawing.Size(153, 20);
            this.textBoxArticle.TabIndex = 9;
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(103, 45);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(153, 20);
            this.textBoxCustomer.TabIndex = 10;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(103, 76);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(153, 20);
            this.textBoxCount.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(22, 151);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Готово";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCansel
            // 
            this.buttonCansel.Location = new System.Drawing.Point(180, 150);
            this.buttonCansel.Name = "buttonCansel";
            this.buttonCansel.Size = new System.Drawing.Size(75, 23);
            this.buttonCansel.TabIndex = 13;
            this.buttonCansel.Text = "Отмена";
            this.buttonCansel.UseVisualStyleBackColor = true;
            this.buttonCansel.Click += new System.EventHandler(this.buttonCansel_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(103, 105);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(153, 20);
            this.textBoxPrice.TabIndex = 14;
            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 228);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonCansel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.textBoxArticle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateOrder";
            this.Text = "Заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCansel;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}