namespace ItemInventory
{
    partial class ReturnedItemsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.disp_warehouse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.input_qty = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.input_itemId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.disp_grid = new System.Windows.Forms.DataGridView();
            this.disp_invoiceNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.input_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Returned Items";
            // 
            // disp_warehouse
            // 
            this.disp_warehouse.AutoSize = true;
            this.disp_warehouse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disp_warehouse.ForeColor = System.Drawing.Color.White;
            this.disp_warehouse.Location = new System.Drawing.Point(94, 83);
            this.disp_warehouse.Name = "disp_warehouse";
            this.disp_warehouse.Size = new System.Drawing.Size(18, 17);
            this.disp_warehouse.TabIndex = 45;
            this.disp_warehouse.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Warehouse:";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(318, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 28);
            this.button2.TabIndex = 43;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(228, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 42;
            this.button1.Text = "&Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(310, 131);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(84, 28);
            this.btn_add.TabIndex = 41;
            this.btn_add.Text = "&Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // input_qty
            // 
            this.input_qty.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_qty.Location = new System.Drawing.Point(224, 136);
            this.input_qty.Name = "input_qty";
            this.input_qty.Size = new System.Drawing.Size(67, 23);
            this.input_qty.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(187, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Qty:";
            // 
            // input_itemId
            // 
            this.input_itemId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_itemId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_itemId.FormattingEnabled = true;
            this.input_itemId.Location = new System.Drawing.Point(55, 133);
            this.input_itemId.Name = "input_itemId";
            this.input_itemId.Size = new System.Drawing.Size(121, 25);
            this.input_itemId.TabIndex = 38;
            this.input_itemId.SelectedIndexChanged += new System.EventHandler(this.input_itemId_SelectedIndexChanged);
            this.input_itemId.TextChanged += new System.EventHandler(this.input_itemId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Item:";
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
            this.quantity});
            this.disp_grid.Enabled = false;
            this.disp_grid.Location = new System.Drawing.Point(12, 177);
            this.disp_grid.Name = "disp_grid";
            this.disp_grid.ReadOnly = true;
            this.disp_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.disp_grid.Size = new System.Drawing.Size(390, 192);
            this.disp_grid.TabIndex = 36;
            // 
            // disp_invoiceNo
            // 
            this.disp_invoiceNo.AutoSize = true;
            this.disp_invoiceNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disp_invoiceNo.ForeColor = System.Drawing.Color.White;
            this.disp_invoiceNo.Location = new System.Drawing.Point(94, 56);
            this.disp_invoiceNo.Name = "disp_invoiceNo";
            this.disp_invoiceNo.Size = new System.Drawing.Size(18, 17);
            this.disp_invoiceNo.TabIndex = 47;
            this.disp_invoiceNo.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Invoice No.:";
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
            // quantity
            // 
            this.quantity.HeaderText = "Qty";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 50;
            // 
            // ReturnedItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(414, 425);
            this.Controls.Add(this.disp_invoiceNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.disp_warehouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.input_qty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_itemId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disp_grid);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnedItemsForm";
            this.Text = "Returned Items";
            this.Load += new System.EventHandler(this.ReturnedItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label disp_warehouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.NumericUpDown input_qty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox input_itemId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView disp_grid;
        private System.Windows.Forms.Label disp_invoiceNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
    }
}