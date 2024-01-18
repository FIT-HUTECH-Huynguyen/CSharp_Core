using System.Windows.Forms;

namespace Lab02_04
{
    public partial class Form1 : Form
    {
        private int _numbers = 0;
        private int index = -1;
        public Form1()
        {
            InitializeComponent();
        }
        public void loadForm()
        {
        }
        public Customer addCustomer()
        {
            string accountNumber = txtAccountNumber.Text;
            string customerName = txtCustomerName.Text;
            string custmerAddress = txtCustomerAddress.Text;
            long accountBalance = long.Parse(txtAccountBalance.Text);

            Customer newCustomer = new Customer(accountNumber, customerName, custmerAddress, accountBalance);

            return newCustomer;
        }

        public void addorUpdateCustomerIntoTable(Customer customer, int index)
        {
            dgvAccounts.Rows[index].Cells["colSTT"].Value = _numbers++;
            dgvAccounts.Rows[index].Cells["colAccountNumber"].Value = customer.AccountNumber;
            dgvAccounts.Rows[index].Cells["colCustomerName"].Value = customer.CustomerName;
            dgvAccounts.Rows[index].Cells["colAddress"].Value = customer.CustomerAddress;
            dgvAccounts.Rows[index].Cells["colAccountBalance"].Value = customer.AccountBalance;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (checkInfoInput())
            {
                Customer customer = addCustomer();
                if (button.Text.Equals("Add"))
                {
                    if(checkAccountNumber(customer.AccountNumber))
                    {
                        MessageBox.Show("Added Customer Complete !!");
                        addorUpdateCustomerIntoTable(customer, dgvAccounts.Rows.Add());
                        
                    }
                    else
                    {
                        MessageBox.Show("Account number have already exited!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Updated Customer Complete !!");
                    addorUpdateCustomerIntoTable(customer, index);
                    btnAddUpdate.Text = "Add";
                    btnDelete.Enabled = false;
                }
                setDefault();
            }
        }

        private void setDefault()
        {
            txtAccountNumber.Text = "";
            txtCustomerName.Text = "";
            txtCustomerAddress.Text = "";
            txtAccountBalance.Text = "";
        }
        public bool checkAccountNumber (string accountNumber)
        {
            if (dgvAccounts.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvAccounts.Rows)
                {
                    if (row.Cells["colAccountNumber"].Value.Equals(accountNumber))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool checkInfoInput()
        {
            errNotify.Clear();
            int accountNumber;
            if (int.TryParse(txtAccountNumber.Text, out accountNumber) == false)
            {
                errNotify.SetError(txtAccountNumber, "*");
                return false;
            }
            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                errNotify.SetError(txtCustomerName, "*");
                return false;
            }
            if (string.IsNullOrEmpty(txtCustomerAddress.Text))
            {
                errNotify.SetError(txtCustomerAddress, "*");
                return false;
            }
            int accountBalance;
            if (int.TryParse(txtAccountBalance.Text, out accountBalance) == false
                || string.IsNullOrEmpty(txtAccountBalance.Text))
            {
                errNotify.SetError(txtAccountBalance, "*");
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnAddUpdate.Text = "Add";
            btnDelete.Enabled = false;
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                index = e.RowIndex;
                txtAccountNumber.Text = dgvAccounts.Rows[index].Cells["colAccountNumber"].Value.ToString();
                txtCustomerAddress.Text = dgvAccounts.Rows[index].Cells["colAddress"].Value.ToString();
                txtCustomerName.Text = dgvAccounts.Rows[index].Cells["colCustomerName"].Value.ToString();
                txtAccountBalance.Text = dgvAccounts.Rows[index].Cells["colAccountBalance"].Value.ToString();

                btnAddUpdate.Text = "Update";
                btnDelete.Enabled = true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(index != -1)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show("Are you sure you want to delete ? ", "Warning", buttons);
                
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Deleted Complete !!");
                    dgvAccounts.Rows.RemoveAt(index);
                    btnAddUpdate.Text = "Add";
                    btnDelete.Enabled = false;
                    setDefault();
                }
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result;
            
            result = MessageBox.Show("Do you want to quit program?","Quit ?",button);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}