namespace FurnitureFactoryView
{
    partial class FormOrders
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonOrderReady = new System.Windows.Forms.Button();
            this.buttonToWork = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(778, 300);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(820, 13);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(110, 23);
            this.buttonCreateOrder.TabIndex = 3;
            this.buttonCreateOrder.Text = "Добавить заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonOrderReady
            // 
            this.buttonOrderReady.Location = new System.Drawing.Point(820, 138);
            this.buttonOrderReady.Name = "buttonOrderReady";
            this.buttonOrderReady.Size = new System.Drawing.Size(110, 23);
            this.buttonOrderReady.TabIndex = 5;
            this.buttonOrderReady.Text = "Выполнен";
            this.buttonOrderReady.UseVisualStyleBackColor = true;
            this.buttonOrderReady.Click += new System.EventHandler(this.buttonOrderReady_Click);
            // 
            // buttonToWork
            // 
            this.buttonToWork.Location = new System.Drawing.Point(820, 74);
            this.buttonToWork.Name = "buttonToWork";
            this.buttonToWork.Size = new System.Drawing.Size(110, 23);
            this.buttonToWork.TabIndex = 6;
            this.buttonToWork.Text = "В производство";
            this.buttonToWork.UseVisualStyleBackColor = true;
            this.buttonToWork.Click += new System.EventHandler(this.buttonToWork_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(820, 290);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(110, 23);
            this.buttonRef.TabIndex = 7;
            this.buttonRef.Text = "Обновить";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 339);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonToWork);
            this.Controls.Add(this.buttonOrderReady);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormOrders";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonOrderReady;
        private System.Windows.Forms.Button buttonToWork;
        private System.Windows.Forms.Button buttonRef;
    }
}