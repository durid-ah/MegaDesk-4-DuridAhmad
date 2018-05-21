namespace MegaDesk_4_DuridAhmad
{
    partial class ViewAllQuotes
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
            this.components = new System.ComponentModel.Container();
            this.cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quoteDataBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.quoteDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quoteDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deskQuoteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deskQuoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteDataBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(153, 385);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(187, 53);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(776, 367);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // quoteDataBindingSource2
            // 
            this.quoteDataBindingSource2.DataSource = typeof(MegaDesk_4_DuridAhmad.QuoteData);
            // 
            // quoteDataBindingSource
            // 
            this.quoteDataBindingSource.DataSource = typeof(MegaDesk_4_DuridAhmad.QuoteData);
            // 
            // quoteDataBindingSource1
            // 
            this.quoteDataBindingSource1.DataSource = typeof(MegaDesk_4_DuridAhmad.QuoteData);
            // 
            // deskQuoteBindingSource1
            // 
            this.deskQuoteBindingSource1.DataSource = typeof(MegaDesk_4_DuridAhmad.DeskQuote);
            // 
            // deskQuoteBindingSource
            // 
            this.deskQuoteBindingSource.DataSource = typeof(MegaDesk_4_DuridAhmad.DeskQuote);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cancel);
            this.Name = "ViewAllQuotes";
            this.Text = "View Quotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteDataBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quoteDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource deskQuoteBindingSource;
        private System.Windows.Forms.BindingSource deskQuoteBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource quoteDataBindingSource;
        private System.Windows.Forms.BindingSource quoteDataBindingSource1;
        private System.Windows.Forms.BindingSource quoteDataBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}