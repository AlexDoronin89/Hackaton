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
            this.labelPuchaserName = new System.Windows.Forms.Label();
            this.textBoxPurchaserName = new System.Windows.Forms.TextBox();
            this.labelPurchaserSecondName = new System.Windows.Forms.Label();
            this.textBoxPurchaserSecondName = new System.Windows.Forms.TextBox();
            this.labelPurchaserThirdName = new System.Windows.Forms.Label();
            this.textBoxPurchaserThirdName = new System.Windows.Forms.TextBox();
            this.labelPurchaserMail = new System.Windows.Forms.Label();
            this.textBoxPurchaserMail = new System.Windows.Forms.TextBox();
            this.labelPurchaserNumber = new System.Windows.Forms.Label();
            this.textBoxPurchaserNumber = new System.Windows.Forms.TextBox();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.labelAvaibleOrders = new System.Windows.Forms.Label();
            this.buttonToOrder = new System.Windows.Forms.Button();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPuchaserName
            // 
            this.labelPuchaserName.AutoSize = true;
            this.labelPuchaserName.Location = new System.Drawing.Point(35, 13);
            this.labelPuchaserName.Name = "labelPuchaserName";
            this.labelPuchaserName.Size = new System.Drawing.Size(29, 13);
            this.labelPuchaserName.TabIndex = 0;
            this.labelPuchaserName.Text = "Имя";
            // 
            // textBoxPurchaserName
            // 
            this.textBoxPurchaserName.Location = new System.Drawing.Point(12, 29);
            this.textBoxPurchaserName.Name = "textBoxPurchaserName";
            this.textBoxPurchaserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPurchaserName.TabIndex = 1;
            // 
            // labelPurchaserSecondName
            // 
            this.labelPurchaserSecondName.AutoSize = true;
            this.labelPurchaserSecondName.Location = new System.Drawing.Point(35, 52);
            this.labelPurchaserSecondName.Name = "labelPurchaserSecondName";
            this.labelPurchaserSecondName.Size = new System.Drawing.Size(56, 13);
            this.labelPurchaserSecondName.TabIndex = 2;
            this.labelPurchaserSecondName.Text = "Фамилия";
            // 
            // textBoxPurchaserSecondName
            // 
            this.textBoxPurchaserSecondName.Location = new System.Drawing.Point(12, 68);
            this.textBoxPurchaserSecondName.Name = "textBoxPurchaserSecondName";
            this.textBoxPurchaserSecondName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPurchaserSecondName.TabIndex = 3;
            // 
            // labelPurchaserThirdName
            // 
            this.labelPurchaserThirdName.AutoSize = true;
            this.labelPurchaserThirdName.Location = new System.Drawing.Point(35, 91);
            this.labelPurchaserThirdName.Name = "labelPurchaserThirdName";
            this.labelPurchaserThirdName.Size = new System.Drawing.Size(54, 13);
            this.labelPurchaserThirdName.TabIndex = 4;
            this.labelPurchaserThirdName.Text = "Отчество";
            // 
            // textBoxPurchaserThirdName
            // 
            this.textBoxPurchaserThirdName.Location = new System.Drawing.Point(12, 107);
            this.textBoxPurchaserThirdName.Name = "textBoxPurchaserThirdName";
            this.textBoxPurchaserThirdName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPurchaserThirdName.TabIndex = 5;
            // 
            // labelPurchaserMail
            // 
            this.labelPurchaserMail.AutoSize = true;
            this.labelPurchaserMail.Location = new System.Drawing.Point(35, 130);
            this.labelPurchaserMail.Name = "labelPurchaserMail";
            this.labelPurchaserMail.Size = new System.Drawing.Size(37, 13);
            this.labelPurchaserMail.TabIndex = 6;
            this.labelPurchaserMail.Text = "Почта";
            // 
            // textBoxPurchaserMail
            // 
            this.textBoxPurchaserMail.Location = new System.Drawing.Point(12, 146);
            this.textBoxPurchaserMail.Name = "textBoxPurchaserMail";
            this.textBoxPurchaserMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxPurchaserMail.TabIndex = 7;
            // 
            // labelPurchaserNumber
            // 
            this.labelPurchaserNumber.AutoSize = true;
            this.labelPurchaserNumber.Location = new System.Drawing.Point(12, 169);
            this.labelPurchaserNumber.Name = "labelPurchaserNumber";
            this.labelPurchaserNumber.Size = new System.Drawing.Size(93, 13);
            this.labelPurchaserNumber.TabIndex = 8;
            this.labelPurchaserNumber.Text = "Номер телефона";
            // 
            // textBoxPurchaserNumber
            // 
            this.textBoxPurchaserNumber.Location = new System.Drawing.Point(15, 195);
            this.textBoxPurchaserNumber.Name = "textBoxPurchaserNumber";
            this.textBoxPurchaserNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPurchaserNumber.TabIndex = 9;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(252, 242);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(536, 186);
            this.dataGridViewOrders.TabIndex = 13;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelAvaibleOrders
            // 
            this.labelAvaibleOrders.AutoSize = true;
            this.labelAvaibleOrders.Location = new System.Drawing.Point(249, 226);
            this.labelAvaibleOrders.Name = "labelAvaibleOrders";
            this.labelAvaibleOrders.Size = new System.Drawing.Size(108, 13);
            this.labelAvaibleOrders.TabIndex = 12;
            this.labelAvaibleOrders.Text = "Доступные заказы ";
            // 
            // buttonToOrder
            // 
            this.buttonToOrder.Location = new System.Drawing.Point(15, 226);
            this.buttonToOrder.Name = "buttonToOrder";
            this.buttonToOrder.Size = new System.Drawing.Size(103, 37);
            this.buttonToOrder.TabIndex = 14;
            this.buttonToOrder.Text = "Заказать";
            this.buttonToOrder.UseVisualStyleBackColor = true;
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.Location = new System.Drawing.Point(15, 269);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(103, 37);
            this.buttonCancelOrder.TabIndex = 15;
            this.buttonCancelOrder.Text = "Отменить";
            this.buttonCancelOrder.UseVisualStyleBackColor = true;
            // 
            // FormPurchaser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelOrder);
            this.Controls.Add(this.buttonToOrder);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.labelAvaibleOrders);
            this.Controls.Add(this.textBoxPurchaserNumber);
            this.Controls.Add(this.labelPurchaserNumber);
            this.Controls.Add(this.textBoxPurchaserMail);
            this.Controls.Add(this.labelPurchaserMail);
            this.Controls.Add(this.textBoxPurchaserThirdName);
            this.Controls.Add(this.labelPurchaserThirdName);
            this.Controls.Add(this.textBoxPurchaserSecondName);
            this.Controls.Add(this.labelPurchaserSecondName);
            this.Controls.Add(this.textBoxPurchaserName);
            this.Controls.Add(this.labelPuchaserName);
            this.Name = "FormPurchaser";
            this.Text = "FormPurchaser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPuchaserName;
        private System.Windows.Forms.TextBox textBoxPurchaserName;
        private System.Windows.Forms.Label labelPurchaserSecondName;
        private System.Windows.Forms.TextBox textBoxPurchaserSecondName;
        private System.Windows.Forms.Label labelPurchaserThirdName;
        private System.Windows.Forms.TextBox textBoxPurchaserThirdName;
        private System.Windows.Forms.Label labelPurchaserMail;
        private System.Windows.Forms.TextBox textBoxPurchaserMail;
        private System.Windows.Forms.Label labelPurchaserNumber;
        private System.Windows.Forms.TextBox textBoxPurchaserNumber;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label labelAvaibleOrders;
        private System.Windows.Forms.Button buttonToOrder;
        private System.Windows.Forms.Button buttonCancelOrder;
    }
}