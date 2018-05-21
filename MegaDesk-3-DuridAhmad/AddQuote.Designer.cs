namespace MegaDesk_4_DuridAhmad
{
    partial class AddQuote
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.depth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.ComboBox();
            this.order = new System.Windows.Forms.ComboBox();
            this.labek = new System.Windows.Forms.Label();
            this.drawers = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawers)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(54, 483);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(158, 42);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drawers);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labek);
            this.groupBox1.Controls.Add(this.order);
            this.groupBox1.Controls.Add(this.material);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.depth);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Quote";
            // 
            // depth
            // 
            this.depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth.Location = new System.Drawing.Point(293, 123);
            this.depth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(120, 29);
            this.depth.TabIndex = 5;
            this.depth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depth.ValueChanged += new System.EventHandler(this.depth_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(293, 78);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(293, 34);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(117, 29);
            this.nameBox.TabIndex = 3;
            this.nameBox.TextChanged += new System.EventHandler(this.insert_name);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Depth (min 12\"; max 48\"):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width (min 24\"; max 96\"):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Surface Material:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // material
            // 
            this.material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.material.FormattingEnabled = true;
            this.material.Location = new System.Drawing.Point(296, 222);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(117, 32);
            this.material.TabIndex = 7;
            this.material.SelectedValueChanged += new System.EventHandler(this.material_SelectedValueChanged);
            // 
            // order
            // 
            this.order.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.order.FormattingEnabled = true;
            this.order.Location = new System.Drawing.Point(296, 271);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(117, 32);
            this.order.TabIndex = 8;
            this.order.SelectedValueChanged += new System.EventHandler(this.order_SelectedValueChanged);
            // 
            // labek
            // 
            this.labek.AutoSize = true;
            this.labek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labek.Location = new System.Drawing.Point(45, 271);
            this.labek.Name = "labek";
            this.labek.Size = new System.Drawing.Size(160, 24);
            this.labek.TabIndex = 9;
            this.labek.Text = "Order type (days):";
            // 
            // drawers
            // 
            this.drawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawers.Location = new System.Drawing.Point(296, 172);
            this.drawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(120, 29);
            this.drawers.TabIndex = 11;
            this.drawers.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawers.ValueChanged += new System.EventHandler(this.drawers_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "# of Drawers (0-7):";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(358, 422);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(44, 25);
            this.result.TabIndex = 3;
            this.result.Text = "---$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Price:";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 555);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancel);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown depth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox material;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox order;
        private System.Windows.Forms.Label labek;
        private System.Windows.Forms.NumericUpDown drawers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label6;
    }
}