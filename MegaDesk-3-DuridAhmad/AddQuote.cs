using CsvHelper;
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

namespace MegaDesk_4_DuridAhmad
{
    public partial class AddQuote : Form
    {
        //Creating a new desk quote
        DeskQuote newQuote = new DeskQuote();

        public AddQuote()
        {
            InitializeComponent();

            //Getting the information from the enums and putting them in
            //the respective comboBox
            material.DataSource = Enum.GetValues(typeof(SurfaceType));
            order.DataSource = Enum.GetValues(typeof(OrderType));


        }

        private void cancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void insert_name(object sender, EventArgs e)
        {
            try
            {
                newQuote.Desk.OwnerName = nameBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Width
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            newQuote.Desk.Width = (float)numericUpDown1.Value;
            float price = newQuote.calculateTotal();
            result.Text = price.ToString() + "$";
        }

        //Depth
        private void depth_ValueChanged(object sender, EventArgs e)
        {
            newQuote.Desk.Depth = (float)depth.Value;
            float price = newQuote.calculateTotal();
            result.Text = price.ToString() + "$";
        }

        private void drawers_ValueChanged(object sender, EventArgs e)
        {
            newQuote.Desk.DrawerNum = (int)drawers.Value;
            float price = newQuote.calculateTotal();
            result.Text = price.ToString() + "$";
        }

        private void material_SelectedValueChanged(object sender, EventArgs e)
        {
            SurfaceType mtype;
            Enum.TryParse<SurfaceType>(material.SelectedValue.ToString(), out mtype);
            newQuote.Desk.Type = mtype;
            float price = newQuote.calculateTotal();
            result.Text = price.ToString() + "$";
        }

        private void order_SelectedValueChanged(object sender, EventArgs e)
        {
            OrderType otype;
            Enum.TryParse<OrderType>(order.SelectedValue.ToString(), out otype);
            newQuote.Type = otype;
            float price = newQuote.calculateTotal();
            result.Text = price.ToString() + "$";
        }

        private void saveFile()
        {
            string file = @"C:\Users\ahmad\source\repos\MegaDesk-4-DuridAhmad\MegaDesk-3-DuridAhmad\quotes.csv";
            string quote = newQuote.Desk.OwnerName + "," +
                newQuote.Desk.Width + "," +
                newQuote.Desk.Depth + "," +
                newQuote.Desk.DrawerNum + "," +
                newQuote.Desk.Type + "," +
                newQuote.Type + "," +
                newQuote.CurrentTime + "," +
                newQuote.calculateTotal() +
                Environment.NewLine;
            File.AppendAllText(file, quote);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newQuote.CurrentTime = DateTime.Now;
            saveFile();
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }







        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
