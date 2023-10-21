using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QuaTrinh1
{
	public partial class frmLogin : DevExpress.XtraEditors.XtraForm
	{
		
		SqlConnection conn = new SqlConnection(Program.connectionString);

		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			
			conn.Open();

			string query = "SELECT * FROM AdminAccount WHERE UserName = @Username and UserPwd = @Userpwd";
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
			cmd.Parameters.AddWithValue("@Userpwd", txtPwd.Text);
			SqlDataReader reader = cmd.ExecuteReader();
			if(reader.HasRows)
			{
				MessageBox.Show("Login successful!!!");
				frmMain f = new frmMain();
				f.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Invalid user name or password");
			}
			conn.Close();


		}

		private void frmLogin_Load(object sender, EventArgs e)
		{

		}
	}
}