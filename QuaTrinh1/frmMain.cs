using DevExpress.XtraBars;
using QuaTrinh1.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuaTrinh1
{
	public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		public frmMain()
		{
			InitializeComponent();
		}


		private void frmMain_Load(object sender, EventArgs e)
		{

		}
		uc_Item ucItem;
		uc_Customer ucCustomer;
		uc_Order ucOrder;
		uc_Chart ucChart;
		uc_Revenue ucRevenue;
		private void accordionControlElement1_Click(object sender, EventArgs e)
		{
			if(ucItem == null)
			{
				ucItem= new uc_Item();
				ucItem.Dock= DockStyle.Fill;
				mainContainer.Controls.Add(ucItem);
				ucItem.BringToFront();
			}
			else
			{
				ucItem.BringToFront();
			}
			lblTitle.Caption = mnItem.Text;
		}

		private void mnCustomer_Click(object sender, EventArgs e)
		{
			if (ucCustomer == null)
			{
				ucCustomer = new uc_Customer();
				ucCustomer.Dock = DockStyle.Fill;
				mainContainer.Controls.Add(ucCustomer);
				ucCustomer.BringToFront();
			}
			else
			{
				ucCustomer.BringToFront();
			}
			lblTitle.Caption = mnCustomer.Text;
		}

		private void mnOrder_Click(object sender, EventArgs e)
		{
			if (ucOrder == null)
			{
				ucOrder = new uc_Order();
				ucOrder.Dock = DockStyle.Fill;
				mainContainer.Controls.Add(ucOrder);
				ucOrder.BringToFront();
			}
			else
			{
				ucOrder.BringToFront();
			}
			lblTitle.Caption = mnOrder.Text;
		}

		private void mnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void btnFilterItem_Click(object sender, EventArgs e)
        {
            if (ucChart == null)
            {
                ucChart = new uc_Chart();
                ucChart.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucChart);
                ucChart.BringToFront();
            }
            else
            {
                ucChart.BringToFront();
            }
            lblTitle.Caption = btnFilterItem.Text;
        }

        private void mnFilterRenenue_Click(object sender, EventArgs e)
        {
            if(ucRevenue == null)
            {
                ucRevenue = new uc_Revenue();
                ucRevenue.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucRevenue);
                ucRevenue.BringToFront();
            }
            else
            {
                ucRevenue.BringToFront();
            }
            lblTitle.Caption = mnFilterRenenue.Text;
        }
    }
}
