namespace DesktopWinforms.UserControls
{
    partial class NotificationBubble
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btnMarkAsRead = new DevExpress.XtraEditors.SimpleButton();
            btnVisit = new DevExpress.XtraEditors.SimpleButton();
            lblTitle = new System.Windows.Forms.Label();
            lblModule = new System.Windows.Forms.Label();
            lblSender = new System.Windows.Forms.Label();
            tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            lblTime = new System.Windows.Forms.Label();
            lblPriority = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            svgImageBox2 = new DevExpress.XtraEditors.SvgImageBox();
            svgImageBox4 = new DevExpress.XtraEditors.SvgImageBox();
            svgImageBox3 = new DevExpress.XtraEditors.SvgImageBox();
            tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            lblMessage = new System.Windows.Forms.TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabPane1).BeginInit();
            tabPane1.SuspendLayout();
            tabNavigationPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)svgImageBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)svgImageBox3).BeginInit();
            tabNavigationPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(btnMarkAsRead, 1, 4);
            tableLayoutPanel1.Controls.Add(btnVisit, 2, 4);
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(lblModule, 0, 1);
            tableLayoutPanel1.Controls.Add(lblSender, 0, 2);
            tableLayoutPanel1.Controls.Add(tabPane1, 0, 3);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(396, 314);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnMarkAsRead
            // 
            btnMarkAsRead.Location = new System.Drawing.Point(141, 259);
            btnMarkAsRead.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMarkAsRead.Name = "btnMarkAsRead";
            btnMarkAsRead.Size = new System.Drawing.Size(117, 40);
            btnMarkAsRead.TabIndex = 0;
            btnMarkAsRead.Text = "خواندم";
            btnMarkAsRead.Click += btnMarkAsRead_Click;
            // 
            // btnVisit
            // 
            btnVisit.Location = new System.Drawing.Point(16, 259);
            btnVisit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnVisit.Name = "btnVisit";
            btnVisit.Size = new System.Drawing.Size(117, 40);
            btnVisit.TabIndex = 1;
            btnVisit.Text = "مشاهده";
            btnVisit.Click += btnVisit_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitle, 3);
            lblTitle.ForeColor = System.Drawing.Color.ForestGreen;
            lblTitle.Location = new System.Drawing.Point(345, 12);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(35, 15);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "عنوان";
            // 
            // lblModule
            // 
            lblModule.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblModule, 3);
            lblModule.Location = new System.Drawing.Point(342, 47);
            lblModule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblModule.Name = "lblModule";
            lblModule.Size = new System.Drawing.Size(38, 15);
            lblModule.TabIndex = 3;
            lblModule.Text = "ماجول";
            // 
            // lblSender
            // 
            lblSender.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblSender, 3);
            lblSender.Location = new System.Drawing.Point(333, 82);
            lblSender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSender.Name = "lblSender";
            lblSender.Size = new System.Drawing.Size(47, 15);
            lblSender.TabIndex = 4;
            lblSender.Text = "فرستنده";
            // 
            // tabPane1
            // 
            tableLayoutPanel1.SetColumnSpan(tabPane1, 3);
            tabPane1.Controls.Add(tabNavigationPage1);
            tabPane1.Controls.Add(tabNavigationPage2);
            tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabPane1.Location = new System.Drawing.Point(16, 120);
            tabPane1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPane1.Name = "tabPane1";
            tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] { tabNavigationPage1, tabNavigationPage2 });
            tabPane1.RegularSize = new System.Drawing.Size(364, 133);
            tabPane1.SelectedPage = tabNavigationPage1;
            tabPane1.Size = new System.Drawing.Size(364, 133);
            tabPane1.TabIndex = 5;
            tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            tabNavigationPage1.Caption = "اطلاعات اصلی";
            tabNavigationPage1.Controls.Add(tableLayoutPanel2);
            tabNavigationPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabNavigationPage1.Name = "tabNavigationPage1";
            tabNavigationPage1.Size = new System.Drawing.Size(364, 100);
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 1, 2);
            tableLayoutPanel2.Controls.Add(label3, 1, 3);
            tableLayoutPanel2.Controls.Add(lblDate, 2, 0);
            tableLayoutPanel2.Controls.Add(lblTime, 2, 1);
            tableLayoutPanel2.Controls.Add(lblPriority, 2, 2);
            tableLayoutPanel2.Controls.Add(lblStatus, 2, 3);
            tableLayoutPanel2.Controls.Add(svgImageBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(svgImageBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(svgImageBox4, 0, 2);
            tableLayoutPanel2.Controls.Add(svgImageBox3, 0, 3);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new System.Drawing.Size(364, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(294, 0);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "تاریخ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(287, 25);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "ساعت";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(283, 50);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "اولویت";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(278, 75);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "وضعیت";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(232, 0);
            lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(38, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "label5";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new System.Drawing.Point(232, 25);
            lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(38, 15);
            lblTime.TabIndex = 5;
            lblTime.Text = "label6";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new System.Drawing.Point(232, 50);
            lblPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new System.Drawing.Size(38, 15);
            lblPriority.TabIndex = 7;
            lblPriority.Text = "label8";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(232, 75);
            lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(38, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "label7";
            // 
            // svgImageBox1
            // 
            svgImageBox1.Location = new System.Drawing.Point(333, 3);
            svgImageBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            svgImageBox1.Name = "svgImageBox1";
            svgImageBox1.Size = new System.Drawing.Size(27, 16);
            svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            svgImageBox1.TabIndex = 8;
            svgImageBox1.Text = "svgImageBox1";
            // 
            // svgImageBox2
            // 
            svgImageBox2.Location = new System.Drawing.Point(333, 28);
            svgImageBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            svgImageBox2.Name = "svgImageBox2";
            svgImageBox2.Size = new System.Drawing.Size(27, 16);
            svgImageBox2.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            svgImageBox2.TabIndex = 9;
            svgImageBox2.Text = "svgImageBox2";
            // 
            // svgImageBox4
            // 
            svgImageBox4.Location = new System.Drawing.Point(333, 53);
            svgImageBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            svgImageBox4.Name = "svgImageBox4";
            svgImageBox4.Size = new System.Drawing.Size(27, 16);
            svgImageBox4.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            svgImageBox4.TabIndex = 11;
            svgImageBox4.Text = "svgImageBox4";
            // 
            // svgImageBox3
            // 
            svgImageBox3.Location = new System.Drawing.Point(333, 78);
            svgImageBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            svgImageBox3.Name = "svgImageBox3";
            svgImageBox3.Size = new System.Drawing.Size(27, 16);
            svgImageBox3.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            svgImageBox3.TabIndex = 10;
            svgImageBox3.Text = "svgImageBox3";
            // 
            // tabNavigationPage2
            // 
            tabNavigationPage2.Caption = "متن پیام";
            tabNavigationPage2.Controls.Add(lblMessage);
            tabNavigationPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabNavigationPage2.Name = "tabNavigationPage2";
            tabNavigationPage2.Size = new System.Drawing.Size(365, 108);
            // 
            // lblMessage
            // 
            lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            lblMessage.Location = new System.Drawing.Point(0, 0);
            lblMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lblMessage.Multiline = true;
            lblMessage.Name = "lblMessage";
            lblMessage.ReadOnly = true;
            lblMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            lblMessage.Size = new System.Drawing.Size(365, 108);
            lblMessage.TabIndex = 0;
            // 
            // NotificationBubble
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "NotificationBubble";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(396, 314);
            Load += NotificationBubble_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabPane1).EndInit();
            tabPane1.ResumeLayout(false);
            tabNavigationPage1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)svgImageBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)svgImageBox3).EndInit();
            tabNavigationPage2.ResumeLayout(false);
            tabNavigationPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnMarkAsRead;
        private DevExpress.XtraEditors.SimpleButton btnVisit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblSender;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.TextBox lblMessage;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox2;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox3;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox4;
    }
}
