using DevExpress.PivotGrid.QueryMode;
using DevExpress.Utils;
using DevExpress.Utils.Serializing.Helpers;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using QuaTrinh1.UI;
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

namespace QuaTrinh1
{
	public partial class AddOrder : DevExpress.XtraEditors.XtraForm
	{
		SqlConnection conn = new SqlConnection(Program.connectionString);

		DataTable dataTable = new DataTable();
		private static int total;


		public AddOrder()
		{
			InitializeComponent();
		}
        private void AddOrder_Load(object sender, EventArgs e)
        {
            LoadData();

            dataTable.Columns.Add("ItemID", typeof(string));
            dataTable.Columns.Add("ItemName", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Price", typeof(int));
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Item";
            // Tạo SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            // Tạo DataSet để lưu dữ liệu
            DataSet dataSet = new DataSet();

            // Đổ dữ liệu từ SqlDataAdapter vào DataSet
            adapter.Fill(dataSet, "Item");

            // Gán DataSet cho DataGridView
            gcList.DataSource = dataSet.Tables["Item"];
        }
        private void groupControl3_Paint(object sender, PaintEventArgs e)
		{

		}

		

		private void gvList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			string itemID = gvList.GetRowCellValue(e.RowHandle, "ItemID").ToString();
			string itemName = gvList.GetRowCellValue(e.RowHandle, "ItemName").ToString();
			int price = Convert.ToInt32(gvList.GetRowCellValue(e.RowHandle, "Price"));

			//size = gvAvailable.GetRowCellValue(e.RowHandle, "Size").ToString();

			// Gán giá trị vào TextBox
		}

		private void btnAddItem_Click(object sender, EventArgs e)
		{
			int[] selectedRows = gvList.GetSelectedRows();
			if (selectedRows.Length > 0)
			{
				string itemID = gvList.GetRowCellValue(selectedRows[0], "ItemID").ToString();
				string itemName = gvList.GetRowCellValue(selectedRows[0], "ItemName").ToString();
				int price = Convert.ToInt32(gvList.GetRowCellValue(selectedRows[0], "Price").ToString());

				int quantity = Convert.ToInt32(txtQuantity.Text);
				dataTable.Rows.Add(itemID, itemName, quantity, quantity * price);
				total += quantity * price;
				lbTotal.Text = "Total : " + total.ToString();
				gcSelected.DataSource = dataTable;
			}

		}

		private void btnBuy_Click(object sender, EventArgs e)
		{
			
			conn.Open();
			SqlCommand cmd = new SqlCommand("P_AddOrderAndGetID", conn); // Gọi stored procedure để xóa item
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@CustName", txtName.Text);
			cmd.Parameters.AddWithValue("@CustAddress", txtAddress.Text);
			cmd.ExecuteNonQuery();
			conn.Close();
			btnAccept.Enabled = true;
			
		}
		private void btnAccept_Click(object sender, EventArgs e)
		{
			bool success = true;
			foreach (DataRow row in dataTable.Rows)
			{
				string itemID = row["ItemID"].ToString();
				string itemName = row["ItemName"].ToString();
				int quantity = Convert.ToInt32(row["Quantity"]);
				string custName = txtName.Text;
				string custAddress = txtAddress.Text;

				conn.Open();
				SqlCommand command = new SqlCommand("P_AddOrderAndOrderDetail", conn); // Gọi stored procedure để xóa item
				command.CommandType = CommandType.StoredProcedure;

				command.Parameters.AddWithValue("@CustName", custName);
				command.Parameters.AddWithValue("@CustAddress", custAddress);
				command.Parameters.AddWithValue("@ItemID", itemID);
				command.Parameters.AddWithValue("@ItemName", itemName);
				command.Parameters.AddWithValue("@Quantity", quantity);

				try
				{
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					success = false; // Đánh dấu là không thêm thành công
									 // Xử lý lỗi nếu cần thiết, ví dụ: log lỗi ex.Message
				}
				finally
				{
					conn.Close();
				};


			}
			if (success)
			{
				MessageBox.Show("Tất cả bản ghi đã được thêm thành công.");
				
				
			}
			else
			{
				MessageBox.Show("Có lỗi xảy ra khi thêm một số bản ghi.");
			}
		}
	}
}