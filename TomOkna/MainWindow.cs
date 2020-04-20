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
    public partial class sale : Form
    {
        public sale()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void AddProd_Click(object sender, EventArgs e)
        {
            AddProduct AD = new AddProduct();
            AD.Show();
        }
    }
}
