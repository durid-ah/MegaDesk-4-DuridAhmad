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
    
    public partial class SearchQuotes : Form
    {
        string search;

        public SearchQuotes()
        {
            InitializeComponent();
            materialSearch.DataSource = Enum.GetValues(typeof(SurfaceType));
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void materialSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            SurfaceType searchType;
            Enum.TryParse<SurfaceType>(materialSearch.SelectedValue.ToString(), out searchType);
            search = searchType.ToString();
            string file = @"C:\Users\ahmad\source\repos\MegaDesk-4-DuridAhmad\MegaDesk-3-DuridAhmad\quotes.csv";
            searchGrid.DataSource = readCSV(file);

        }

        public DataView readCSV(string filePath)
        {
            TextReader readFile = new StreamReader(filePath);
            var csv = new CsvReader(readFile);
            var records = csv.GetRecords<QuoteData>();
            DataTable table = new DataTable();


            //Setting up the column, row and view
            DataColumn column;
            DataRow row;
            DataView view;

            //Creating individual columns
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Name";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Width";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Depth";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Drawers";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Material";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Order";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "Date";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Total";
            table.Columns.Add(column);

            foreach (var record in records)
            {
                if (record.Material == search)
                {
                    row = table.NewRow();
                    row["Name"] = record.Name;
                    row["Width"] = record.Width;
                    row["Depth"] = record.Depth;
                    row["Drawers"] = record.Drawers;
                    row["Material"] = record.Material;
                    row["Order"] = record.Order;
                    row["Date"] = record.Date;
                    row["Total"] = record.Total + "$";
                    table.Rows.Add(row);
                }
            }

            view = new DataView(table);
            readFile.Close();
            return view;
        }
    }
}
