namespace MegaDesk_4_DuridAhmad
{
    partial class SearchQuotes
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
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.materialSearch = new System.Windows.Forms.ComboBox();
            this.searchGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(144, 385);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(187, 53);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Material: ";
            // 
            // materialSearch
            // 
            this.materialSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialSearch.FormattingEnabled = true;
            this.materialSearch.Location = new System.Drawing.Point(203, 30);
            this.materialSearch.Name = "materialSearch";
            this.materialSearch.Size = new System.Drawing.Size(121, 32);
            this.materialSearch.TabIndex = 3;
            this.materialSearch.SelectedValueChanged += new System.EventHandler(this.materialSearch_SelectedValueChanged);
            // 
            // searchGrid
            // 
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGrid.Location = new System.Drawing.Point(12, 68);
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.RowTemplate.Height = 31;
            this.searchGrid.Size = new System.Drawing.Size(776, 311);
            this.searchGrid.TabIndex = 4;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchGrid);
            this.Controls.Add(this.materialSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox materialSearch;
        private System.Windows.Forms.DataGridView searchGrid;
    }
}