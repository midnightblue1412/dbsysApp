namespace ItemInventory
{
    partial class InvoiceForm
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
            this.disp_grid = new System.Windows.Forms.DataGridView();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCtxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serve_items_option = new System.Windows.Forms.ToolStripMenuItem();
            this.cancel_items_option = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.input_invoiceNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.disp_client = new System.Windows.Forms.Label();
            this.disp_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serveSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serveSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordReturnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid)).BeginInit();
            this.dataGridCtxMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // disp_grid
            // 
            this.disp_grid.AllowUserToAddRows = false;
            this.disp_grid.AllowUserToDeleteRows = false;
            this.disp_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disp_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disp_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemId,
            this.itemName,
            this.quantity,
            this.orderStatus});
            this.disp_grid.ContextMenuStrip = this.dataGridCtxMenu;
            this.disp_grid.Location = new System.Drawing.Point(12, 189);
            this.disp_grid.Name = "disp_grid";
            this.disp_grid.ReadOnly = true;
            this.disp_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.disp_grid.Size = new System.Drawing.Size(498, 262);
            this.disp_grid.TabIndex = 6;
            this.disp_grid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.disp_grid_RowStateChanged);
            // 
            // itemId
            // 
            this.itemId.HeaderText = "Item ID";
            this.itemId.Name = "itemId";
            this.itemId.ReadOnly = true;
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
            // 
            // orderStatus
            // 
            this.orderStatus.HeaderText = "Status";
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.ReadOnly = true;
            // 
            // dataGridCtxMenu
            // 
            this.dataGridCtxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serve_items_option,
            this.cancel_items_option});
            this.dataGridCtxMenu.Name = "contextMenuStrip1";
            this.dataGridCtxMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.dataGridCtxMenu.Size = new System.Drawing.Size(151, 48);
            // 
            // serve_items_option
            // 
            this.serve_items_option.Name = "serve_items_option";
            this.serve_items_option.Size = new System.Drawing.Size(150, 22);
            this.serve_items_option.Text = "Serve Item(s)";
            this.serve_items_option.Click += new System.EventHandler(this.serve_items_option_Click);
            // 
            // cancel_items_option
            // 
            this.cancel_items_option.Name = "cancel_items_option";
            this.cancel_items_option.Size = new System.Drawing.Size(150, 22);
            this.cancel_items_option.Text = "Cancel Item(s)";
            this.cancel_items_option.Click += new System.EventHandler(this.cancel_items_option_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Invoice No:";
            // 
            // input_invoiceNo
            // 
            this.input_invoiceNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_invoiceNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_invoiceNo.FormattingEnabled = true;
            this.input_invoiceNo.Location = new System.Drawing.Point(93, 89);
            this.input_invoiceNo.Name = "input_invoiceNo";
            this.input_invoiceNo.Size = new System.Drawing.Size(121, 25);
            this.input_invoiceNo.TabIndex = 8;
            this.input_invoiceNo.SelectedIndexChanged += new System.EventHandler(this.input_invoiceNo_SelectedIndexChanged);
            this.input_invoiceNo.TextChanged += new System.EventHandler(this.input_invoiceNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Client:";
            // 
            // disp_client
            // 
            this.disp_client.AutoSize = true;
            this.disp_client.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disp_client.ForeColor = System.Drawing.Color.White;
            this.disp_client.Location = new System.Drawing.Point(62, 127);
            this.disp_client.Name = "disp_client";
            this.disp_client.Size = new System.Drawing.Size(18, 17);
            this.disp_client.TabIndex = 10;
            this.disp_client.Text = "--";
            // 
            // disp_date
            // 
            this.disp_date.AutoSize = true;
            this.disp_date.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disp_date.ForeColor = System.Drawing.Color.White;
            this.disp_date.Location = new System.Drawing.Point(62, 155);
            this.disp_date.Name = "disp_date";
            this.disp_date.Size = new System.Drawing.Size(18, 17);
            this.disp_date.TabIndex = 12;
            this.disp_date.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serveSelectedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serveSelectedToolStripMenuItem
            // 
            this.serveSelectedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serveSelectedToolStripMenuItem1,
            this.cancelSelectedToolStripMenuItem,
            this.recordReturnsToolStripMenuItem});
            this.serveSelectedToolStripMenuItem.Name = "serveSelectedToolStripMenuItem";
            this.serveSelectedToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.serveSelectedToolStripMenuItem.Text = "&Actions";
            // 
            // serveSelectedToolStripMenuItem1
            // 
            this.serveSelectedToolStripMenuItem1.Name = "serveSelectedToolStripMenuItem1";
            this.serveSelectedToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.serveSelectedToolStripMenuItem1.Text = "&Serve Selected Items";
            this.serveSelectedToolStripMenuItem1.Click += new System.EventHandler(this.serve_items_option_Click);
            // 
            // cancelSelectedToolStripMenuItem
            // 
            this.cancelSelectedToolStripMenuItem.Name = "cancelSelectedToolStripMenuItem";
            this.cancelSelectedToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cancelSelectedToolStripMenuItem.Text = "&Cancel Selected Items";
            this.cancelSelectedToolStripMenuItem.Click += new System.EventHandler(this.cancel_items_option_Click);
            // 
            // recordReturnsToolStripMenuItem
            // 
            this.recordReturnsToolStripMenuItem.Name = "recordReturnsToolStripMenuItem";
            this.recordReturnsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.recordReturnsToolStripMenuItem.Text = "&Record Returns";
            this.recordReturnsToolStripMenuItem.Click += new System.EventHandler(this.recordReturnsToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Invoice";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(523, 463);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.disp_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.disp_client);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_invoiceNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disp_grid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "InvoiceForm";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.disp_grid)).EndInit();
            this.dataGridCtxMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView disp_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox input_invoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label disp_client;
        private System.Windows.Forms.Label disp_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serveSelectedToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip dataGridCtxMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem serveSelectedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordReturnsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.ToolStripMenuItem serve_items_option;
        private System.Windows.Forms.ToolStripMenuItem cancel_items_option;
    }
}