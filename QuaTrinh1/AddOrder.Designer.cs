namespace QuaTrinh1
{
	partial class AddOrder
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.gcList = new DevExpress.XtraGrid.GridControl();
			this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
			this.btnBuy = new DevExpress.XtraEditors.SimpleButton();
			this.txtAddress = new DevExpress.XtraEditors.TextEdit();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new DevExpress.XtraEditors.TextEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.gcItemSelected = new DevExpress.XtraEditors.GroupControl();
			this.gcSelected = new DevExpress.XtraGrid.GridControl();
			this.gvSelected = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
			this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
			this.label3 = new System.Windows.Forms.Label();
			this.lbTotal = new System.Windows.Forms.Label();
			this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
			this.groupControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcItemSelected)).BeginInit();
			this.gcItemSelected.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gcSelected)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvSelected)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.gcList);
			this.groupControl1.Location = new System.Drawing.Point(-1, -4);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(432, 629);
			this.groupControl1.TabIndex = 0;
			this.groupControl1.Text = "Available Item";
			// 
			// gcList
			// 
			this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcList.Location = new System.Drawing.Point(2, 23);
			this.gcList.MainView = this.gvList;
			this.gcList.Name = "gcList";
			this.gcList.Size = new System.Drawing.Size(428, 604);
			this.gcList.TabIndex = 6;
			this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
			// 
			// gvList
			// 
			this.gvList.GridControl = this.gcList;
			this.gvList.Name = "gvList";
			this.gvList.OptionsBehavior.Editable = false;
			this.gvList.OptionsView.ShowGroupPanel = false;
			// 
			// groupControl2
			// 
			this.groupControl2.Controls.Add(this.lbTotal);
			this.groupControl2.Controls.Add(this.btnBuy);
			this.groupControl2.Controls.Add(this.txtAddress);
			this.groupControl2.Controls.Add(this.label2);
			this.groupControl2.Controls.Add(this.txtName);
			this.groupControl2.Controls.Add(this.label1);
			this.groupControl2.Controls.Add(this.gcItemSelected);
			this.groupControl2.Location = new System.Drawing.Point(583, -4);
			this.groupControl2.Name = "groupControl2";
			this.groupControl2.Size = new System.Drawing.Size(570, 629);
			this.groupControl2.TabIndex = 1;
			this.groupControl2.Text = "Customer Infomation";
			// 
			// btnBuy
			// 
			this.btnBuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBuy.ImageOptions.SvgImage")));
			this.btnBuy.Location = new System.Drawing.Point(432, 115);
			this.btnBuy.Name = "btnBuy";
			this.btnBuy.Size = new System.Drawing.Size(133, 41);
			this.btnBuy.TabIndex = 5;
			this.btnBuy.Text = "Buy";
			this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(206, 82);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtAddress.Properties.Appearance.Options.UseFont = true;
			this.txtAddress.Size = new System.Drawing.Size(311, 22);
			this.txtAddress.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(96, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Address";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(206, 54);
			this.txtName.Name = "txtName";
			this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtName.Properties.Appearance.Options.UseFont = true;
			this.txtName.Size = new System.Drawing.Size(311, 22);
			this.txtName.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(96, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Custome Name";
			// 
			// gcItemSelected
			// 
			this.gcItemSelected.Controls.Add(this.gcSelected);
			this.gcItemSelected.Location = new System.Drawing.Point(0, 171);
			this.gcItemSelected.Name = "gcItemSelected";
			this.gcItemSelected.Size = new System.Drawing.Size(570, 458);
			this.gcItemSelected.TabIndex = 0;
			this.gcItemSelected.Text = "Item selected";
			this.gcItemSelected.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl3_Paint);
			// 
			// gcSelected
			// 
			this.gcSelected.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcSelected.Location = new System.Drawing.Point(2, 23);
			this.gcSelected.MainView = this.gvSelected;
			this.gcSelected.Name = "gcSelected";
			this.gcSelected.Size = new System.Drawing.Size(566, 433);
			this.gcSelected.TabIndex = 0;
			this.gcSelected.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSelected});
			// 
			// gvSelected
			// 
			this.gvSelected.GridControl = this.gcSelected;
			this.gvSelected.Name = "gvSelected";
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(458, 274);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(100, 20);
			this.txtQuantity.TabIndex = 2;
			// 
			// btnAddItem
			// 
			this.btnAddItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddItem.ImageOptions.SvgImage")));
			this.btnAddItem.Location = new System.Drawing.Point(469, 300);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(75, 39);
			this.btnAddItem.TabIndex = 3;
			this.btnAddItem.Text = "Add";
			this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(482, 258);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Quantity";
			// 
			// lbTotal
			// 
			this.lbTotal.AutoSize = true;
			this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotal.Location = new System.Drawing.Point(267, 127);
			this.lbTotal.Name = "lbTotal";
			this.lbTotal.Size = new System.Drawing.Size(48, 17);
			this.lbTotal.TabIndex = 8;
			this.lbTotal.Text = "Total: ";
			// 
			// btnAccept
			// 
			this.btnAccept.Enabled = false;
			this.btnAccept.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
			this.btnAccept.Location = new System.Drawing.Point(1015, 632);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(133, 41);
			this.btnAccept.TabIndex = 6;
			this.btnAccept.Text = "Accept";
			this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
			// 
			// AddOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1152, 685);
			this.Controls.Add(this.btnAccept);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnAddItem);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.groupControl2);
			this.Controls.Add(this.groupControl1);
			this.Name = "AddOrder";
			this.Text = "AddOrder";
			this.Load += new System.EventHandler(this.AddOrder_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
			this.groupControl2.ResumeLayout(false);
			this.groupControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcItemSelected)).EndInit();
			this.gcItemSelected.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gcSelected)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvSelected)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.GroupControl groupControl2;
		private DevExpress.XtraEditors.GroupControl gcItemSelected;
		private DevExpress.XtraEditors.TextEdit txtAddress;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.TextEdit txtName;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.TextEdit txtQuantity;
		private DevExpress.XtraEditors.SimpleButton btnAddItem;
		private System.Windows.Forms.Label label3;
		private DevExpress.XtraEditors.SimpleButton btnBuy;
		private DevExpress.XtraGrid.GridControl gcSelected;
		private DevExpress.XtraGrid.Views.Grid.GridView gvSelected;
		private DevExpress.XtraGrid.GridControl gcList;
		private DevExpress.XtraGrid.Views.Grid.GridView gvList;
		private System.Windows.Forms.Label lbTotal;
		private DevExpress.XtraEditors.SimpleButton btnAccept;
	}
}