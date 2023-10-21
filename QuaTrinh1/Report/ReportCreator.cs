using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
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

using System.IO;
using Xceed.Words.NET;
using Xceed.Document.NET;

namespace QuaTrinh1.Report
{
	public partial class ReportCreator : DevExpress.XtraEditors.XtraForm
	{
		SqlConnection conn = new SqlConnection(Program.connectionString);

		public ReportCreator()
		{
			InitializeComponent();
		}

		private void ReportCreator_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData()
		{

			// Lấy ItemID của hàng được chọn từ cột tương ứng

			conn.Open();
			SqlCommand command = new SqlCommand("P_GetReport", conn);
			command.CommandType = CommandType.StoredProcedure;

			command.Parameters.AddWithValue("@OrderID", uc_Order.orderID);

			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();

			adapter.Fill(dataTable);
			gcList.DataSource = dataTable;
			// Sau khi xóa item, làm mới GridView


		}

		private void gcList_Click(object sender, EventArgs e)
		{

		}

		private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			using (DocX doc = DocX.Create(Application.StartupPath + @"\Report.docx"))
			{
				doc.InsertParagraph("BÁO CÁO ĐƠN HÀNG").FontSize(16).Bold().Alignment = Xceed.Document.NET.Alignment.center;

				DataTable dataTable = (DataTable)gcList.DataSource;
				Table table = doc.AddTable(dataTable.Rows.Count + 1, dataTable.Columns.Count);
				table.Design = TableDesign.TableGrid;

				for (int row = 0; row <= dataTable.Rows.Count; row++)
				{
					for (int column = 0; column < dataTable.Columns.Count; column++)
					{
						if (row == 0)
						{
							table.Rows[row].Cells[column].Paragraphs.First().Append(dataTable.Columns[column].ColumnName).Bold();
						}
						else
						{
							table.Rows[row].Cells[column].Paragraphs.First().Append(dataTable.Rows[row - 1][column].ToString());
						}
					}
				}

				//Total money
				int totalAll = 0;
				foreach (DataRow row in dataTable.Rows)
				{
					int price = (int)row["Price"];
					int quantity = (int)row["Quantity"];

					// Tính tổng tiền cho dòng hiện tại và cộng vào tổng tiền
					int lineTotal = price * quantity;
					totalAll += lineTotal;
				}

				doc.InsertTable(table);

				doc.InsertParagraph("Tổng giá tiền: " + totalAll).FontSize(14).Bold();

				// Lưu tài liệu DOCX
				doc.Save();
			}
		}
	}
}