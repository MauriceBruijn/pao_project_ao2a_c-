using System;

namespace pao_mml
{
    partial class ProductForm
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
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.pictureBox_product = new System.Windows.Forms.PictureBox();
            this.richTextBox_productDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_product.Location = new System.Drawing.Point(172, 12);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.RowTemplate.Height = 24;
            this.dataGridView_product.Size = new System.Drawing.Size(823, 83);
            this.dataGridView_product.TabIndex = 0;
            // 
            // pictureBox_product
            // 
            this.pictureBox_product.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_product.Name = "pictureBox_product";
            this.pictureBox_product.Size = new System.Drawing.Size(154, 165);
            this.pictureBox_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_product.TabIndex = 1;
            this.pictureBox_product.TabStop = false;
            // 
            // richTextBox_productDescription
            // 
            this.richTextBox_productDescription.Location = new System.Drawing.Point(172, 102);
            this.richTextBox_productDescription.Name = "richTextBox_productDescription";
            this.richTextBox_productDescription.Size = new System.Drawing.Size(660, 75);
            this.richTextBox_productDescription.TabIndex = 2;
            this.richTextBox_productDescription.Text = "";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1007, 201);
            this.Controls.Add(this.richTextBox_productDescription);
            this.Controls.Add(this.pictureBox_product);
            this.Controls.Add(this.dataGridView_product);
            this.Name = "ProductForm";
            this.Text = "PRODUCT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).EndInit();
            this.ResumeLayout(false);

        }

        internal void Product()
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_product;
        private System.Windows.Forms.PictureBox pictureBox_product;
        private System.Windows.Forms.RichTextBox richTextBox_productDescription;
    }
}