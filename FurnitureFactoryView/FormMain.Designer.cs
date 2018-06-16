namespace FurnitureFactoryView
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.администраторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.buttonBonus = new System.Windows.Forms.Button();
            this.buttonForfeit = new System.Windows.Forms.Button();
            this.buttonSalary = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администраторыToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.отчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // администраторыToolStripMenuItem
            // 
            this.администраторыToolStripMenuItem.Name = "администраторыToolStripMenuItem";
            this.администраторыToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.администраторыToolStripMenuItem.Text = "Администраторы";
            this.администраторыToolStripMenuItem.Click += new System.EventHandler(this.администраторыToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 38);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(586, 400);
            this.dataGridView.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(643, 38);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 26);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(643, 70);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(122, 26);
            this.buttonUpd.TabIndex = 3;
            this.buttonUpd.Text = "Изменить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(643, 102);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(122, 26);
            this.buttonDel.TabIndex = 4;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(643, 412);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(122, 26);
            this.buttonRef.TabIndex = 5;
            this.buttonRef.Text = "Обновить";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // buttonBonus
            // 
            this.buttonBonus.Location = new System.Drawing.Point(643, 284);
            this.buttonBonus.Name = "buttonBonus";
            this.buttonBonus.Size = new System.Drawing.Size(122, 26);
            this.buttonBonus.TabIndex = 6;
            this.buttonBonus.Text = "Начислить премию";
            this.buttonBonus.UseVisualStyleBackColor = true;
            this.buttonBonus.Click += new System.EventHandler(this.buttonBonus_Click);
            // 
            // buttonForfeit
            // 
            this.buttonForfeit.Location = new System.Drawing.Point(643, 316);
            this.buttonForfeit.Name = "buttonForfeit";
            this.buttonForfeit.Size = new System.Drawing.Size(122, 26);
            this.buttonForfeit.TabIndex = 7;
            this.buttonForfeit.Text = "Начислить штраф";
            this.buttonForfeit.UseVisualStyleBackColor = true;
            this.buttonForfeit.Click += new System.EventHandler(this.buttonForfeit_Click);
            // 
            // buttonSalary
            // 
            this.buttonSalary.Location = new System.Drawing.Point(631, 236);
            this.buttonSalary.Name = "buttonSalary";
            this.buttonSalary.Size = new System.Drawing.Size(143, 42);
            this.buttonSalary.TabIndex = 8;
            this.buttonSalary.Text = "Рассчитать зарплату\r\n(для всех сотрудников)";
            this.buttonSalary.UseVisualStyleBackColor = true;
            this.buttonSalary.Click += new System.EventHandler(this.buttonSalary_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalary);
            this.Controls.Add(this.buttonForfeit);
            this.Controls.Add(this.buttonBonus);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Мебельная фабрика \"Мягкое место\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_Closed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem администраторыToolStripMenuItem;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.Button buttonBonus;
        private System.Windows.Forms.Button buttonForfeit;
        private System.Windows.Forms.Button buttonSalary;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
    }
}