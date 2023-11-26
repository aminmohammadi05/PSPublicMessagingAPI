namespace PSPublicMessagingAPI.Desktop.Views
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MessengerBar = new DevExpress.XtraBars.BarManager(this.components);
            this.mnuMainMenu = new DevExpress.XtraBars.Bar();
            this.mnuMessageActions = new DevExpress.XtraBars.BarSubItem();
            this.mnuCreateMessage = new DevExpress.XtraBars.BarButtonItem();
            this.mnuAllMessages = new DevExpress.XtraBars.BarButtonItem();
            this.mnuReadMessages = new DevExpress.XtraBars.BarButtonItem();
            this.mnuNewMessages = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExit = new DevExpress.XtraBars.BarButtonItem();
            this.mnuAbout = new DevExpress.XtraBars.BarButtonItem();
            this.btnSilent = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.mainContainer = new DevExpress.XtraEditors.SplitContainerControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.svgLogo = new DevExpress.XtraEditors.SvgImageBox();
            this.flpNotification = new System.Windows.Forms.FlowLayoutPanel();
            this.erpMain = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MessengerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer.Panel1)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer.Panel2)).BeginInit();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMain)).BeginInit();
            this.SuspendLayout();
            // 
            // MessengerBar
            // 
            this.MessengerBar.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.mnuMainMenu});
            this.MessengerBar.DockControls.Add(this.barDockControlTop);
            this.MessengerBar.DockControls.Add(this.barDockControlBottom);
            this.MessengerBar.DockControls.Add(this.barDockControlLeft);
            this.MessengerBar.DockControls.Add(this.barDockControlRight);
            this.MessengerBar.Form = this;
            this.MessengerBar.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuMessageActions,
            this.mnuAbout,
            this.mnuAllMessages,
            this.mnuReadMessages,
            this.mnuNewMessages,
            this.mnuExit,
            this.barButtonItem1,
            this.btnSilent,
            this.mnuCreateMessage});
            this.MessengerBar.MainMenu = this.mnuMainMenu;
            this.MessengerBar.MaxItemId = 16;
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.BarName = "جعبه ابزار";
            this.mnuMainMenu.DockCol = 0;
            this.mnuMainMenu.DockRow = 0;
            this.mnuMainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.mnuMainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuMessageActions),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuAbout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSilent)});
            this.mnuMainMenu.OptionsBar.AllowQuickCustomization = false;
            this.mnuMainMenu.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.mnuMainMenu.OptionsBar.DisableClose = true;
            this.mnuMainMenu.OptionsBar.DisableCustomization = true;
            this.mnuMainMenu.OptionsBar.DrawBorder = false;
            this.mnuMainMenu.OptionsBar.DrawDragBorder = false;
            this.mnuMainMenu.OptionsBar.MultiLine = true;
            this.mnuMainMenu.OptionsBar.UseWholeRow = true;
            this.mnuMainMenu.Text = "Custom 2";
            // 
            // mnuMessageActions
            // 
            this.mnuMessageActions.Caption = "پیامها";
            this.mnuMessageActions.Id = 7;
            this.mnuMessageActions.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuMessageActions.ImageOptions.Image")));
            this.mnuMessageActions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuMessageActions.ImageOptions.LargeImage")));
            this.mnuMessageActions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuCreateMessage),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuAllMessages),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuReadMessages),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuNewMessages),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExit)});
            this.mnuMessageActions.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText;
            this.mnuMessageActions.Name = "mnuMessageActions";
            this.mnuMessageActions.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // mnuCreateMessage
            // 
            this.mnuCreateMessage.Caption = "ایجاد پیام";
            this.mnuCreateMessage.Id = 15;
            this.mnuCreateMessage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuCreateMessage.ImageOptions.Image")));
            this.mnuCreateMessage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuCreateMessage.ImageOptions.LargeImage")));
            this.mnuCreateMessage.Name = "mnuCreateMessage";
            this.mnuCreateMessage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuCreateMessage_ItemClick);
            // 
            // mnuAllMessages
            // 
            this.mnuAllMessages.Caption = "همه پیامها";
            this.mnuAllMessages.Id = 9;
            this.mnuAllMessages.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuAllMessages.ImageOptions.Image")));
            this.mnuAllMessages.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuAllMessages.ImageOptions.LargeImage")));
            this.mnuAllMessages.Name = "mnuAllMessages";
            this.mnuAllMessages.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuAllMessages_ItemClick);
            // 
            // mnuReadMessages
            // 
            this.mnuReadMessages.Caption = "پیامهای خوانده شده";
            this.mnuReadMessages.Id = 10;
            this.mnuReadMessages.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuReadMessages.ImageOptions.Image")));
            this.mnuReadMessages.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuReadMessages.ImageOptions.LargeImage")));
            this.mnuReadMessages.Name = "mnuReadMessages";
            this.mnuReadMessages.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuReadMessages_ItemClick);
            // 
            // mnuNewMessages
            // 
            this.mnuNewMessages.Caption = "پیامهای جدید";
            this.mnuNewMessages.Id = 11;
            this.mnuNewMessages.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuNewMessages.ImageOptions.Image")));
            this.mnuNewMessages.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuNewMessages.ImageOptions.LargeImage")));
            this.mnuNewMessages.Name = "mnuNewMessages";
            this.mnuNewMessages.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuNewMessages_ItemClick);
            // 
            // mnuExit
            // 
            this.mnuExit.Caption = "خروج";
            this.mnuExit.Id = 12;
            this.mnuExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuExit.ImageOptions.Image")));
            this.mnuExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuExit.ImageOptions.LargeImage")));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExit_ItemClick);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Caption = "درباره این برنامه";
            this.mnuAbout.Id = 8;
            this.mnuAbout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuAbout.ImageOptions.Image")));
            this.mnuAbout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuAbout.ImageOptions.LargeImage")));
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.mnuAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuAbout_ItemClick);
            // 
            // btnSilent
            // 
            this.btnSilent.Caption = "حالت ساکت";
            this.btnSilent.Id = 14;
            this.btnSilent.Name = "btnSilent";
            this.btnSilent.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSilent_CheckedChanged);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.MessengerBar;
            this.barDockControlTop.Size = new System.Drawing.Size(368, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 790);
            this.barDockControlBottom.Manager = this.MessengerBar;
            this.barDockControlBottom.Size = new System.Drawing.Size(368, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.MessengerBar;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 766);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(368, 24);
            this.barDockControlRight.Manager = this.MessengerBar;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 766);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.mainContainer.Location = new System.Drawing.Point(0, 24);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.mainContainer.Panel1.Text = "Panel1";
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.flpNotification);
            this.mainContainer.Panel2.Text = "Panel2";
            this.mainContainer.Size = new System.Drawing.Size(368, 766);
            this.mainContainer.SplitterPosition = 380;
            this.mainContainer.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblUserName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUserName, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.svgLogo, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55557F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(92, -121);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "نام کاربری";
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Location = new System.Drawing.Point(-147, -118);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(233, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(-147, -91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 21);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(93, -94);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "کلمه عبور";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnLogin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-147, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(292, 45);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.Location = new System.Drawing.Point(149, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 39);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "ورود";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-146, -67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "برای ورود از نام کاربری و کلمه عبور ورود به ویندوز استفاده کنید";
            // 
            // svgLogo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.svgLogo, 2);
            this.svgLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.svgLogo.Location = new System.Drawing.Point(-147, -127);
            this.svgLogo.Name = "svgLogo";
            this.svgLogo.Size = new System.Drawing.Size(292, 1);
            this.svgLogo.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgLogo.TabIndex = 10;
            this.svgLogo.Text = "svgImageBox1";
            // 
            // flpNotification
            // 
            this.flpNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNotification.Location = new System.Drawing.Point(0, 0);
            this.flpNotification.Name = "flpNotification";
            this.flpNotification.Size = new System.Drawing.Size(358, 766);
            this.flpNotification.TabIndex = 0;
            // 
            // erpMain
            // 
            this.erpMain.ContainerControl = this;
            // 
            // MainWindow
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(368, 790);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MainWindow.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "پیام رسان پارس سویچ";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MessengerBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer.Panel1)).EndInit();
            this.mainContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer.Panel2)).EndInit();
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager MessengerBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar mnuMainMenu;
        private DevExpress.XtraBars.BarSubItem mnuMessageActions;
        private DevExpress.XtraBars.BarButtonItem mnuAbout;
        private DevExpress.XtraBars.BarButtonItem mnuAllMessages;
        private DevExpress.XtraBars.BarButtonItem mnuReadMessages;
        private DevExpress.XtraBars.BarButtonItem mnuNewMessages;
        private DevExpress.XtraBars.BarButtonItem mnuExit;
        private DevExpress.XtraEditors.SplitContainerControl mainContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider erpMain;
        private System.Windows.Forms.FlowLayoutPanel flpNotification;
        private DevExpress.XtraEditors.SvgImageBox svgLogo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarToggleSwitchItem btnSilent;
        private DevExpress.XtraBars.BarButtonItem mnuCreateMessage;
    }
}