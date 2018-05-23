using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pao_mml
{
    public partial class ProductForm : Form
    {
        string id = null;

        ProductList p = new ProductList();

        public ProductForm(ProductList _p)
        {
            InitializeComponent();

            p = _p;
        }

        public void Product(string result)
        {
            id = result;

            var item = from x in p.Products
                 where
                     x.id.Contains(result)
                 select x;

            dataGridView_product.DataSource = item.ToList<Product>();

            var product_picture = dataGridView_product.Rows[0].Cells[6].Value.ToString();
            var product_description = dataGridView_product.Rows[0].Cells[5].Value.ToString();

            pictureBox_product.ImageLocation = product_picture;
            pictureBox_product.SizeMode = PictureBoxSizeMode.StretchImage;

            richTextBox_productDescription.AppendText(product_description);
        }

        private void dataGridView_product_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView_product.Columns[5].Visible = false;
            dataGridView_product.Columns[6].Visible = false;
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string id = dataGridView_product.Rows[0].Cells[0].Value.ToString();

            Form1 parent = (Form1)Owner;
            parent.rowClosed(id);
        }
    }
}