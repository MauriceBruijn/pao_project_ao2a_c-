namespace pao_mml
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.richTextBox_products = new System.Windows.Forms.RichTextBox();
            this.button_convert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_products.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_products.Location = new System.Drawing.Point(9, 10);
            this.dataGridView_products.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.ReadOnly = true;
            this.dataGridView_products.RowTemplate.Height = 24;
            this.dataGridView_products.Size = new System.Drawing.Size(733, 310);
            this.dataGridView_products.TabIndex = 1;
            // 
            // richTextBox_products
            // 
            this.richTextBox_products.Location = new System.Drawing.Point(746, 10);
            this.richTextBox_products.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox_products.Name = "richTextBox_products";
            this.richTextBox_products.Size = new System.Drawing.Size(270, 270);
            this.richTextBox_products.TabIndex = 2;
            this.richTextBox_products.Text = "";
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(746, 284);
            this.button_convert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(269, 37);
            this.button_convert.TabIndex = 3;
            this.button_convert.Text = "CONVERT";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 350);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.richTextBox_products);
            this.Controls.Add(this.dataGridView_products);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_products;
        private System.Windows.Forms.RichTextBox richTextBox_products;
        private System.Windows.Forms.Button button_convert;
    }
}

