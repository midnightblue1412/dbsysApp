namespace ItemInventory
{
    partial class MainForm
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
            this.input_warehouse = new System.Windows.Forms.ComboBox();
            this.disp_ItemInventory = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnsQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disp_ItemInventory)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_warehouse
            // 
            this.input_warehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_warehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_warehouse.FormattingEnabled = true;
            this.input_warehouse.Location = new System.Drawing.Point(92, 102);
            this.input_warehouse.Name = "input_warehouse";
            this.input_warehouse.Size = new System.Drawing.Size(184, 25);
            this.input_warehouse.TabIndex = 3;
            this.input_warehouse.SelectedIndexChanged += new System.EventHandler(this.input_warehouse_SelectedIndexChanged);
            // 
            // disp_ItemInventory
            // 
            this.disp_ItemInventory.AllowUserToAddRows = false;
            this.disp_ItemInventory.AllowUserToDeleteRows = false;
            this.disp_ItemInventory.AllowUserToResizeColumns = false;
            this.disp_ItemInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disp_ItemInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disp_ItemInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.itemName,
            this.quantity,
            this.returnsQty});
            this.disp_ItemInventory.Location = new System.Drawing.Point(12, 169);
            this.disp_ItemInventory.Name = "disp_ItemInventory";
            this.disp_ItemInventory.ReadOnly = true;
            this.disp_ItemInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.disp_ItemInventory.Size = new System.Drawing.Size(468, 273);
            this.disp_ItemInventory.TabIndex = 4;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 75;
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
            // returnsQty
            // 
            this.returnsQty.HeaderText = "Returns";
            this.returnsQty.Name = "returnsQty";
            this.returnsQty.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Warehouse:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.inventoriesToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newInvoiceToolStripMenuItem,
            this.registerItemsToolStripMenuItem,
            this.registerClientToolStripMenuItem,
            this.registerWarehouseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openToolStripMenuItem.Text = "&Open Invoice";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newInvoiceToolStripMenuItem
            // 
            this.newInvoiceToolStripMenuItem.Name = "newInvoiceToolStripMenuItem";
            this.newInvoiceToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newInvoiceToolStripMenuItem.Text = "&New Invoice";
            this.newInvoiceToolStripMenuItem.Click += new System.EventHandler(this.newInvoiceToolStripMenuItem_Click);
            // 
            // registerItemsToolStripMenuItem
            // 
            this.registerItemsToolStripMenuItem.Name = "registerItemsToolStripMenuItem";
            this.registerItemsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registerItemsToolStripMenuItem.Text = "Register &Items";
            this.registerItemsToolStripMenuItem.Click += new System.EventHandler(this.registerItemsToolStripMenuItem_Click);
            // 
            // registerClientToolStripMenuItem
            // 
            this.registerClientToolStripMenuItem.Name = "registerClientToolStripMenuItem";
            this.registerClientToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registerClientToolStripMenuItem.Text = "Register &Clients";
            this.registerClientToolStripMenuItem.Click += new System.EventHandler(this.registerClientToolStripMenuItem_Click);
            // 
            // registerWarehouseToolStripMenuItem
            // 
            this.registerWarehouseToolStripMenuItem.Name = "registerWarehouseToolStripMenuItem";
            this.registerWarehouseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registerWarehouseToolStripMenuItem.Text = "Register &Warehouses";
            this.registerWarehouseToolStripMenuItem.Click += new System.EventHandler(this.registerWarehouseToolStripMenuItem_Click);
            // 
            // inventoriesToolStripMenuItem
            // 
            this.inventoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem});
            this.inventoriesToolStripMenuItem.Name = "inventoriesToolStripMenuItem";
            this.inventoriesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.inventoriesToolStripMenuItem.Text = "&Actions";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.addItemToolStripMenuItem.Text = "&Add Item To ItemInventory";
            this.addItemToolStripMenuItem.ToolTipText = "Add items to the current warehouse selected";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.warehousesToolStripMenuItem,
            this.clientsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.itemsToolStripMenuItem.Text = "&Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // warehousesToolStripMenuItem
            // 
            this.warehousesToolStripMenuItem.Name = "warehousesToolStripMenuItem";
            this.warehousesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.warehousesToolStripMenuItem.Text = "&Warehouses";
            this.warehousesToolStripMenuItem.Click += new System.EventHandler(this.warehousesToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.clientsToolStripMenuItem.Text = "&Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Item Inventory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Inventory";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(493, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.disp_ItemInventory);
            this.Controls.Add(this.input_warehouse);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvSys";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.disp_ItemInventory)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox input_warehouse;
        private System.Windows.Forms.DataGridView disp_ItemInventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerWarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem newInvoiceToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnsQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}

