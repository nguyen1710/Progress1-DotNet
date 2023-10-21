using QuaTrinh1.Report;
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
	public partial class uc_Order : UserControl
	{
		SqlConnection conn = new SqlConnection(Program.connectionString);
		public static string orderID = "";
		public uc_Order()
		{
			InitializeComponent();
		}

		private void uc_Order_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		
		public void LoadData()
		{
			conn.Open();
			string query = "SELECT * FROM [Order]";
			SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

			DataSet dataSet = new DataSet();
			adapter.Fill(dataSet, "[Order]");

			gcList.DataSource = dataSet.Tables["[Order]"];
			conn.Close();
		}

		private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			AddOrder add = new AddOrder();
			add.ShowDialog();
		}

		private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			int[] selectedRows = gvList.GetSelectedRows();

			if (selectedRows.Length > 0)
			{

				// Lấy ItemID của hàng được chọn từ cột tương ứng
				orderID = gvList.GetRowCellValue(selectedRows[0], "OrderID").ToString();


				// Sau khi xóa item, làm mới GridView
				ReportCreator rp = new ReportCreator();
				rp.Show();
			}

		}

		private void groupControl1_Paint(object sender, PaintEventArgs e)
		{

		}

	
		private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			LoadData();
		}
	}
}
