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
            components = new System.ComponentModel.Container();
            MessengerBar = new DevExpress.XtraBars.BarManager(components);
            mnuMainMenu = new DevExpress.XtraBars.Bar();
            mnuMessageActions = new DevExpress.XtraBars.BarSubItem();
            mnuCreateMessage = new DevExpress.XtraBars.BarButtonItem();
            mnuAllMessages = new DevExpress.XtraBars.BarButtonItem();
            mnuReadMessages = new DevExpress.XtraBars.BarButtonItem();
            mnuNewMessages = new DevExpress.XtraBars.BarButtonItem();
            mnuExit = new DevExpress.XtraBars.BarButtonItem();
            mnuAbout = new DevExpress.XtraBars.BarButtonItem();
            btnSilent = new DevExpress.XtraBars.BarToggleSwitchItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            mainContainer = new DevExpress.XtraEditors.SplitContainerControl();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblUserName = new System.Windows.Forms.Label();
            txtUserName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            btnLogin = new DevExpress.XtraEditors.SimpleButton();
            btnExit = new DevExpress.XtraEditors.SimpleButton();
            label1 = new System.Windows.Forms.Label();
            svgLogo = new DevExpress.XtraEditors.SvgImageBox();
            flpNotification = new System.Windows.Forms.FlowLayoutPanel();
            erpMain = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            baseToastManager = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(components);
            ((System.ComponentModel.ISupportInitialize)MessengerBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainContainer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainContainer.Panel1).BeginInit();
            mainContainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainContainer.Panel2).BeginInit();
            mainContainer.Panel2.SuspendLayout();
            mainContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)svgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baseToastManager).BeginInit();
            SuspendLayout();
            // 
            // MessengerBar
            // 
            MessengerBar.Bars.AddRange(new DevExpress.XtraBars.Bar[] { mnuMainMenu });
            MessengerBar.DockControls.Add(barDockControlTop);
            MessengerBar.DockControls.Add(barDockControlBottom);
            MessengerBar.DockControls.Add(barDockControlLeft);
            MessengerBar.DockControls.Add(barDockControlRight);
            MessengerBar.Form = this;
            MessengerBar.Items.AddRange(new DevExpress.XtraBars.BarItem[] { mnuMessageActions, mnuAbout, mnuAllMessages, mnuReadMessages, mnuNewMessages, mnuExit, barButtonItem1, btnSilent, mnuCreateMessage });
            MessengerBar.MainMenu = mnuMainMenu;
            MessengerBar.MaxItemId = 16;
            // 
            // mnuMainMenu
            // 
            mnuMainMenu.BarName = "جعبه ابزار";
            mnuMainMenu.DockCol = 0;
            mnuMainMenu.DockRow = 0;
            mnuMainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            mnuMainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(mnuMessageActions), new DevExpress.XtraBars.LinkPersistInfo(mnuAbout), new DevExpress.XtraBars.LinkPersistInfo(btnSilent) });
            mnuMainMenu.OptionsBar.AllowQuickCustomization = false;
            mnuMainMenu.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            mnuMainMenu.OptionsBar.DisableClose = true;
            mnuMainMenu.OptionsBar.DisableCustomization = true;
            mnuMainMenu.OptionsBar.DrawBorder = false;
            mnuMainMenu.OptionsBar.DrawDragBorder = false;
            mnuMainMenu.OptionsBar.MultiLine = true;
            mnuMainMenu.OptionsBar.UseWholeRow = true;
            mnuMainMenu.Text = "Custom 2";
            // 
            // mnuMessageActions
            // 
            mnuMessageActions.Caption = "پیامها";
            mnuMessageActions.Id = 7;
            mnuMessageActions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(mnuCreateMessage), new DevExpress.XtraBars.LinkPersistInfo(mnuAllMessages), new DevExpress.XtraBars.LinkPersistInfo(mnuReadMessages), new DevExpress.XtraBars.LinkPersistInfo(mnuNewMessages), new DevExpress.XtraBars.LinkPersistInfo(mnuExit) });
            mnuMessageActions.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.SmallImagesText;
            mnuMessageActions.Name = "mnuMessageActions";
            mnuMessageActions.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // mnuCreateMessage
            // 
            mnuCreateMessage.Caption = "ایجاد پیام";
            mnuCreateMessage.Id = 15;
            mnuCreateMessage.Name = "mnuCreateMessage";
            mnuCreateMessage.ItemClick += mnuCreateMessage_ItemClick;
            // 
            // mnuAllMessages
            // 
            mnuAllMessages.Caption = "همه پیامها";
            mnuAllMessages.Id = 9;
            mnuAllMessages.Name = "mnuAllMessages";
            mnuAllMessages.ItemClick += mnuAllMessages_ItemClick;
            // 
            // mnuReadMessages
            // 
            mnuReadMessages.Caption = "پیامهای خوانده شده";
            mnuReadMessages.Id = 10;
            mnuReadMessages.Name = "mnuReadMessages";
            mnuReadMessages.ItemClick += mnuReadMessages_ItemClick;
            // 
            // mnuNewMessages
            // 
            mnuNewMessages.Caption = "پیامهای جدید";
            mnuNewMessages.Id = 11;
            mnuNewMessages.Name = "mnuNewMessages";
            mnuNewMessages.ItemClick += mnuNewMessages_ItemClick;
            // 
            // mnuExit
            // 
            mnuExit.Caption = "خروج";
            mnuExit.Id = 12;
            mnuExit.Name = "mnuExit";
            mnuExit.ItemClick += mnuExit_ItemClick;
            // 
            // mnuAbout
            // 
            mnuAbout.Caption = "درباره این برنامه";
            mnuAbout.Id = 8;
            mnuAbout.Name = "mnuAbout";
            mnuAbout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            mnuAbout.ItemClick += mnuAbout_ItemClick;
            // 
            // btnSilent
            // 
            btnSilent.Caption = "حالت ساکت";
            btnSilent.Id = 14;
            btnSilent.Name = "btnSilent";
            btnSilent.CheckedChanged += btnSilent_CheckedChanged;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = MessengerBar;
            barDockControlTop.Size = new System.Drawing.Size(414, 20);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 790);
            barDockControlBottom.Manager = MessengerBar;
            barDockControlBottom.Size = new System.Drawing.Size(414, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            barDockControlLeft.Manager = MessengerBar;
            barDockControlLeft.Size = new System.Drawing.Size(0, 770);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(414, 20);
            barDockControlRight.Manager = MessengerBar;
            barDockControlRight.Size = new System.Drawing.Size(0, 770);
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 13;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // mainContainer
            // 
            mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            mainContainer.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            mainContainer.Location = new System.Drawing.Point(0, 20);
            mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            mainContainer.Panel1.Controls.Add(tableLayoutPanel1);
            mainContainer.Panel1.Text = "Panel1";
            // 
            // mainContainer.Panel2
            // 
            mainContainer.Panel2.Controls.Add(flpNotification);
            mainContainer.Panel2.Text = "Panel2";
            mainContainer.Size = new System.Drawing.Size(414, 770);
            mainContainer.SplitterPosition = 404;
            mainContainer.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblUserName, 1, 3);
            tableLayoutPanel1.Controls.Add(txtUserName, 2, 3);
            tableLayoutPanel1.Controls.Add(txtPassword, 2, 4);
            tableLayoutPanel1.Controls.Add(lblPassword, 1, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 7);
            tableLayoutPanel1.Controls.Add(label1, 1, 5);
            tableLayoutPanel1.Controls.Add(svgLogo, 1, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55557F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new System.Drawing.Point(92, -121);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(53, 13);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "نام کاربری";
            // 
            // txtUserName
            // 
            txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            txtUserName.Location = new System.Drawing.Point(-147, -118);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(233, 21);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            txtPassword.Location = new System.Drawing.Point(-147, -91);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(233, 21);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(93, -94);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(52, 13);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "کلمه عبور";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnLogin, 0, 0);
            tableLayoutPanel2.Controls.Add(btnExit, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(-147, 6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(292, 45);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            btnLogin.Location = new System.Drawing.Point(149, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(140, 39);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "ورود";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            btnExit.Location = new System.Drawing.Point(3, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(140, 39);
            btnExit.TabIndex = 4;
            btnExit.Text = "خروج";
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(-146, -67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(291, 13);
            label1.TabIndex = 9;
            label1.Text = "برای ورود از نام کاربری و کلمه عبور ورود به ویندوز استفاده کنید";
            // 
            // svgLogo
            // 
            tableLayoutPanel1.SetColumnSpan(svgLogo, 2);
            svgLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            svgLogo.Location = new System.Drawing.Point(-147, -127);
            svgLogo.Name = "svgLogo";
            svgLogo.Size = new System.Drawing.Size(292, 1);
            svgLogo.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            svgLogo.TabIndex = 10;
            svgLogo.Text = "svgImageBox1";
            // 
            // flpNotification
            // 
            flpNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            flpNotification.Location = new System.Drawing.Point(0, 0);
            flpNotification.Name = "flpNotification";
            flpNotification.Size = new System.Drawing.Size(404, 770);
            flpNotification.TabIndex = 0;
            // 
            // erpMain
            // 
            erpMain.ContainerControl = this;
            // 
            // baseToastManager
            // 
            baseToastManager.ApplicationId = "dc549d39-213d-4439-9fde-c56461f6006f";
            baseToastManager.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] { new DevExpress.XtraBars.ToastNotifications.ToastNotification("cdfd44d5-ddc2-4e38-8248-d972126fba52", null, null, null, null, null, null, "", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "", null, DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.Default, null, DevExpress.XtraBars.ToastNotifications.AppLogoCrop.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Generic) });
            // 
            // MainWindow
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(414, 790);
            Controls.Add(mainContainer);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainWindow";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "پیام رسان پارس سویچ";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)MessengerBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainContainer.Panel1).EndInit();
            mainContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainContainer.Panel2).EndInit();
            mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainContainer).EndInit();
            mainContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)svgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)baseToastManager).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager baseToastManager;
    }
}