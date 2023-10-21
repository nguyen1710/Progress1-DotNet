namespace QuaTrinh1
{
	partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mnCategory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnOrder = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnExit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnFilterItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lblTitle = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.mnFilterRenenue = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.label2);
            this.mainContainer.Controls.Add(this.label1);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(260, 31);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(973, 642);
            this.mainContainer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(195, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(609, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "521H0468 - Nguyễn Thanh Nguyên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(163, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Window Appication Progress 1 Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnCategory,
            this.accordionControlElement2,
            this.accordionControlElement1,
            this.accordionControlElement6});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 642);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // mnCategory
            // 
            this.mnCategory.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnItem,
            this.mnCustomer});
            this.mnCategory.Expanded = true;
            this.mnCategory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("mnCategory.ImageOptions.SvgImage")));
            this.mnCategory.Name = "mnCategory";
            this.mnCategory.Text = "CATEGORY";
            // 
            // mnItem
            // 
            this.mnItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnItem.ImageOptions.Image")));
            this.mnItem.Name = "mnItem";
            this.mnItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnItem.Text = "ITEM";
            this.mnItem.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // mnCustomer
            // 
            this.mnCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnCustomer.ImageOptions.Image")));
            this.mnCustomer.Name = "mnCustomer";
            this.mnCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnCustomer.Text = "CUSTOMER";
            this.mnCustomer.Click += new System.EventHandler(this.mnCustomer_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnOrder});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement2.ImageOptions.SvgImage")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "ODER";
            // 
            // mnOrder
            // 
            this.mnOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnOrder.ImageOptions.Image")));
            this.mnOrder.Name = "mnOrder";
            this.mnOrder.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnOrder.Text = "LIST OF INVOICES";
            this.mnOrder.Click += new System.EventHandler(this.mnOrder_Click);
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnExit});
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement6.ImageOptions.SvgImage")));
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "SYSTEM";
            // 
            // mnExit
            // 
            this.mnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnExit.ImageOptions.Image")));
            this.mnExit.Name = "mnExit";
            this.mnExit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnExit.Text = "EXIT";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnFilterItem,
            this.mnFilterRenenue});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement1.ImageOptions.SvgImage")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "STATISTICAL";
            // 
            // btnFilterItem
            // 
            this.btnFilterItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterItem.ImageOptions.Image")));
            this.btnFilterItem.Name = "btnFilterItem";
            this.btnFilterItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnFilterItem.Text = "QUANTITY OF ITEM WAS SOLD";
            this.btnFilterItem.Click += new System.EventHandler(this.btnFilterItem_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblTitle});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1233, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblTitle);
            // 
            // lblTitle
            // 
            this.lblTitle.Caption = "Window Application Project QT1";
            this.lblTitle.Id = 0;
            this.lblTitle.ItemAppearance.Disabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.ItemAppearance.Disabled.Options.UseForeColor = true;
            this.lblTitle.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblTitle.Name = "lblTitle";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblTitle});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // mnFilterRenenue
            // 
            this.mnFilterRenenue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnFilterRenenue.ImageOptions.Image")));
            this.mnFilterRenenue.Name = "mnFilterRenenue";
            this.mnFilterRenenue.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnFilterRenenue.Text = "RENENUE OF ITEM SOLD";
            this.mnFilterRenenue.Click += new System.EventHandler(this.mnFilterRenenue_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 673);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
		private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement mnCategory;
		private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
		private DevExpress.XtraBars.Navigation.AccordionControlElement mnOrder;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
		private DevExpress.XtraBars.Navigation.AccordionControlElement mnExit;
		private DevExpress.XtraBars.Navigation.AccordionControlElement mnItem;
		private DevExpress.XtraBars.Navigation.AccordionControlElement mnCustomer;
		private DevExpress.XtraBars.BarStaticItem lblTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnFilterItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnFilterRenenue;
    }
}