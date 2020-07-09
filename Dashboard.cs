using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDapper
{
    public partial class Dashboard : Form
    {
        List<Customer> customers = new List<Customer>();
        public Dashboard()
        {
            InitializeComponent();
            searchResultListBox.DataSource = customers;
            searchResultListBox.DisplayMember = "DisplayInfo";
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            DataAccess dba = new DataAccess();
            customers = dba.FetchCustomers(customerPartialName.Text);
        }
    }
}
