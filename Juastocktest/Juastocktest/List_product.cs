using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juastocktest
{
    public partial class List_product : Form
    {
        public List_product()
        {
            InitializeComponent();
        }

        private void List_product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.tbl_product' table. You can move, or remove it, as needed.
            this.tbl_productTableAdapter.Fill(this.productDataSet.tbl_product);

        }
    }
}
