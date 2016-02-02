namespace ItemInventory
{
    partial class SelectWarehouseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.input_warehouseId = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse ID:";
            // 
            // input_warehouseId
            // 
            this.input_warehouseId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_warehouseId.FormattingEnabled = true;
            this.input_warehouseId.Location = new System.Drawing.Point(144, 28);
            this.input_warehouseId.Name = "input_warehouseId";
            this.input_warehouseId.Size = new System.Drawing.Size(121, 25);
            this.input_warehouseId.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(170, 73);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(95, 32);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_proceed
            // 
            this.btn_proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proceed.ForeColor = System.Drawing.Color.White;
            this.btn_proceed.Location = new System.Drawing.Point(69, 73);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(95, 32);
            this.btn_proceed.TabIndex = 3;
            this.btn_proceed.Text = "&Proceed";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // SelectWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(287, 122);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.input_warehouseId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectWarehouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Warehouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectWarehouseForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox input_warehouseId;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_proceed;
    }
}