using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemInventory
{
    partial class MainForm
    {
        /*
         *  METHODS
         */
        public void invoice_fillInvoiceNoComboBox()
        {
            input_invoiceNo.Items.Clear();
            input_invoiceNo.Items.AddRange(
                (from invoice in db.Invoice select invoice).ToArray());
        }

        private void showInvoiceInfo(RecordsDataSet.InvoiceRow invoice)
        {
            disp_client.Text = invoice.ClientRow.clientName;
            disp_date.Text = invoice.orderDate.ToShortDateString();
        }

        private void invoice_fillDataGrid(RecordsDataSet.InvoiceRow invoice)
        {
            disp_grid_inv.Rows.Clear();

            RecordsDataSet.InvoiceItemRow[] rows =
                (from invoiceItem in db.InvoiceItem
                 where invoiceItem.invoiceNo.Equals(invoice.invoiceNo)
                 select invoiceItem).ToArray();

            foreach (RecordsDataSet.InvoiceItemRow r in rows)
            {
                disp_grid_inv.Rows.Add(r.itemId, r.ItemRow.itemName, r.quantity, r.orderStatus);
            }
        }

        private int serveSelectedItems(ServeItemsForm.InputFields mfields)
        {
            string invoiceNoTxt = input_invoiceNo.Text.Trim().ToUpper();

            foreach (DataGridViewRow r in disp_grid_inv.SelectedRows)
            {
                DataGridViewCellCollection c = r.Cells;

                if (c["invoice_orderStatus"].Value.ToString().Equals("SERVED"))
                {
                    return -1;
                }

                RecordsDataSet.InvoiceItemRow invoice =
                    input_invoiceNo.SelectedItem as RecordsDataSet.InvoiceItemRow;                

                int itemId = int.Parse(c["invoice_itemId"].Value.ToString());
                int qty = int.Parse(c["invoice_quantity"].Value.ToString());

                if (dbm.qadp.GetItemQuantity(mfields.warehouse.id, itemId) < qty)
                {
                    showErrorMessage("Not enough stock for item '" + c["invoice_itemName"].Value + "'");
                    return -1;
                }

                db.ItemServed.AddItemServedRow(
                    invoiceNoTxt, itemId, mfields.warehouse.id, qty, mfields.date);
            }

            return disp_grid_inv.SelectedRows.Count;
        }

        private int serveWRetSelectedItems(ServeItemsForm.InputFields mfields)
        {
            string invoiceNoTxt = input_invoiceNo.Text.Trim().ToUpper();

            foreach (DataGridViewRow r in disp_grid_inv.SelectedRows)
            {
                DataGridViewCellCollection c = r.Cells;

                if (c["invoice_orderStatus"].Value.ToString().Equals("SERVED"))
                {
                    return -1;
                }

                RecordsDataSet.InvoiceItemRow invoice =
                    input_invoiceNo.SelectedItem as RecordsDataSet.InvoiceItemRow;

                int itemId = int.Parse(c["invoice_itemId"].Value.ToString());
                int qty = int.Parse(c["invoice_quantity"].Value.ToString());

                if (dbm.qadp.GetRetItemQuantity(mfields.warehouse.id, itemId) < qty)
                {
                    showErrorMessage("Not enough stock for item '" + c["invoice_itemName"].Value + "'");
                    return -1;
                }

                db.ReturnServed.AddReturnServedRow(
                    invoiceNoTxt, itemId, mfields.warehouse.id, qty, mfields.date);
            }

            return disp_grid_inv.SelectedRows.Count;
        }

        private int cancelSelectedItems()
        {
            string invoiceNo = input_invoiceNo.Text;

            foreach (DataGridViewRow r in disp_grid_inv.SelectedRows)
            {
                DataGridViewCellCollection c = r.Cells;
                int itemId = int.Parse(c["invoice_itemId"].Value.ToString());

                if (c["invoice_orderStatus"].Value.ToString().Equals("SERVED"))
                {
                    showErrorMessage("Cannot cancel served item '" + c["invoice_itemName"].Value + "'");
                    return -1;
                }

                RecordsDataSet.InvoiceItemRow invItem =
                    db.InvoiceItem.FindByinvoiceNoitemId(invoiceNo, itemId);

                invItem.orderStatus = "CANCELLED";
            }

            return disp_grid_inv.SelectedRows.Count;
        }

        /*
         *  EVENT HANDLERS
         */
        private void input_invoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecordsDataSet.InvoiceRow invoice = input_invoiceNo.SelectedItem as RecordsDataSet.InvoiceRow;
            showInvoiceInfo(invoice);
            invoice_fillDataGrid(invoice);
        }

        private void input_invoiceNo_TextChanged(object sender, EventArgs e)
        {
            int index = input_invoiceNo.FindStringExact(input_invoiceNo.Text);
            input_invoiceNo.SelectedIndex = index;
        }

        private void disp_grid_inv_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged.Equals(DataGridViewElementStates.Selected) &&
                (e.Row.Cells["invoice_orderStatus"].Value.Equals("CANCELLED")))
            {
                e.Row.Selected = false;
            }
        }

        private void btn_recordReturns_Click(object sender, EventArgs e)
        {
            if (input_invoiceNo.SelectedItem == null)
            {
                showErrorMessage("Please select an invoice.");
            }
            else
            {
                using (ReturnedItemsForm rf = new ReturnedItemsForm(this, input_invoiceNo.Text))
                {
                    rf.ShowDialog();
                }
            }
        }

        private void serve_items_option_Click(object sender, EventArgs e)
        {
            if (disp_grid_inv.SelectedRows.Count == 0)
            {
                showErrorMessage("No Rows Selected.");
            }
            else
            {
                string wname = (input_warehouse.SelectedItem as RecordsDataSet.WarehouseRow).warehouseName;
                ServeItemsForm.InputFields inf = new ServeItemsForm.InputFields();
                DialogResult res;

                using (ServeItemsForm sf = new ServeItemsForm(inf, this))
                {
                    sf.setInvoice(input_invoiceNo.Text);
                    res = sf.ShowDialog();
                }

                if (res.Equals(DialogResult.OK))
                {
                    try
                    {
                        int rowsAff = serveSelectedItems(inf);

                        if (rowsAff > 0)
                        {
                            dbm.dbmgr.UpdateAll(db);
                            dbmgr.ItemInventoryTableAdapter.Fill(db.ItemInventory);
                            dbmgr.InvoiceItemTableAdapter.Fill(db.InvoiceItem);

                            refreshWarehouseComboBox();
                            int wid = (input_warehouse.SelectedItem as RecordsDataSet.WarehouseRow).id;

                            fillInventoryGrid(wid);
                            invoice_fillDataGrid(input_invoiceNo.SelectedItem as RecordsDataSet.InvoiceRow);

                            showSuccessMessage("Operation successful. " + rowsAff + " affected.");
                        }
                        else
                        {
                            showErrorMessage("Can't perform action on some selected items. Operation Aborted.");
                        }                        
                    }
                    catch (DBConcurrencyException ex)
                    {
                        DialogResult r = showErrorPrompt(
                            "An error occured while trying to sync with database.\n\n" +
                            "Details:\n" + ex.Message);

                        if (r.Equals(DialogResult.Retry))
                        {
                            serve_items_option_Click(sender, e);
                        }
                        else
                        {
                            db.RejectChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        db.RejectChanges();
                        showErrorMessage("An error occured.\n\nDetails:\n" + ex.Message);
                    }
                }                
            }
        }

        private void cancel_items_option_Click(object sender, EventArgs e)
        {
            if (disp_grid_inv.SelectedRows.Count == 0)
            {
                showErrorMessage("No Rows Selected.");
            }
            else
            {
                try
                {
                    int rowsAff = cancelSelectedItems();

                    if (rowsAff > 0)
                    {
                        dbm.dbmgr.UpdateAll(dbm.db);

                        invoice_fillDataGrid(input_invoiceNo.SelectedItem as RecordsDataSet.InvoiceRow);

                        showSuccessMessage("Operation successful. " + rowsAff + " affected.");
                    }
                    else
                    {
                        showErrorMessage("Can't perform action on some selected items. Operation Aborted.");
                    }
                }
                catch (Exception ex)
                {
                    showErrorMessage(
                        "An error occured while trying to perform operation.\n\n" +
                        "Details:\n" + ex.Message);
                }
            }
        }

        private void serveWRet_option_Click(object sender, EventArgs e)
        {
            if (disp_grid_inv.SelectedRows.Count == 0)
            {
                showErrorMessage("No Rows Selected.");
            }
            else
            {
                ServeItemsForm.InputFields inf = new ServeItemsForm.InputFields();
                DialogResult res;

                using (ServeItemsForm sf = new ServeItemsForm(inf, this))
                {
                    sf.setInvoice(input_invoiceNo.Text);
                    res = sf.ShowDialog();
                }

                if (res.Equals(DialogResult.OK))
                {
                    try
                    {
                        int rowsAff = serveWRetSelectedItems(inf);

                        if (rowsAff > 0)
                        {
                            dbm.dbmgr.UpdateAll(dbm.db);
                            dbmgr.ReturnsInventoryTableAdapter.Fill(db.ReturnsInventory);
                            dbmgr.InvoiceItemTableAdapter.Fill(db.InvoiceItem);

                            refreshWarehouseComboBox();
                            int wid = (input_warehouse.SelectedItem as RecordsDataSet.WarehouseRow).id;

                            fillInventoryGrid(wid);
                            invoice_fillDataGrid(input_invoiceNo.SelectedItem as RecordsDataSet.InvoiceRow);

                            showSuccessMessage("Operation successful. " + rowsAff + " affected.");
                        }
                        else
                        {
                            showErrorMessage("Can't perform action on some selected items. Operation Aborted.");
                        }
                    }
                    catch (DBConcurrencyException ex)
                    {
                        DialogResult r = showErrorPrompt(
                            "An error occured while trying to sync with database.\n\n" +
                            "Details:\n" + ex.Message);

                        if (r.Equals(DialogResult.Retry))
                        {
                            serve_items_option_Click(sender, e);
                        }
                        else
                        {
                            db.RejectChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        db.RejectChanges();
                        showErrorMessage("An error occured.\n\nDetails:\n" + ex.Message);
                    }
                }
            }
        }
    }
}
