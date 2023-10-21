namespace QuaTrinh1.UI
{
	partial class uc_Item
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Item));
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
			this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
			this.btnExit = new DevExpress.XtraBars.BarButtonItem();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
			this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
			this.txtSize = new DevExpress.XtraEditors.TextEdit();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrice = new DevExpress.XtraEditors.TextEdit();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new DevExpress.XtraEditors.TextEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.gcList = new DevExpress.XtraGrid.GridControl();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
			this.sidePanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
			this.SuspendLayout();
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnEdit,
            this.btnDelete,
            this.btnExit,
            this.barDockingMenuItem1,
            this.barEditItem1});
			this.barManager1.MaxItemId = 6;
			this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
			this.barManager1.StatusBar = this.bar3;
			// 
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 1;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.bar1.Text = "Tools";
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "Add";
			this.barButtonItem1.Id = 0;
			this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
			this.barButtonItem1.Name = "barButtonItem1";
			this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
			// 
			// btnEdit
			// 
			this.btnEdit.Caption = "Edit";
			this.btnEdit.Id = 1;
			this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Caption = "Delete";
			this.btnDelete.Id = 2;
			this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
			// 
			// btnExit
			// 
			this.btnExit.Caption = "Exit";
			this.btnExit.Id = 3;
			this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
			this.btnExit.Name = "btnExit";
			// 
			// bar3
			// 
			this.bar3.BarName = "Status bar";
			this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 0;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar3.OptionsBar.AllowQuickCustomization = false;
			this.bar3.OptionsBar.DrawDragBorder = false;
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Status bar";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(856, 24);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 513);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(856, 20);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 489);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(856, 24);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 489);
			// 
			// barDockingMenuItem1
			// 
			this.barDockingMenuItem1.Caption = "barDockingMenuItem1";
			this.barDockingMenuItem1.Id = 4;
			this.barDockingMenuItem1.Name = "barDockingMenuItem1";
			// 
			// barEditItem1
			// 
			this.barEditItem1.Caption = "barEditItem1";
			this.barEditItem1.Edit = this.repositoryItemTextEdit1;
			this.barEditItem1.Id = 5;
			this.barEditItem1.Name = "barEditItem1";
			// 
			// repositoryItemTextEdit1
			// 
			this.repositoryItemTextEdit1.AutoHeight = false;
			this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
			// 
			// sidePanel1
			// 
			this.sidePanel1.Controls.Add(this.txtSize);
			this.sidePanel1.Controls.Add(this.label3);
			this.sidePanel1.Controls.Add(this.txtPrice);
			this.sidePanel1.Controls.Add(this.label2);
			this.sidePanel1.Controls.Add(this.txtName);
			this.sidePanel1.Controls.Add(this.label1);
			this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.sidePanel1.Location = new System.Drawing.Point(0, 24);
			this.sidePanel1.Name = "sidePanel1";
			this.sidePanel1.Size = new System.Drawing.Size(856, 113);
			this.sidePanel1.TabIndex = 10;
			this.sidePanel1.Text = "sidePanel1";
			// 
			// txtSize
			// 
			this.txtSize.Location = new System.Drawing.Point(321, 73);
			this.txtSize.MenuManager = this.barManager1;
			this.txtSize.Name = "txtSize";
			this.txtSize.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtSize.Properties.Appearance.Options.UseFont = true;
			this.txtSize.Size = new System.Drawing.Size(157, 22);
			this.txtSize.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(244, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Size";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(321, 45);
			this.txtPrice.MenuManager = this.barManager1;
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtPrice.Properties.Appearance.Options.UseFont = true;
			this.txtPrice.Size = new System.Drawing.Size(311, 22);
			this.txtPrice.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(244, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Price";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(321, 17);
			this.txtName.MenuManager = this.barManager1;
			this.txtName.Name = "txtName";
			this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.txtName.Properties.Appearance.Options.UseFont = true;
			this.txtName.Size = new System.Drawing.Size(311, 22);
			this.txtName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(244, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "ItemName";
			// 
			// gcList
			// 
			this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gcList.Location = new System.Drawing.Point(2, 23);
			this.gcList.MainView = this.gvList;
			this.gcList.MenuManager = this.barManager1;
			this.gcList.Name = "gcList";
			this.gcList.Size = new System.Drawing.Size(852, 351);
			this.gcList.TabIndex = 5;
			this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
			this.gcList.Click += new System.EventHandler(this.gcList_Click_1);
			// 
			// groupControl1
			// 
			this.groupControl1.AutoSize = true;
			this.groupControl1.Controls.Add(this.gcList);
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl1.Location = new System.Drawing.Point(0, 137);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(856, 376);
			this.groupControl1.TabIndex = 11;
			this.groupControl1.Text = "DATA";
			// 
			// gvList
			// 
			this.gvList.GridControl = this.gcList;
			this.gvList.Name = "gvList";
			this.gvList.OptionsBehavior.Editable = false;
			this.gvList.OptionsView.ShowGroupPanel = false;
			this.gvList.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvList_RowClick_1);
			// 
			// uc_Item
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.sidePanel1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "uc_Item";
			this.Size = new System.Drawing.Size(856, 533);
			this.Load += new System.EventHandler(this.uc_Item_Load);
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
			this.sidePanel1.ResumeLayout(false);
			this.sidePanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem btnEdit;
		private DevExpress.XtraBars.BarButtonItem btnDelete;
		private DevExpress.XtraBars.BarButtonItem btnExit;
		private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraGrid.GridControl gcList;
		private DevExpress.XtraEditors.SidePanel sidePanel1;
		private DevExpress.XtraEditors.TextEdit txtSize;
		private System.Windows.Forms.Label label3;
		private DevExpress.XtraEditors.TextEdit txtPrice;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.TextEdit txtName;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraBars.BarEditItem barEditItem1;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
		private DevExpress.XtraGrid.Views.Grid.GridView gvList;
	}
}
