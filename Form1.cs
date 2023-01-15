using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos
{
    public partial class Form1 : Form
    {
            FormState frmState = FormState.Add;

        public object currentCustomer { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setFormState();
            RereshItemgrid();
            this.customerTableAdapter.Fill(this.pOSDataSet.Customer);

        }

        private void RereshItemgrid()
        {
            throw new NotImplementedException();
        }

        private void setFormState()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmState = FormState.Add;
            SetFormState();

            currentCustomer.customerNo = int.Parse();
            currentCustomer.customerName = txtname.Text;
            currentCustomer.Balance = int.Parse();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow =new DataGridViewRow();
            currentCustomer.CustomerNo = int.Parse(currentRow.Cells[0].Value.ToString);
            currentCustomer.CustomerName =(currentRow.Cells[1].Value.ToString);
            currentCustomer.CustomerBalance = int.Parse(currentRow.Cells[2].Value.ToString);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmState = FormState.WaitingToSave;
            SetFormState();
        }

        private void SetFormState()
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmState = FormState.Add;
            SetFormState();
            ClearForm();
        }

        private void ClearForm()
        {
            throw new NotImplementedException();
            txtname.Text = "";
            txtNo.Text = "";
            txtBalance = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmState = FormState.Add;
            SetFormState();
            ClearForm();

        }
    }
}
