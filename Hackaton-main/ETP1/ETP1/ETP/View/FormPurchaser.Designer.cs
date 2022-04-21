namespace ETP
{
    partial class FormPurchaser
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.labelAvaibleOrders = new System.Windows.Forms.Label();
            this.buttonToOrder = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.buttonUpdateOrder = new System.Windows.Forms.Button();
            this.numericUpDownProductCount = new System.Windows.Forms.NumericUpDown();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.labelProductCount = new System.Windows.Forms.Label();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(154, 30);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(634, 368);
            this.dataGridViewOrders.TabIndex = 13;
            this.dataGridViewOrders.Visible = false;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelAvaibleOrders
            // 
            this.labelAvaibleOrders.AutoSize = true;
            this.labelAvaibleOrders.Location = new System.Drawing.Point(154, 14);
            this.labelAvaibleOrders.Name = "labelAvaibleOrders";
            this.labelAvaibleOrders.Size = new System.Drawing.Size(105, 13);
            this.labelAvaibleOrders.TabIndex = 12;
            this.labelAvaibleOrders.Text = "Созданные заказы";
            this.labelAvaibleOrders.Visible = false;
            // 
            // buttonToOrder
            // 
            this.buttonToOrder.Location = new System.Drawing.Point(12, 134);
            this.buttonToOrder.Name = "buttonToOrder";
            this.buttonToOrder.Size = new System.Drawing.Size(100, 23);
            this.buttonToOrder.TabIndex = 14;
            this.buttonToOrder.Text = "Заказать";
            this.buttonToOrder.UseVisualStyleBackColor = true;
            this.buttonToOrder.Visible = false;
            this.buttonToOrder.Click += new System.EventHandler(this.buttonToOrder_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(10, 221);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(102, 39);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(12, 192);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteOrder.TabIndex = 38;
            this.buttonDeleteOrder.Text = "Удалить заказ";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Visible = false;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // buttonUpdateOrder
            // 
            this.buttonUpdateOrder.Location = new System.Drawing.Point(12, 163);
            this.buttonUpdateOrder.Name = "buttonUpdateOrder";
            this.buttonUpdateOrder.Size = new System.Drawing.Size(100, 23);
            this.buttonUpdateOrder.TabIndex = 37;
            this.buttonUpdateOrder.Text = "Обновить заказ";
            this.buttonUpdateOrder.UseVisualStyleBackColor = true;
            this.buttonUpdateOrder.Visible = false;
            this.buttonUpdateOrder.Click += new System.EventHandler(this.buttonUpdateOrder_Click);
            // 
            // numericUpDownProductCount
            // 
            this.numericUpDownProductCount.Location = new System.Drawing.Point(12, 69);
            this.numericUpDownProductCount.Name = "numericUpDownProductCount";
            this.numericUpDownProductCount.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownProductCount.TabIndex = 35;
            this.numericUpDownProductCount.Visible = false;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(12, 108);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductPrice.TabIndex = 34;
            this.textBoxProductPrice.Visible = false;
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Location = new System.Drawing.Point(9, 92);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(33, 13);
            this.labelProductPrice.TabIndex = 33;
            this.labelProductPrice.Text = "Цена";
            this.labelProductPrice.Visible = false;
            // 
            // labelProductCount
            // 
            this.labelProductCount.AutoSize = true;
            this.labelProductCount.Location = new System.Drawing.Point(9, 53);
            this.labelProductCount.Name = "labelProductCount";
            this.labelProductCount.Size = new System.Drawing.Size(90, 13);
            this.labelProductCount.TabIndex = 32;
            this.labelProductCount.Text = "Кол-во продукта";
            this.labelProductCount.Visible = false;
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.Location = new System.Drawing.Point(12, 30);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(100, 20);
            this.textBoxProduct.TabIndex = 31;
            this.textBoxProduct.Visible = false;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(9, 13);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(49, 13);
            this.labelProduct.TabIndex = 30;
            this.labelProduct.Text = "Продукт";
            this.labelProduct.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Доступные заказы ";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(10, 365);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(102, 38);
            this.buttonSignUp.TabIndex = 39;
            this.buttonSignUp.Text = "Регистрация";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(10, 321);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(102, 38);
            this.buttonSignIn.TabIndex = 39;
            this.buttonSignIn.Text = "Вход";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(12, 30);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(102, 36);
            this.buttonSell.TabIndex = 40;
            this.buttonSell.Text = "Продать";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Visible = false;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // FormPurchaser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonDeleteOrder);
            this.Controls.Add(this.buttonUpdateOrder);
            this.Controls.Add(this.numericUpDownProductCount);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.labelProductPrice);
            this.Controls.Add(this.labelProductCount);
            this.Controls.Add(this.textBoxProduct);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonToOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.labelAvaibleOrders);
            this.Name = "FormPurchaser";
            this.Text = "FormPurchaser";
            this.Load += new System.EventHandler(this.FormPurchaser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label labelAvaibleOrders;
        private System.Windows.Forms.Button buttonToOrder;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonUpdateOrder;
        private System.Windows.Forms.NumericUpDown numericUpDownProductCount;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Label labelProductCount;
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonSell;
    }
}