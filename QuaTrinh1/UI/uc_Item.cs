using DevExpress.Xpo.DB.Helpers;
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
	public partial class uc_Item : UserControl
	{
		SqlConnection conn = new SqlConnection(Program.connectionString);
		public uc_Item()
		{
			InitializeComponent();
		}

		private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			int[] selectedRows = gvList.GetSelectedRows();

			if (selectedRows.Length > 0)
			{

				// Lấy ItemID của hàng được chọn từ cột tương ứng
				string itemID = gvList.GetRowCellValue(selectedRows[0], "ItemID").ToString();

				conn.Open();
				SqlCommand command = new SqlCommand("P_DeleteItem", conn); // Gọi stored procedure để xóa item
				command.CommandType = CommandType.StoredProcedure;

				command.Parameters.AddWithValue("@ItemID", itemID); // Chuyển ItemID cần xóa vào tham số

				command.ExecuteNonQuery();
				conn.Close();


				// Sau khi xóa item, làm mới GridView
				LoadData();
			}
		}

		private void gcList_Click(object sender, EventArgs e)
		{

		}

		private void uc_Item_Load(object sender, EventArgs e)
		{
			LoadData();
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

		private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

				conn.Open();
				SqlCommand command = new SqlCommand("P_InsertItem", conn); // Gọi stored procedure để thêm item mới
				command.CommandType = CommandType.StoredProcedure;

				// Chuyển giá trị từ TextBoxes hoặc các điều khiển khác vào tham số của stored procedure
				command.Parameters.AddWithValue("@ItemName", txtName.Text);
				command.Parameters.AddWithValue("@Price", Convert.ToInt32(txtPrice.Text));
				command.Parameters.AddWithValue("@Size", Convert.ToInt32(txtSize.Text));

				command.ExecuteNonQuery();
				conn.Close();

			// Sau khi thêm item, làm mới DataGridView
			LoadData();
		}

		private void gcList_Click_1(object sender, EventArgs e)
		{

		}

		private void gvList_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			string itemName = gvList.GetRowCellValue(e.RowHandle, "ItemName").ToString();
			string price = gvList.GetRowCellValue(e.RowHandle, "Price").ToString();
			string size = gvList.GetRowCellValue(e.RowHandle, "Size").ToString();

			// Gán giá trị vào TextBox
			txtName.Text = itemName;
			txtPrice.Text = price;
			txtSize.Text = size;
		}

		private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			string itemID = gvList.GetRowCellValue(gvList.FocusedRowHandle, "ItemID").ToString();
			string itemName = txtName.Text;
			int price = int.Parse(txtPrice.Text);
			int size = int.Parse(txtSize.Text);

			conn.Open();
			SqlCommand command = new SqlCommand("P_UpdateItem", conn); // Gọi stored procedure để cập nhật item
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.AddWithValue("@ItemID", itemID);
			command.Parameters.AddWithValue("@ItemName", itemName);
			command.Parameters.AddWithValue("@Price", price);
			command.Parameters.AddWithValue("@Size", size);

			command.ExecuteNonQuery();
			conn.Close();
			LoadData();
		}
	}
}
