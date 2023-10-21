namespace QuaTrinh1
{
	partial class frmLogin
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsername = new DevExpress.XtraEditors.TextEdit();
			this.txtPwd = new DevExpress.XtraEditors.TextEdit();
			this.label2 = new System.Windows.Forms.Label();
			this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(192, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(316, 159);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtUsername.Properties.Appearance.Options.UseFont = true;
			this.txtUsername.Size = new System.Drawing.Size(321, 26);
			this.txtUsername.TabIndex = 1;
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(316, 223);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.txtPwd.Properties.Appearance.Options.UseFont = true;
			this.txtPwd.Size = new System.Drawing.Size(321, 26);
			this.txtPwd.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(192, 224);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F);
			this.btnCancel.Location = new System.Drawing.Point(338, 278);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 42);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Tahoma", 12F);
			this.btnLogin.Location = new System.Drawing.Point(474, 278);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(120, 42);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
			this.BackgroundImageStore = global::QuaTrinh1.Properties.Resources.backgroundLogin;
			this.ClientSize = new System.Drawing.Size(1022, 478);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label1);
			this.Name = "frmLogin";
			this.Text = "XtraForm1";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.TextEdit txtUsername;
		private DevExpress.XtraEditors.TextEdit txtPwd;
		private System.Windows.Forms.Label label2;
		private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnLogin;
	}
}