namespace Magazyn
{
    partial class DeliveryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryForm));
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.NameDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeDeliveryNameButton = new System.Windows.Forms.Button();
            this.deliveryNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.makeDeliveryButton = new System.Windows.Forms.Button();
            this.saveDeliveryButton = new System.Windows.Forms.Button();
            this.deleteDeliveryButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.totalQuantityLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.productNameGroupBox = new System.Windows.Forms.GroupBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.countProductsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.productReservationLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.actualQuantityLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.doubleClickLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.productNameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countProductsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToResizeRows = false;
            this.productDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameDGV,
            this.Code,
            this.Quantity,
            this.Price});
            this.productDataGridView.Location = new System.Drawing.Point(13, 61);
            this.productDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.productDataGridView.MultiSelect = false;
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersWidth = 20;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(374, 337);
            this.productDataGridView.TabIndex = 13;
            this.productDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGridView_CellDoubleClick);
            this.productDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ProductDataGridView_DataBindingComplete);
            // 
            // NameDGV
            // 
            this.NameDGV.DataPropertyName = "Name";
            this.NameDGV.FillWeight = 90F;
            this.NameDGV.HeaderText = "Nazwa";
            this.NameDGV.Name = "NameDGV";
            this.NameDGV.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.FillWeight = 70F;
            this.Code.HeaderText = "Kod";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "QuantityOnMove";
            this.Quantity.FillWeight = 50F;
            this.Quantity.HeaderText = "Ilość";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle1;
            this.Price.FillWeight = 60F;
            this.Price.HeaderText = "Cena";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.changeDeliveryNameButton);
            this.panel1.Controls.Add(this.deliveryNameLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(395, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 41);
            this.panel1.TabIndex = 14;
            // 
            // changeDeliveryNameButton
            // 
            this.changeDeliveryNameButton.Location = new System.Drawing.Point(242, 3);
            this.changeDeliveryNameButton.Name = "changeDeliveryNameButton";
            this.changeDeliveryNameButton.Size = new System.Drawing.Size(129, 35);
            this.changeDeliveryNameButton.TabIndex = 2;
            this.changeDeliveryNameButton.Text = "Zmień nazwę";
            this.changeDeliveryNameButton.UseVisualStyleBackColor = true;
            this.changeDeliveryNameButton.Click += new System.EventHandler(this.ChangeDeliveryNameButton_Click);
            // 
            // deliveryNameLabel
            // 
            this.deliveryNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deliveryNameLabel.AutoSize = true;
            this.deliveryNameLabel.Location = new System.Drawing.Point(86, 12);
            this.deliveryNameLabel.Name = "deliveryNameLabel";
            this.deliveryNameLabel.Size = new System.Drawing.Size(103, 17);
            this.deliveryNameLabel.TabIndex = 1;
            this.deliveryNameLabel.Text = "nazwa dostawy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dostawa:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.Controls.Add(this.doubleClickLabel);
            this.panel2.Controls.Add(this.makeDeliveryButton);
            this.panel2.Controls.Add(this.saveDeliveryButton);
            this.panel2.Controls.Add(this.deleteDeliveryButton);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.productNameGroupBox);
            this.panel2.Location = new System.Drawing.Point(395, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 337);
            this.panel2.TabIndex = 15;
            // 
            // makeDeliveryButton
            // 
            this.makeDeliveryButton.Location = new System.Drawing.Point(226, 200);
            this.makeDeliveryButton.Name = "makeDeliveryButton";
            this.makeDeliveryButton.Size = new System.Drawing.Size(147, 38);
            this.makeDeliveryButton.TabIndex = 18;
            this.makeDeliveryButton.Text = "Realizuj dostawę";
            this.makeDeliveryButton.UseVisualStyleBackColor = true;
            this.makeDeliveryButton.Click += new System.EventHandler(this.MakeDeliveryButton_Click);
            // 
            // saveDeliveryButton
            // 
            this.saveDeliveryButton.Location = new System.Drawing.Point(226, 288);
            this.saveDeliveryButton.Name = "saveDeliveryButton";
            this.saveDeliveryButton.Size = new System.Drawing.Size(147, 38);
            this.saveDeliveryButton.TabIndex = 17;
            this.saveDeliveryButton.Text = "Zapisz dostawę";
            this.saveDeliveryButton.UseVisualStyleBackColor = true;
            this.saveDeliveryButton.Click += new System.EventHandler(this.SaveDeliveryButton_Click);
            // 
            // deleteDeliveryButton
            // 
            this.deleteDeliveryButton.Location = new System.Drawing.Point(226, 244);
            this.deleteDeliveryButton.Name = "deleteDeliveryButton";
            this.deleteDeliveryButton.Size = new System.Drawing.Size(147, 38);
            this.deleteDeliveryButton.TabIndex = 16;
            this.deleteDeliveryButton.Text = "Usuń dostawę";
            this.deleteDeliveryButton.UseVisualStyleBackColor = true;
            this.deleteDeliveryButton.Click += new System.EventHandler(this.DeleteDeliveryButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.creationDateLabel);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.totalQuantityLabel);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.totalPriceLabel);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(7, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 126);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "O dostawie";
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.Location = new System.Drawing.Point(122, 98);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(54, 17);
            this.creationDateLabel.TabIndex = 5;
            this.creationDateLabel.Text = "label19";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "Data utworzania:";
            // 
            // totalQuantityLabel
            // 
            this.totalQuantityLabel.AutoSize = true;
            this.totalQuantityLabel.Location = new System.Drawing.Point(122, 65);
            this.totalQuantityLabel.Name = "totalQuantityLabel";
            this.totalQuantityLabel.Size = new System.Drawing.Size(54, 17);
            this.totalQuantityLabel.TabIndex = 3;
            this.totalQuantityLabel.Text = "label17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "Ilość produktów:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(122, 32);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(54, 17);
            this.totalPriceLabel.TabIndex = 1;
            this.totalPriceLabel.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Wartość:";
            // 
            // productNameGroupBox
            // 
            this.productNameGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.productNameGroupBox.Controls.Add(this.acceptButton);
            this.productNameGroupBox.Controls.Add(this.clearButton);
            this.productNameGroupBox.Controls.Add(this.label3);
            this.productNameGroupBox.Controls.Add(this.countProductsNumericUpDown);
            this.productNameGroupBox.Controls.Add(this.label6);
            this.productNameGroupBox.Controls.Add(this.productReservationLabel);
            this.productNameGroupBox.Controls.Add(this.label13);
            this.productNameGroupBox.Controls.Add(this.productCodeLabel);
            this.productNameGroupBox.Controls.Add(this.label8);
            this.productNameGroupBox.Controls.Add(this.productPriceLabel);
            this.productNameGroupBox.Controls.Add(this.label10);
            this.productNameGroupBox.Controls.Add(this.productNameLabel);
            this.productNameGroupBox.Controls.Add(this.actualQuantityLabel);
            this.productNameGroupBox.Controls.Add(this.label7);
            this.productNameGroupBox.Location = new System.Drawing.Point(7, 3);
            this.productNameGroupBox.Name = "productNameGroupBox";
            this.productNameGroupBox.Size = new System.Drawing.Size(366, 191);
            this.productNameGroupBox.TabIndex = 12;
            this.productNameGroupBox.TabStop = false;
            this.productNameGroupBox.Text = "Produkt";
            this.productNameGroupBox.Visible = false;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.acceptButton.Location = new System.Drawing.Point(188, 147);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(172, 38);
            this.acceptButton.TabIndex = 19;
            this.acceptButton.Text = "Zatwierdź";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearButton.Location = new System.Drawing.Point(9, 147);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(172, 38);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Wyczyść";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nazwa:";
            // 
            // countProductsNumericUpDown
            // 
            this.countProductsNumericUpDown.Location = new System.Drawing.Point(247, 89);
            this.countProductsNumericUpDown.Name = "countProductsNumericUpDown";
            this.countProductsNumericUpDown.Size = new System.Drawing.Size(113, 23);
            this.countProductsNumericUpDown.TabIndex = 11;
            this.countProductsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.label6.Size = new System.Drawing.Size(45, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cena:";
            // 
            // productReservationLabel
            // 
            this.productReservationLabel.AutoSize = true;
            this.productReservationLabel.Location = new System.Drawing.Point(111, 91);
            this.productReservationLabel.Name = "productReservationLabel";
            this.productReservationLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.productReservationLabel.Size = new System.Drawing.Size(28, 24);
            this.productReservationLabel.TabIndex = 9;
            this.productReservationLabel.Text = "     ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(244, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Zamówiona ilość:";
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(111, 43);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.productCodeLabel.Size = new System.Drawing.Size(28, 24);
            this.productCodeLabel.TabIndex = 6;
            this.productCodeLabel.Text = "     ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 67);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.label8.Size = new System.Drawing.Size(99, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Aktualna ilość:";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(111, 115);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.productPriceLabel.Size = new System.Drawing.Size(28, 24);
            this.productPriceLabel.TabIndex = 1;
            this.productPriceLabel.Text = "     ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 91);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.label10.Size = new System.Drawing.Size(85, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Rezerwacja:";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(111, 19);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.productNameLabel.Size = new System.Drawing.Size(28, 24);
            this.productNameLabel.TabIndex = 8;
            this.productNameLabel.Text = "     ";
            // 
            // actualQuantityLabel
            // 
            this.actualQuantityLabel.AutoSize = true;
            this.actualQuantityLabel.Location = new System.Drawing.Point(111, 67);
            this.actualQuantityLabel.Name = "actualQuantityLabel";
            this.actualQuantityLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.actualQuantityLabel.Size = new System.Drawing.Size(28, 24);
            this.actualQuantityLabel.TabIndex = 2;
            this.actualQuantityLabel.Text = "     ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.label7.Size = new System.Drawing.Size(37, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kod:";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(13, 13);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(179, 38);
            this.addProductButton.TabIndex = 15;
            this.addProductButton.Text = "Dodaj produkt";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(210, 13);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(179, 38);
            this.deleteProductButton.TabIndex = 14;
            this.deleteProductButton.Text = "Usuń produkt";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // doubleClickLabel
            // 
            this.doubleClickLabel.AutoSize = true;
            this.doubleClickLabel.Location = new System.Drawing.Point(30, 80);
            this.doubleClickLabel.Name = "doubleClickLabel";
            this.doubleClickLabel.Size = new System.Drawing.Size(306, 17);
            this.doubleClickLabel.TabIndex = 16;
            this.doubleClickLabel.Text = "Kliknij dwukrotnie na produkt, aby go edytować.";
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.deleteProductButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "DeliveryForm";
            this.Text = "Dostawa";
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.productNameGroupBox.ResumeLayout(false);
            this.productNameGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countProductsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changeDeliveryNameButton;
        private System.Windows.Forms.Label deliveryNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox productNameGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown countProductsNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label productReservationLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label actualQuantityLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveDeliveryButton;
        private System.Windows.Forms.Button deleteDeliveryButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button makeDeliveryButton;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label totalQuantityLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label doubleClickLabel;
    }
}