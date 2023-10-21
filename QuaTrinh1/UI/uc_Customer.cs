using DevExpress.Utils;
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
	public partial class uc_Customer : UserControl
	{
		SqlConnection conn = new SqlConnection(Program.connectionString);
		public uc_Customer()
		{
			InitializeComponent();
		}

		private void uc_Customer_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData()
		{
			string query = "SELECT * FROM Customer";
			conn.Open();
			SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

			DataSet dataSet = new DataSet();
			adapter.Fill(dataSet, "Customer");

			gcList.DataSource = dataSet.Tables["Customer"];
			conn.Close();
		}

		private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			conn.Open();
			SqlCommand command = new SqlCommand("P_InsertCustomer", conn); // Gọi stored procedure để thêm customer mới
			command.CommandType = CommandType.StoredProcedure;

			// Chuyển giá trị từ TextBoxes hoặc các điều khiển khác vào tham số của stored procedure
			command.Parameters.AddWithValue("@CustName", txtName.Text);
			command.Parameters.AddWithValue("@Address", txtAddress.Text);

			command.ExecuteNonQuery();
			conn.Close();

			// Sau khi thêm item, làm mới DataGridView
			LoadData();
		}
        private void gvList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string itemName = gvList.GetRowCellValue(e.RowHandle, "CustName").ToString();
            string address = gvList.GetRowCellValue(e.RowHandle, "Address").ToString();

            // Gán giá trị vào TextBox
            txtName.Text = itemName;
            txtAddress.Text = address;
        }
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			string custID = gvList.GetRowCellValue(gvList.FocusedRowHandle, "CustID").ToString();
			string custName = txtName.Text;
			string address = txtAddress.Text;

			conn.Open();
			SqlCommand command = new SqlCommand("P_UpdateCustomer", conn); // Gọi stored procedure để cập nhật customer
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.AddWithValue("@CustID", custID);
			command.Parameters.AddWithValue("@CustName", custName);
			command.Parameters.AddWithValue("@Address", address);

			command.ExecuteNonQuery();
			conn.Close();
			LoadData();
		}

		private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			int[] selectedRows = gvList.GetSelectedRows();

			if (selectedRows.Length > 0)
			{

				// Lấy ItemID của hàng được chọn từ cột tương ứng
				string custID = gvList.GetRowCellValue(selectedRows[0], "CustID").ToString();

				conn.Open();
				SqlCommand command = new SqlCommand("P_DeleteCustomer", conn); 
				command.CommandType = CommandType.StoredProcedure;

				command.Parameters.AddWithValue("@CustID", custID); 

				command.ExecuteNonQuery();
				conn.Close();


				// Sau khi xóa item, làm mới GridView
				LoadData();
			}
		}
		private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Hide();
		}

		

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
			LoadData();
        }
    }
}
