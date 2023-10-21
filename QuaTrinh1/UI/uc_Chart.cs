﻿using DevExpress.XtraCharts;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuaTrinh1.UI
{
    public partial class uc_Chart : UserControl
    {
        SqlConnection conn = new SqlConnection(Program.connectionString);

        public uc_Chart()
        {
            InitializeComponent();
        }

        private void uc_Chart_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("P_GetTotalQuantitySold", conn);
            command.CommandType = CommandType.StoredProcedure;
            DataTable dataTable= new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("Sản Phẩm", ViewType.Bar);

            chartControl1.Series.Add(series);

            foreach (DataRow row in dataTable.Rows)
            {
                string itemName = row["ItemName"].ToString();
                int quantitySold = Convert.ToInt32(row["TotalQuantitySold"]);

                series.Points.Add(new SeriesPoint(itemName, quantitySold));
            }
            conn.Close();

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
