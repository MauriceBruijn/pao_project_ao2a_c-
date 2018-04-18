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
        ProductList p = new ProductList();

        public ProductForm()
        {
            InitializeComponent();
        }

        public void Product(string result)
        {
            //p.Products();
            richTextBox1.AppendText(result);
        }
    }
}