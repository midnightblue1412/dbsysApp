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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.window_tabs = new System.Windows.Forms.TabControl();
            this.tab_Inventory = new System.Windows.Forms.TabPage();
            this.btn_addItems = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.disp_ItemInventory = new System.Windows.Forms.DataGridView();
            this.inv_itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv_itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv_returns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_warehouse = new System.Windows.Forms.ComboBox();
            this.tab_InventoryMov = new System.Windows.Forms.TabPage();
            this.disp_grid_history = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.tab_Invoices = new System.Windows.Forms.TabPage();
            this.btn_serveWRet = new System.Windows.Forms.Button();
            this.btn_recordReturns = new System.Windows.Forms.Button();
            this.btn_cancelSelected = new System.Windows.Forms.Button();
            this.btn_serveSelected = new System.Windows.Forms.Button();
            this.btn_newInvoice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.disp_date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.disp_client = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.input_invoiceNo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.disp_grid_inv = new System.Windows.Forms.DataGridView();
            this.invoice_itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_orderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceItemsCtxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serveItemsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelItemsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.serveWithReturnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_Warehouses = new System.Windows.Forms.TabPage();
            this.btn_registerWarehouse = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.disp_grid_warehouse = new System.Windows.Forms.DataGridView();
            this.col_warehouseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_warehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_warehouseDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_warehouseStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehousesCtxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.markAsOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAsClosedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_Items = new System.Windows.Forms.TabPage();
            this.btn_registerItem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.disp_grid_item = new System.Windows.Forms.DataGridView();
            this.col_itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_itemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_itemStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsCtxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.makeUnavalableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_Clients = new System.Windows.Forms.TabPage();
            this.btn_registerClients = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.disp_grid_client = new System.Windows.Forms.DataGridView();
            this.col_clientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_clientAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_clientStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsCtxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.markAsActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAsInactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.window_tabs.SuspendLayout();
            this.tab_Inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_ItemInventory)).BeginInit();
            this.tab_InventoryMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid_history)).BeginInit();
            this.tab_Invoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid_inv)).BeginInit();
            this.invoiceItemsCtxMenu.SuspendLayout();
            this.tab_Warehouses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid_warehouse)).BeginInit();
            this.warehousesCtxMenu.SuspendLayout();
            this.tab_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid_item)).BeginInit();
            this.itemsCtxMenu.SuspendLayout();
            this.tab_Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid_client)).BeginInit();
            this.clientsCtxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // window_tabs
            // 
            this.window_tabs.Controls.Add(this.tab_Inventory);
            this.window_tabs.Controls.Add(this.tab_InventoryMov);
            this.window_tabs.Controls.Add(this.tab_Invoices);
            this.window_tabs.Controls.Add(this.tab_Warehouses);
            this.window_tabs.Controls.Add(this.tab_Items);
            this.window_tabs.Controls.Add(this.tab_Clients);
            this.window_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.window_tabs.Location = new System.Drawing.Point(0, 0);
            this.window_tabs.Name = "window_tabs";
            this.window_tabs.SelectedIndex = 0;
            this.window_tabs.Size = new System.Drawing.Size(1085, 607);
            this.window_tabs.TabIndex = 9;
            // 
            // tab_Inventory
            // 
            this.tab_Inventory.BackColor = System.Drawing.Color.MidnightBlue;
            this.tab_Inventory.Controls.Add(this.btn_addItems);
            this.tab_Inventory.Controls.Add(this.label1);
            this.tab_Inventory.Controls.Add(this.label3);
            this.tab_Inventory.Controls.Add(this.label2);
            this.tab_Inventory.Controls.Add(this.disp_ItemInventory);
            this.tab_Inventory.Controls.Add(this.input_warehouse);
            this.tab_Inventory.Location = new System.Drawing.Point(4, 26);
            this.tab_Inventory.Name = "tab_Inventory";
            this.tab_Inventory.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Inventory.Size = new System.Drawing.Size(1077, 577);
            this.tab_Inventory.TabIndex = 0;
            this.tab_Inventory.Text = "Inventory";
            this.tab_Inventory.Enter += new System.EventHandler(this.tab_Inventory_Enter);
            // 
            // btn_addItems
            // 
            this.btn_addItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addItems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItems.ForeColor = System.Drawing.Color.White;
            this.btn_addItems.Location = new System.Drawing.Point(324, 51);
            this.btn_addItems.Name = "btn_addItems";
            this.btn_addItems.Size = new System.Drawing.Size(105, 28);
            this.btn_addItems.TabIndex = 42;
            this.btn_addItems.Text = "&Add Items";
            this.btn_addItems.UseVisualStyleBackColor = true;
            this.btn_addItems.Click += new System.EventHandler(this.btn_addItems_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Item Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Warehouse:";
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
            this.inv_itemId,
            this.inv_itemName,
            this.inv_quantity,
            this.inv_returns});
            this.disp_ItemInventory.Location = new System.Drawing.Point(6, 127);
            this.disp_ItemInventory.Name = "disp_ItemInventory";
            this.disp_ItemInventory.ReadOnly = true;
            this.disp_ItemInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.disp_ItemInventory.Size = new System.Drawing.Size(1065, 442);
            this.disp_ItemInventory.TabIndex = 15;
            // 
            // inv_itemId
            // 
            this.inv_itemId.HeaderText = "Item Id";
            this.inv_itemId.Name = "inv_itemId";
            this.inv_itemId.ReadOnly = true;
            this.inv_itemId.Width = 75;
            // 
            // inv_itemName
            // 
            this.inv_itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inv_itemName.HeaderText = "Name";
            this.inv_itemName.Name = "inv_itemName";
            this.inv_itemName.ReadOnly = true;
            // 
            // inv_quantity
            // 
            this.inv_quantity.HeaderText = "Qty";
            this.inv_quantity.Name = "inv_quantity";
            this.inv_quantity.ReadOnly = true;
            // 
            // inv_returns
            // 
            this.inv_returns.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.inv_returns.HeaderText = "Returns";
            this.inv_returns.Name = "inv_returns";
            this.inv_returns.ReadOnly = true;
            // 
            // input_warehouse
            // 
            this.input_warehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.input_warehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_warehouse.FormattingEnabled = true;
            this.input_warehouse.Location = new System.Drawing.Point(88, 54);
            this.input_warehouse.Name = "input_warehouse";
            this.input_warehouse.Size = new System.Drawing.Size(184, 25);
            this.input_warehouse.TabIndex = 14;
            this.input_warehouse.SelectedIndexChanged += new System.EventHandler(this.input_warehouse_SelectedIndexChanged);
            // 
            // tab_InventoryMov
            // 
            this.tab_InventoryMov.BackColor = System.Drawing.Color.MidnightBlue;
            this.tab_InventoryMov.Controls.Add(this.disp_grid_history);
            this.tab_InventoryMov.Controls.Add(this.label11);
            this.tab_InventoryMov.Location = new System.Drawing.Point(4, 26);
            this.tab_InventoryMov.Name = "tab_InventoryMov";
            this.tab_InventoryMov.Padding = new System.Windows.Forms.Padding(3);
            this.tab_InventoryMov.Size = new System.Drawing.Size(1077, 577);
            this.tab_InventoryMov.TabIndex = 4;
            this.tab_InventoryMov.Text = "Inventory History";
            this.tab_InventoryMov.Enter += new System.EventHandler(this.tab_history_Enter);
            // 
            // disp_grid_history
            // 
            this.disp_grid_history.AllowUserToAddRows = false;
            this.disp_grid_history.AllowUserToDeleteRows = false;
            this.disp_grid_history.AllowUserToResizeColumns = false;
            this.disp_grid_history.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disp_grid_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disp_grid_history.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.movDate,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.disp_grid_history.Location = new System.Drawing.Point(6, 66);
            this.disp_grid_history.Name = "disp_grid_history";
            this.disp_grid_history.ReadOnly = true;
            this.disp_grid_history.RowHeadersVisible = false;
            this.disp_grid_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.disp_grid_history.Size = new System.Drawing.Size(1065, 503);
            this.disp_grid_history.TabIndex = 24;
            this.disp_grid_history.Enter += new System.EventHandler(this.tab_history_Enter);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Refno";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // movDate
            // 
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.movDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.movDate.FillWeight = 200F;
            this.movDate.HeaderText = "Date";
            this.movDate.Name = "movDate";
            this.movDate.ReadOnly = true;
            this.movDate.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Warehouse";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Item";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Inventory History";
            // 
            // tab_Invoices
            // 
            this.tab_Invoices.BackColor = System.Drawing.Color.MidnightBlue;
            this.tab_Invoices.Controls.Add(this.btn_serveWRet);
            this.tab_Invoices.Controls.Add(this.btn_recordReturns);
            this.tab_Invoices.Controls.Add(this.btn_cancelSelected);
            this.tab_Invoices.Controls.Add(this.btn_serveSelected);
            this.tab_Invoices.Controls.Add(this.btn_newInvoice);
            this.tab_Invoices.Controls.Add(this.label4);
            this.tab_Invoices.Controls.Add(this.disp_date);
            this.tab_Invoices.Controls.Add(this.label5);
            this.tab_Invoices.Controls.Add(this.disp_client);
            this.tab_Invoices.Controls.Add(this.label6);
            this.tab_Invoices.Controls.Add(this.input_invoiceNo);
            this.tab_Invoices.Controls.Add(this.label7);
            this.tab_Invoices.Controls.Add(this.disp_grid_inv);
            this.tab_Invoices.Location = new System.Drawing.Point(4, 26);
            this.tab_Invoices.Name = "tab_Invoices";
            this.tab_Invoices.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Invoices.Size = new System.Drawing.Size(1077, 577);
            this.tab_Invoices.TabIndex = 5;
            this.tab_Invoices.Text = "Invoices";
            this.tab_Invoices.Enter += new System.EventHandler(this.tab_Invoices_Enter);
            // 
            // btn_serveWRet
            // 
            this.btn_serveWRet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_serveWRet.ForeColor = System.Drawing.Color.White;
            this.btn_serveWRet.Location = new System.Drawing.Point(479, 52);
            this.btn_serveWRet.Name = "btn_serveWRet";
            this.btn_serveWRet.Size = new System.Drawing.Size(156, 28);
            this.btn_serveWRet.TabIndex = 33;
            this.btn_serveWRet.Text = "Serve &With Returns";
            this.btn_serveWRet.UseVisualStyleBackColor = true;
            this.btn_serveWRet.Click += new System.EventHandler(this.serveWRet_option_Click);
            // 
            // btn_recordReturns
            // 
            this.btn_recordReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recordReturns.ForeColor = System.Drawing.Color.White;
            this.btn_recordReturns.Location = new System.Drawing.Point(346, 52);
            this.btn_recordReturns.Name = "btn_recordReturns";
            this.btn_recordReturns.Size = new System.Drawing.Size(134, 28);
            this.btn_recordReturns.TabIndex = 32;
            this.btn_recordReturns.Text = "&Record Returns";
            this.btn_recordReturns.UseVisualStyleBackColor = true;
            this.btn_recordReturns.Click += new System.EventHandler(this.btn_recordReturns_Click);
            // 
            // btn_cancelSelected
            // 
            this.btn_cancelSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelSelected.ForeColor = System.Drawing.Color.White;
            this.btn_cancelSelected.Location = new System.Drawing.Point(215, 52);
            this.btn_cancelSelected.Name = "btn_cancelSelected";
            this.btn_cancelSelected.Size = new System.Drawing.Size(134, 28);
            this.btn_cancelSelected.TabIndex = 31;
            this.btn_cancelSelected.Text = "&Cancel Selected";
            this.btn_cancelSelected.UseVisualStyleBackColor = true;
            this.btn_cancelSelected.Click += new System.EventHandler(this.cancel_items_option_Click);
            // 
            // btn_serveSelected
            // 
            this.btn_serveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_serveSelected.ForeColor = System.Drawing.Color.White;
            this.btn_serveSelected.Location = new System.Drawing.Point(90, 52);
            this.btn_serveSelected.Name = "btn_serveSelected";
            this.btn_serveSelected.Size = new System.Drawing.Size(126, 28);
            this.btn_serveSelected.TabIndex = 30;
            this.btn_serveSelected.Text = "&Serve Selected";
            this.btn_serveSelected.UseVisualStyleBackColor = true;
            this.btn_serveSelected.Click += new System.EventHandler(this.serve_items_option_Click);
            // 
            // btn_newInvoice
            // 
            this.btn_newInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newInvoice.ForeColor = System.Drawing.Color.White;
            this.btn_newInvoice.Location = new System.Drawing.Point(12, 52);
            this.btn_newInvoice.Name = "btn_newInvoice";
            this.btn_newInvoice.Size = new System.Drawing.Size(84, 28);
            this.btn_newInvoice.TabIndex = 29;
            this.btn_newInvoice.Text = "&New";
            this.btn_newInvoice.UseVisualStyleBackColor = true;
            this.btn_newInvoice.Click += new System.EventHandler(this.btn_newInvoice_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Invoice";
            // 
            // disp_date
            // 
            this.disp_date.AutoSize = true;
            this.disp_date.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disp_date.ForeColor = System.Drawing.Color.White;
            this.disp_date.Location = new System.Drawing.Point(632, 115);
            this.disp_date.Name = "disp_date";
            this.disp_date.Size = new System.Drawing.Size(18, 17);
            this.disp_date.TabIndex = 27;
            this.disp_date.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(582, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Date:";
            // 
            // disp_client
            // 
            this.disp_client.AutoSize = true;
            this.disp_client.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disp_client.ForeColor = System.Drawing.Color.White;
            this.disp_client.Location = new System.Drawing.Point(295, 115);
            this.disp_client.Name = "disp_client";
            this.disp_client.Size = new System.Drawing.Size(18, 17);
            this.disp_client.TabIndex = 25;
            this.disp_client.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(245, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Client:";
            // 
            // input_invoiceNo
            // 
            this.input_invoiceNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_invoiceNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_invoiceNo.FormattingEnabled = true;
            this.input_invoiceNo.Location = new System.Drawing.Point(90, 112);
            this.input_invoiceNo.Name = "input_invoiceNo";
            this.input_invoiceNo.Size = new System.Drawing.Size(121, 25);
            this.input_invoiceNo.TabIndex = 23;
            this.input_invoiceNo.SelectedIndexChanged += new System.EventHandler(this.input_invoiceNo_SelectedIndexChanged);
            this.input_invoiceNo.TextChanged += new System.EventHandler(this.input_invoiceNo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Invoice No:";
            // 
            // disp_grid_inv
            // 
            this.disp_grid_inv.AllowUserToAddRows = false;
            this.disp_grid_inv.AllowUserToDeleteRows = false;
            this.disp_grid_inv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disp_grid_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disp_grid_inv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoice_itemId,
            this.invoice_itemName,
            this.invoice_quantity,
            this.invoice_orderStatus});
            this.disp_grid_inv.ContextMenuStrip = this.invoiceItemsCtxMenu;
            this.disp_grid_inv.Location = new System.Drawing.Point(6, 158);
            this.disp_grid_inv.Name = "disp_grid_inv";
            this.disp_grid_inv.ReadOnly = true;
            this.disp_grid_inv.RowHeadersVisible = false;
            this.disp_grid_inv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.disp_grid_inv.Size = new System.Drawing.Size(1063, 411);
            this.disp_grid_inv.TabIndex = 21;
            this.disp_grid_inv.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.disp_grid_inv_RowStateChanged);
            // 
            // invoice_itemId
            // 
            this.invoice_itemId.HeaderText = "Item ID";
            this.invoice_itemId.Name = "invoice_itemId";
            this.invoice_itemId.ReadOnly = true;
            this.invoice_itemId.Width = 75;
            // 
            // invoice_itemName
            // 
            this.invoice_itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.invoice_itemName.HeaderText = "Name";
            this.invoice_itemName.Name = "invoice_itemName";
            this.invoice_itemName.ReadOnly = true;
            // 
            // invoice_quantity
            // 
            this.invoice_quantity.HeaderText = "Qty";
            this.invoice_quantity.Name = "invoice_quantity";
            this.invoice_quantity.ReadOnly = true;
            // 
            // invoice_orderStatus
            // 
            this.invoice_orderStatus.HeaderText = "Status";
            this.invoice_orderStatus.Name = "invoice_orderStatus";
            this.invoice_orderStatus.ReadOnly = true;
            // 
            // invoiceItemsCtxMenu
            // 
            this.invoiceItemsCtxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serveItemsOption,
            this.cancelItemsOption,
            this.serveWithReturnsToolStripMenuItem});
            this.invoiceItemsCtxMenu.Name = "invoiceItemsCtxMenu";
            this.invoiceItemsCtxMenu.ShowImageMargin = false;
            this.invoiceItemsCtxMenu.Size = new System.Drawing.Size(149, 70);
            // 
            // serveItemsOption
            // 
            this.serveItemsOption.Name = "serveItemsOption";
            this.serveItemsOption.Size = new System.Drawing.Size(148, 22);
            this.serveItemsOption.Text = "Serve Selected";
            this.serveItemsOption.Click += new System.EventHandler(this.serve_items_option_Click);
            // 
            // cancelItemsOption
            // 
            this.cancelItemsOption.Name = "cancelItemsOption";
            this.cancelItemsOption.Size = new System.Drawing.Size(148, 22);
            this.cancelItemsOption.Text = "Cancel Selected";
            this.cancelItemsOption.Click += new System.EventHandler(this.cancel_items_option_Click);
            // 
            // serveWithReturnsToolStripMenuItem
            // 
            this.serveWithReturnsToolStripMenuItem.Name = "serveWithReturnsToolStripMenuItem";
            this.serveWithReturnsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.serveWithReturnsToolStripMenuItem.Text = "Serve With Returns";
            this.serveWithReturnsToolStripMenuItem.Click += new System.EventHandler(this.serveWRet_option_Click);
            // 
            // tab_Warehouses
            // 
            this.tab_Warehouses.BackColor = System.Drawing.Color.MidnightBlue;
            this.tab_Warehouses.Controls.Add(this.btn_registerWarehouse);
            this.tab_Warehouses.Controls.Add(this.label8);
            this.tab_Warehouses.Controls.Add(this.disp_grid_warehouse);
            this.tab_Warehouses.Location = new System.Drawing.Point(4, 26);
            this.tab_Warehouses.Name = "tab_Warehouses";
            this.tab_Warehouses.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Warehouses.Size = new System.Drawing.Size(1077, 577);
            this.tab_Warehouses.TabIndex = 1;
            this.tab_Warehouses.Text = "Warehouses";
            this.tab_Warehouses.Enter += new System.EventHandler(this.tab_warehouses_Enter);
            // 
            // btn_registerWarehouse
            // 
            this.btn_registerWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registerWarehouse.ForeColor = System.Drawing.Color.White;
            this.btn_registerWarehouse.Location = new System.Drawing.Point(12, 49);
            this.btn_registerWarehouse.Name = "btn_registerWarehouse";
            this.btn_registerWarehouse.Size = new System.Drawing.Size(84, 28);
            this.btn_registerWarehouse.TabIndex = 12;
            this.btn_registerWarehouse.Text = "&Register";
            this.btn_registerWarehouse.UseVisualStyleBackColor = true;
            this.btn_registerWarehouse.Click += new System.EventHandler(this.btn_registerWarehouse_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Warehouses";
            // 
            // disp_grid_warehouse
            // 
            this.disp_grid_warehouse.AllowUserToAddRows = false;
            this.disp_grid_warehouse.AllowUserToDeleteRows = false;
            this.disp_grid_warehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disp_grid_warehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disp_grid_warehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_warehouseId,
            this.col_warehouseName,
            this.col_warehouseDesc,
            this.col_warehouseStatus});
            this.disp_grid_warehouse.ContextMenuStrip = this.warehousesCtxMenu;
            this.disp_grid_warehouse.Location = new System.Drawing.Point(6, 83);
            this.disp_grid_warehouse.Name = "disp_grid_warehouse";
            this.disp_grid_warehouse.ReadOnly = true;
            this.disp_grid_warehouse.RowHeadersVisible = false;
            this.disp_grid_warehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.disp_grid_warehouse.Size = new System.Drawing.Size(1063, 486);
            this.disp_grid_warehouse.TabIndex = 10;
            // 
            // col_warehouseId
            // 
            this.col_warehouseId.HeaderText = "Id";
            this.col_warehouseId.Name = "col_warehouseId";
            this.col_warehouseId.ReadOnly = true;
            // 
            // col_warehouseName
            // 
            this.col_warehouseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_warehouseName.HeaderText = "Name";
            this.col_warehouseName.Name = "col_warehouseName";
            this.col_warehouseName.ReadOnly = true;
            // 
            // col_warehouseDesc
            // 
            this.col_warehouseDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_warehouseDesc.HeaderText = "Description";
            this.col_warehouseDesc.Name = "col_warehouseDesc";
            this.col_warehouseDesc.ReadOnly = true;
            // 
            // col_warehouseStatus
            // 
            this.col_warehouseStatus.HeaderText = "Status";
            this.col_warehouseStatus.Name = "col_warehouseStatus";
            this.col_warehouseStatus.ReadOnly = true;
            // 
            // warehousesCtxMenu
            // 
            this.warehousesCtxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markAsOpenToolStripMenuItem,
            this.markAsClosedToolStripMenuItem});
            this.warehousesCtxMenu.Name = "warehousesCtxMenu";
            this.warehousesCtxMenu.Size = new System.Drawing.Size(155, 48);
            this.warehousesCtxMenu.Opening += new System.ComponentModel.CancelEventHandler(this.warehousesCtxMenu_Opening);
            // 
            // markAsOpenToolStripMenuItem
            // 
            this.markAsOpenToolStripMenuItem.Name = "markAsOpenToolStripMenuItem";
            this.markAsOpenToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.markAsOpenToolStripMenuItem.Text = "Mark as &Open";
            this.markAsOpenToolStripMenuItem.Click += new System.EventHandler(this.markAsOpenToolStripMenuItem_Click);
            // 
            // markAsClosedToolStripMenuItem
            // 
            this.markAsClosedToolStripMenuItem.Name = "markAsClosedToolStripMenuItem";
            this.markAsClosedToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.markAsClosedToolStripMenuItem.Text = "Mark as &Closed";
            this.markAsClosedToolStripMenuItem.Click += new System.EventHandler(this.markAsClosedToolStripMenuItem_Click);
            // 
            // tab_Items
            // 
            this.tab_Items.BackColor = System.Drawing.Color.MidnightBlue;
            this.tab_Items.Controls.Add(this.btn_registerItem);
            this.tab_Items.Controls.Add(this.label9);
            this.tab_Items.Controls.Add(this.disp_grid_item);
            this.tab_Items.Location = new System.Drawing.Point(4, 26);
            this.tab_Items.Name = "tab_Items";
            this.tab_Items.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Items.Size = new System.Drawing.Size(1077, 577);
            this.tab_Items.TabIndex = 2;
            this.tab_Items.Text = "Items";
            this.tab_Items.Enter += new System.EventHandler(this.tab_items_Enter);
            // 
            // btn_registerItem
            // 
            this.btn_registerItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registerItem.ForeColor = System.Drawing.Color.White;
            this.btn_registerItem.Location = new System.Drawing.Point(12, 49);
            this.btn_registerItem.Name = "btn_registerItem";
            this.btn_registerItem.Size = new System.Drawing.Size(84, 28);
            this.btn_registerItem.TabIndex = 13;
            this.btn_registerItem.Text = "&Register";
            this.btn_registerItem.UseVisualStyleBackColor = true;
            this.btn_registerItem.Click += new System.EventHandler(this.btn_registerItems_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Items";
            // 
            // disp_grid_item
            // 
            this.disp_grid_item.AllowUserToAddRows = false;
            this.disp_grid_item.AllowUserToDeleteRows = false;
            this.disp_grid_item.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disp_grid_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disp_grid_item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_itemId,
            this.col_itemName,
            this.col_itemDesc,
            this.col_unitPrice,
            this.col_itemStatus});
            this.disp_grid_item.ContextMenuStrip = this.itemsCtxMenu;
            this.disp_grid_item.Location = new System.Drawing.Point(6, 83);
            this.disp_grid_item.Name = "disp_grid_item";
            this.disp_grid_item.ReadOnly = true;
            this.disp_grid_item.RowHeadersVisible = false;
            this.disp_grid_item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.disp_grid_item.Size = new System.Drawing.Size(1063, 486);
            this.disp_grid_item.TabIndex = 11;
            // 
            // col_itemId
            // 
            this.col_itemId.HeaderText = "Id";
            this.col_itemId.Name = "col_itemId";
            this.col_itemId.ReadOnly = true;
            // 
            // col_itemName
            // 
            this.col_itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_itemName.HeaderText = "Name";
            this.col_itemName.Name = "col_itemName";
            this.col_itemName.ReadOnly = true;
            // 
            // col_itemDesc
            // 
            this.col_itemDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_itemDesc.HeaderText = "Description";
            this.col_itemDesc.Name = "col_itemDesc";
            this.col_itemDesc.ReadOnly = true;
            // 
            // col_unitPrice
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "--";
            this.col_unitPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_unitPrice.HeaderText = "Unit Price";
            this.col_unitPrice.Name = "col_unitPrice";
            this.col_unitPrice.ReadOnly = true;
            // 
            // col_itemStatus
            // 
            this.col_itemStatus.HeaderText = "Status";
            this.col_itemStatus.Name = "col_itemStatus";
            this.col_itemStatus.ReadOnly = true;
            // 
            // itemsCtxMenu
            // 
            this.itemsCtxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeUnavalableToolStripMenuItem,
            this.makeAvailableToolStripMenuItem});
            this.itemsCtxMenu.Name = "itemsCtxMenu";
            this.itemsCtxMenu.Size = new System.Drawing.Size(165, 48);
            this.itemsCtxMenu.Opening += new System.ComponentModel.CancelEventHandler(this.itemsCtxMenu_Opening);
            // 
            // makeUnavalableToolStripMenuItem
            // 
            this.makeUnavalableToolStripMenuItem.Name = "makeUnavalableToolStripMenuItem";
            this.makeUnavalableToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.makeUnavalableToolStripMenuItem.Text = "Make &Unavalable";
            this.makeUnavalableToolStripMenuItem.Click += new System.EventHandler(this.makeUnavalableToolStripMenuItem_Click);
            // 
            // makeAvailableToolStripMenuItem
            // 
            this.makeAvailableToolStripMenuItem.Name = "makeAvailableToolStripMenuItem";
            this.makeAvailableToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.makeAvailableToolStripMenuItem.Text = "Make &Available";
            this.makeAvailableToolStripMenuItem.Click += new System.EventHandler(this.makeAvailableToolStripMenuItem_Click);
            // 
            // tab_Clients
            // 
            this.tab_Clients.BackColor = System.Drawing.Color.MidnightBlue;
            this.tab_Clients.Controls.Add(this.btn_registerClients);
            this.tab_Clients.Controls.Add(this.label10);
            this.tab_Clients.Controls.Add(this.disp_grid_client);
            this.tab_Clients.Location = new System.Drawing.Point(4, 26);
            this.tab_Clients.Name = "tab_Clients";
            this.tab_Clients.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Clients.Size = new System.Drawing.Size(1077, 577);
            this.tab_Clients.TabIndex = 3;
            this.tab_Clients.Text = "Clients";
            this.tab_Clients.Enter += new System.EventHandler(this.tab_clients_Enter);
            // 
            // btn_registerClients
            // 
            this.btn_registerClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registerClients.ForeColor = System.Drawing.Color.White;
            this.btn_registerClients.Location = new System.Drawing.Point(12, 49);
            this.btn_registerClients.Name = "btn_registerClients";
            this.btn_registerClients.Size = new System.Drawing.Size(84, 28);
            this.btn_registerClients.TabIndex = 14;
            this.btn_registerClients.Text = "&Register";
            this.btn_registerClients.UseVisualStyleBackColor = true;
            this.btn_registerClients.Click += new System.EventHandler(this.btn_registerClients_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "Clients";
            // 
            // disp_grid_client
            // 
            this.disp_grid_client.AllowUserToAddRows = false;
            this.disp_grid_client.AllowUserToDeleteRows = false;
            this.disp_grid_client.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disp_grid_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disp_grid_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_clientId,
            this.col_clientName,
            this.col_clientAddr,
            this.col_clientStatus});
            this.disp_grid_client.Location = new System.Drawing.Point(6, 83);
            this.disp_grid_client.Name = "disp_grid_client";
            this.disp_grid_client.ReadOnly = true;
            this.disp_grid_client.RowHeadersVisible = false;
            this.disp_grid_client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.disp_grid_client.Size = new System.Drawing.Size(1063, 486);
            this.disp_grid_client.TabIndex = 11;
            this.disp_grid_client.Enter += new System.EventHandler(this.tab_clients_Enter);
            // 
            // col_clientId
            // 
            this.col_clientId.HeaderText = "Id";
            this.col_clientId.Name = "col_clientId";
            this.col_clientId.ReadOnly = true;
            // 
            // col_clientName
            // 
            this.col_clientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_clientName.HeaderText = "Name";
            this.col_clientName.Name = "col_clientName";
            this.col_clientName.ReadOnly = true;
            // 
            // col_clientAddr
            // 
            this.col_clientAddr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_clientAddr.HeaderText = "Address";
            this.col_clientAddr.Name = "col_clientAddr";
            this.col_clientAddr.ReadOnly = true;
            // 
            // col_clientStatus
            // 
            this.col_clientStatus.HeaderText = "Status";
            this.col_clientStatus.Name = "col_clientStatus";
            this.col_clientStatus.ReadOnly = true;
            // 
            // clientsCtxMenu
            // 
            this.clientsCtxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markAsActiveToolStripMenuItem,
            this.markAsInactiveToolStripMenuItem});
            this.clientsCtxMenu.Name = "clientsCtxMenu";
            this.clientsCtxMenu.Size = new System.Drawing.Size(160, 70);
            this.clientsCtxMenu.Opening += new System.ComponentModel.CancelEventHandler(this.clientsCtxMenu_Opening);
            // 
            // markAsActiveToolStripMenuItem
            // 
            this.markAsActiveToolStripMenuItem.Name = "markAsActiveToolStripMenuItem";
            this.markAsActiveToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.markAsActiveToolStripMenuItem.Text = "Mark as &Active";
            this.markAsActiveToolStripMenuItem.Click += new System.EventHandler(this.markAsActiveToolStripMenuItem_Click);
            // 
            // markAsInactiveToolStripMenuItem
            // 
            this.markAsInactiveToolStripMenuItem.Name = "markAsInactiveToolStripMenuItem";
            this.markAsInactiveToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.markAsInactiveToolStripMenuItem.Text = "Mark as &Inactive";
            this.markAsInactiveToolStripMenuItem.Click += new System.EventHandler(this.markAsInactiveToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1085, 607);
            this.Controls.Add(this.window_tabs);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvSys";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.window_tabs.ResumeLayout(false);
            this.tab_Inventory.ResumeLayout(false);
            this.tab_Inventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_ItemInventory)).EndInit();
            this.tab_InventoryMov.ResumeLayout(false);
            this.tab_InventoryMov.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid_history)).EndInit();
            this.tab_Invoices.ResumeLayout(false);
            this.tab_Invoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid_inv)).EndInit();
            this.invoiceItemsCtxMenu.ResumeLayout(false);
            this.tab_Warehouses.ResumeLayout(false);
            this.tab_Warehouses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid_warehouse)).EndInit();
            this.warehousesCtxMenu.ResumeLayout(false);
            this.tab_Items.ResumeLayout(false);
            this.tab_Items.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid_item)).EndInit();
            this.itemsCtxMenu.ResumeLayout(false);
            this.tab_Clients.ResumeLayout(false);
            this.tab_Clients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid_client)).EndInit();
            this.clientsCtxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl window_tabs;
        private System.Windows.Forms.TabPage tab_Inventory;
        private System.Windows.Forms.TabPage tab_Warehouses;
        private System.Windows.Forms.TabPage tab_Items;
        private System.Windows.Forms.TabPage tab_Clients;
        private System.Windows.Forms.ComboBox input_warehouse;
        private System.Windows.Forms.DataGridView disp_ItemInventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addItems;
        private System.Windows.Forms.TabPage tab_InventoryMov;
        private System.Windows.Forms.TabPage tab_Invoices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label disp_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label disp_client;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox input_invoiceNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView disp_grid_inv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView disp_grid_warehouse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView disp_grid_item;
        private System.Windows.Forms.Button btn_registerItem;
        private System.Windows.Forms.Button btn_registerWarehouse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView disp_grid_client;
        private System.Windows.Forms.Button btn_registerClients;
        private System.Windows.Forms.Button btn_newInvoice;
        private System.Windows.Forms.Button btn_cancelSelected;
        private System.Windows.Forms.Button btn_serveSelected;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView disp_grid_history;
        private System.Windows.Forms.Button btn_recordReturns;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_orderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_warehouseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_warehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_warehouseDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_warehouseStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_clientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_clientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_clientAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_clientStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv_returns;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv_itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv_itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_itemStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_itemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_itemId;
        private System.Windows.Forms.ContextMenuStrip invoiceItemsCtxMenu;
        private System.Windows.Forms.ToolStripMenuItem serveItemsOption;
        private System.Windows.Forms.ToolStripMenuItem cancelItemsOption;
        private System.Windows.Forms.Button btn_serveWRet;
        private System.Windows.Forms.ToolStripMenuItem serveWithReturnsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn movDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ContextMenuStrip itemsCtxMenu;
        private System.Windows.Forms.ToolStripMenuItem makeUnavalableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAvailableToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip warehousesCtxMenu;
        private System.Windows.Forms.ToolStripMenuItem markAsOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAsClosedToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip clientsCtxMenu;
        private System.Windows.Forms.ToolStripMenuItem markAsActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAsInactiveToolStripMenuItem;
    }
}

