using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pao_mml
{
    public partial class Form1 : Form
    {
        ProductList p = new ProductList();

        public Form1()
        {
            InitializeComponent();

            getApi();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getApi();
        }

        public void getApi()
        {
            using (var webClient = new WebClient())
            {
                var Products = webClient.DownloadString("https://mauricebruijn.nl/api/products/");

                p.Products = JsonConvert.DeserializeObject<BindingList<Product>>(Products);

                dataGridView_products.DataSource = p.Products;
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string text = tbxSearch.Text;

            var result = from x in p.Products
                where
                    x.name.Contains(text) ||
                    x.brand.Contains(text) ||
                    x.color.Contains(text) ||
                    x.price.Contains(text)
                select x;

            dataGridView_products.DataSource = result.ToList<Product>();
        }

        private void dataGridView_products_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView_products.CurrentCell.RowIndex;
            var result = dataGridView_products.Rows[rowindex].Cells[0].Value.ToString();

            dataGridView_products.Rows[rowindex].Cells[0].Style.BackColor = Color.Aqua;
            dataGridView_products.Rows[rowindex].Cells[1].Style.BackColor = Color.Aqua;
            dataGridView_products.Rows[rowindex].Cells[2].Style.BackColor = Color.Aqua;
            dataGridView_products.Rows[rowindex].Cells[3].Style.BackColor = Color.Aqua;
            dataGridView_products.Rows[rowindex].Cells[4].Style.BackColor = Color.Aqua;

            ProductForm product_form = new ProductForm(p);
            product_form.Show(this);
            product_form.Product(result);
        }

        public void rowClosed(string id)
        {
           int abc =  int.Parse(id) - 1;

            dataGridView_products.Rows[abc].Cells[0].Style.BackColor = Color.White;
            dataGridView_products.Rows[abc].Cells[1].Style.BackColor = Color.White;
            dataGridView_products.Rows[abc].Cells[2].Style.BackColor = Color.White;
            dataGridView_products.Rows[abc].Cells[3].Style.BackColor = Color.White;
            dataGridView_products.Rows[abc].Cells[4].Style.BackColor = Color.White;

            dataGridView_products.Refresh();
        }

        private void dataGridView_products_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView_products.Columns[5].Visible = false;
            dataGridView_products.Columns[6].Visible = false;
        }
    }
}