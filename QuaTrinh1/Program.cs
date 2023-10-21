﻿using QuaTrinh1;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuaTrinh1
{
	internal static class Program
	{
		public static string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]

		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmLogin());
		}
	}
}
