using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace Juastock
{
    public partial class List_Product : Form
    {
        public List_Product()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Juastock;Persist Security Info=True;User ID=sa;Password=1234");

        private void List_Product_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        public void FillDGV()
        {
            SqlCommand command = new SqlCommand("SELECT product_id, product_name, product_stock, product_cost, product_pic FROM tbl_product", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            table.Columns.Add("Pic", Type.GetType("System.Byte[]"));
            foreach (DataRow drow in table.Rows)
            {
                drow["Pic"] = File.ReadAllBytes(drow["product_pic"].ToString());
            }
            dataGridView1.DataSource = table;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            dataGridView1.RowTemplate.Height = 150;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[5];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgCol.Width = 200;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                txtPath.Text = opf.FileName;
            }
        }

        private void List_Product_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[5].Value;

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);

            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtStock.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCost.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPath.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void tbnInsertImg_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

       

            SqlCommand command = new SqlCommand("INSERT INTO tbl_product(product_name, product_stock, product_cost, product_pic) VALUES(@name, @stock, @cost, @img)", connection);

            command.Parameters.Add("@name", SqlDbType.VarChar).Value = txtName.Text;
            command.Parameters.Add("@stock", SqlDbType.Float).Value = txtStock.Text;
            command.Parameters.Add("@cost", SqlDbType.Float).Value = txtCost.Text;
            command.Parameters.Add("@img", SqlDbType.VarChar).Value = txtPath.Text;

            ExecMyQuery(command, "Data Inserted");
        }

        public void ExecMyQuery(SqlCommand mcomd, string myMsg)
        {
            connection.Open();
            if(mcomd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(myMsg);
            }
            else
            {
                MessageBox.Show("Query Not Executed");
            }
            connection.Close();

            FillDGV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            SqlCommand command = new SqlCommand("UPDATE tbl_product SET product_name=@name, product_stock=@stock, product_cost=@cost, product_pic=@img WHERE product_id = @id", connection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = txtId.Text;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = txtName.Text;
            command.Parameters.Add("@stock", SqlDbType.Float).Value = txtStock.Text;
            command.Parameters.Add("@cost", SqlDbType.Float).Value = txtCost.Text;
            command.Parameters.Add("@img", SqlDbType.VarChar).Value = txtPath.Text;

            ExecMyQuery(command, "Data Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM tbl_product WHERE product_id = @id", connection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = txtId.Text;

            ExecMyQuery(command, "Data Deleted");
        }
    }
}
