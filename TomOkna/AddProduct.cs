using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomOkna
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

       

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "windowCompanyDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.windowCompanyDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "windowCompanyDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.windowCompanyDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "windowCompanyDataSet.Appliances". При необходимости она может быть перемещена или удалена.
            this.appliancesTableAdapter.Fill(this.windowCompanyDataSet.Appliances);

        }

      

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.Fill(this.windowCompanyDataSet.Orders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
