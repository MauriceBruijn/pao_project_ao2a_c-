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
        public Form1()
        {
            InitializeComponent();

            getApi();
        }

        public void getApi()
        {
            using (var webClient = new WebClient())
            {
                var json = webClient.DownloadString("https://mauricebruijn.nl/api/products/");

                richTextBox_products.Text = json;
            }
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            string json = richTextBox_products.Text;
            
            var deserialize = JsonConvert.DeserializeObject(json);

            dataGridView_products.DataSource = deserialize;
        }
    }
}
