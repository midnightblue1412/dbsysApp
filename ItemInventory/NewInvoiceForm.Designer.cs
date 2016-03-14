namespace ItemInventory
{
    partial class NewInvoiceForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.disp_grid = new System.Windows.Forms.DataGridView();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_clientName = new System.Windows.Forms.ComboBox();
            this.input_date = new System.Windows.Forms.DateTimePicker();
            this.input_itemName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.input_qty = new System.Windows.Forms.NumericUpDown();
            this.btn_add = new System.Windows.Forms.Button();
            this.input_invoiceNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.disp_total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_qty)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Client:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Invoice No:";
            // 
            // disp_grid
            // 
            this.disp_grid.AllowUserToAddRows = false;
            this.disp_grid.AllowUserToResizeColumns = false;
            this.disp_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disp_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disp_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemId,
            this.itemName,
            this.unitPrice,
            this.quantity,
            this.subtotal});
            this.disp_grid.Location = new System.Drawing.Point(12, 216);
            this.disp_grid.Name = "disp_grid";
            this.disp_grid.ReadOnly = true;
            this.disp_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.disp_grid.Size = new System.Drawing.Size(581, 215);
            this.disp_grid.TabIndex = 13;
            this.disp_grid.TabStop = false;
            this.disp_grid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.disp_grid_UserDeletingRow);
            // 
            // itemId
            // 
            this.itemId.HeaderText = "Item ID";
            this.itemId.Name = "itemId";
            this.itemId.ReadOnly = true;
            this.itemId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemId.Width = 75;
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.HeaderText = "Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Qty";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 50;
            // 
            // subtotal
            // 
            this.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // input_clientName
            // 
            this.input_clientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_clientName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_clientName.FormattingEnabled = true;
            this.input_clientName.Location = new System.Drawing.Point(98, 94);
            this.input_clientName.Name = "input_clientName";
            this.input_clientName.Size = new System.Drawing.Size(121, 25);
            this.input_clientName.TabIndex = 1;
            this.input_clientName.TextChanged += new System.EventHandler(this.input_clientName_TextChanged);
            // 
            // input_date
            // 
            this.input_date.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_date.Location = new System.Drawing.Point(98, 125);
            this.input_date.Name = "input_date";
            this.input_date.Size = new System.Drawing.Size(121, 25);
            this.input_date.TabIndex = 2;
            this.input_date.Value = new System.DateTime(2016, 3, 10, 19, 53, 13, 573);
            // 
            // input_itemName
            // 
            this.input_itemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_itemName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_itemName.FormattingEnabled = true;
            this.input_itemName.Location = new System.Drawing.Point(59, 183);
            this.input_itemName.Name = "input_itemName";
            this.input_itemName.Size = new System.Drawing.Size(121, 25);
            this.input_itemName.TabIndex = 3;
            this.input_itemName.TextChanged += new System.EventHandler(this.input_itemName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Item:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(191, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Qty:";
            // 
            // input_qty
            // 
            this.input_qty.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_qty.Location = new System.Drawing.Point(228, 186);
            this.input_qty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.input_qty.Name = "input_qty";
            this.input_qty.Size = new System.Drawing.Size(67, 23);
            this.input_qty.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(314, 181);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(84, 28);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "&Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // input_invoiceNo
            // 
            this.input_invoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_invoiceNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_invoiceNo.Location = new System.Drawing.Point(98, 64);
            this.input_invoiceNo.Name = "input_invoiceNo";
            this.input_invoiceNo.Size = new System.Drawing.Size(124, 25);
            this.input_invoiceNo.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "New Invoice";
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(509, 437);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(84, 28);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // disp_total
            // 
            this.disp_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disp_total.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disp_total.Location = new System.Drawing.Point(56, 437);
            this.disp_total.Name = "disp_total";
            this.disp_total.ReadOnly = true;
            this.disp_total.Size = new System.Drawing.Size(124, 25);
            this.disp_total.TabIndex = 31;
            this.disp_total.TabStop = false;
            // 
            // NewInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(605, 472);
            this.Controls.Add(this.disp_total);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.input_invoiceNo);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.input_qty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_itemName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_date);
            this.Controls.Add(this.input_clientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disp_grid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewInvoiceForm";
            this.Text = "New Invoice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewInvoiceForm_FormClosed);
            this.Load += new System.EventHandler(this.NewInvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView disp_grid;
        private System.Windows.Forms.ComboBox input_clientName;
        private System.Windows.Forms.DateTimePicker input_date;
        private System.Windows.Forms.ComboBox input_itemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown input_qty;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox input_invoiceNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox disp_total;
    }
}