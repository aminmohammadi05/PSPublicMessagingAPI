namespace PSPublicMessagingAPI.Desktop.Views
{
    partial class NewNotification
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnNew = new DevExpress.XtraEditors.SimpleButton();
            btnSaveNCRReport = new DevExpress.XtraEditors.SimpleButton();
            btnDeleteNCRReport = new DevExpress.XtraEditors.SimpleButton();
            btnSend = new DevExpress.XtraEditors.SimpleButton();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            gcNotification = new DevExpress.XtraGrid.GridControl();
            gvNotification = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            txtTitle = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtMessageBody = new DevExpress.XtraRichEdit.RichEditControl();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtNotificationDateTime = new FarsiLibrary.Win.Controls.FADatePicker();
            cmbStatus = new System.Windows.Forms.ComboBox();
            cmbPriority = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            cmbGroup = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            bsNotification = new System.Windows.Forms.BindingSource(components);
            erpNewNotification = new System.Windows.Forms.ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcNotification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvNotification).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbGroup.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsNotification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpNewNotification).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Controls.Add(gcNotification, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1137, 697);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 7;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel4.Controls.Add(btnCancel, 3, 0);
            tableLayoutPanel4.Controls.Add(btnNew, 2, 0);
            tableLayoutPanel4.Controls.Add(btnSaveNCRReport, 0, 0);
            tableLayoutPanel4.Controls.Add(btnDeleteNCRReport, 1, 0);
            tableLayoutPanel4.Controls.Add(btnSend, 4, 0);
            tableLayoutPanel4.Controls.Add(btnClose, 6, 0);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 631);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            tableLayoutPanel4.Size = new System.Drawing.Size(1131, 63);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            btnCancel.Location = new System.Drawing.Point(678, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(108, 57);
            btnCancel.TabIndex = 98;
            btnCancel.Text = "لغو   ";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnNew
            // 
            btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            btnNew.Location = new System.Drawing.Point(792, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(108, 57);
            btnNew.TabIndex = 97;
            btnNew.Text = "جدید   ";
            btnNew.Click += btnNew_Click;
            // 
            // btnSaveNCRReport
            // 
            btnSaveNCRReport.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSaveNCRReport.Location = new System.Drawing.Point(1020, 3);
            btnSaveNCRReport.Name = "btnSaveNCRReport";
            btnSaveNCRReport.Size = new System.Drawing.Size(108, 57);
            btnSaveNCRReport.TabIndex = 3;
            btnSaveNCRReport.Text = "ثبت تغییرات   ";
            btnSaveNCRReport.Click += btnSave_Click;
            // 
            // btnDeleteNCRReport
            // 
            btnDeleteNCRReport.Dock = System.Windows.Forms.DockStyle.Fill;
            btnDeleteNCRReport.Location = new System.Drawing.Point(906, 3);
            btnDeleteNCRReport.Name = "btnDeleteNCRReport";
            btnDeleteNCRReport.Size = new System.Drawing.Size(108, 57);
            btnDeleteNCRReport.TabIndex = 4;
            btnDeleteNCRReport.Text = "حذف   ";
            btnDeleteNCRReport.Click += btnDelete_Click;
            // 
            // btnSend
            // 
            btnSend.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSend.Location = new System.Drawing.Point(564, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(108, 57);
            btnSend.TabIndex = 5;
            btnSend.Text = "ارسال   ";
            btnSend.Click += btnSend_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            btnClose.Location = new System.Drawing.Point(3, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(108, 57);
            btnClose.TabIndex = 6;
            btnClose.Text = "خروج   ";
            btnClose.Click += btnClose_Click;
            // 
            // gcNotification
            // 
            gcNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            gcNotification.Location = new System.Drawing.Point(3, 317);
            gcNotification.MainView = gvNotification;
            gcNotification.Name = "gcNotification";
            gcNotification.Size = new System.Drawing.Size(1131, 308);
            gcNotification.TabIndex = 0;
            gcNotification.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvNotification });
            // 
            // gvNotification
            // 
            gvNotification.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6 });
            gvNotification.GridControl = gcNotification;
            gvNotification.Name = "gvNotification";
            gvNotification.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "عنوان";
            gridColumn1.FieldName = "NotificationTitle";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "متن پیام";
            gridColumn2.FieldName = "NotificationText";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "تاریخ";
            gridColumn3.FieldName = "NotificationDatePersian";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "وضعیت";
            gridColumn4.FieldName = "NotificationStatusText";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "اولویت";
            gridColumn5.FieldName = "NotificationPriorityText";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "گروه های گیرنده";
            gridColumn6.FieldName = "TargetGroup";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 8;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00146F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00146F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99896F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(txtTitle, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(txtMessageBody, 1, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 2, 1);
            tableLayoutPanel2.Controls.Add(label5, 4, 1);
            tableLayoutPanel2.Controls.Add(txtNotificationDateTime, 5, 1);
            tableLayoutPanel2.Controls.Add(cmbStatus, 1, 1);
            tableLayoutPanel2.Controls.Add(cmbPriority, 3, 1);
            tableLayoutPanel2.Controls.Add(label6, 6, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 7, 1);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new System.Drawing.Size(1131, 308);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1095, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 13);
            label1.TabIndex = 0;
            label1.Text = "عنوان";
            // 
            // txtTitle
            // 
            tableLayoutPanel2.SetColumnSpan(txtTitle, 7);
            txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            txtTitle.Location = new System.Drawing.Point(3, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(1058, 21);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(1083, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 13);
            label2.TabIndex = 2;
            label2.Text = "متن پیام";
            // 
            // txtMessageBody
            // 
            tableLayoutPanel2.SetColumnSpan(txtMessageBody, 7);
            txtMessageBody.Dock = System.Windows.Forms.DockStyle.Fill;
            txtMessageBody.Location = new System.Drawing.Point(3, 62);
            txtMessageBody.Name = "txtMessageBody";
            txtMessageBody.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            txtMessageBody.Size = new System.Drawing.Size(1058, 223);
            txtMessageBody.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(1067, 27);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 13);
            label3.TabIndex = 4;
            label3.Text = "وضعیت پیام";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(777, 27);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 13);
            label4.TabIndex = 5;
            label4.Text = "اولویت پیام";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(495, 27);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(48, 13);
            label5.TabIndex = 6;
            label5.Text = "تاریخ پیام";
            // 
            // txtNotificationDateTime
            // 
            txtNotificationDateTime.Dock = System.Windows.Forms.DockStyle.Top;
            txtNotificationDateTime.FormatInfo = FarsiLibrary.Win.Enums.FormatInfoTypes.FullDateTime;
            txtNotificationDateTime.Location = new System.Drawing.Point(267, 30);
            txtNotificationDateTime.Name = "txtNotificationDateTime";
            txtNotificationDateTime.Size = new System.Drawing.Size(222, 26);
            txtNotificationDateTime.TabIndex = 11;
            txtNotificationDateTime.TabStop = false;
            txtNotificationDateTime.Text = "[Empty Value]";
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbStatus.Location = new System.Drawing.Point(839, 30);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new System.Drawing.Size(222, 21);
            cmbStatus.TabIndex = 12;
            // 
            // cmbPriority
            // 
            cmbPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbPriority.Location = new System.Drawing.Point(549, 30);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new System.Drawing.Size(222, 21);
            cmbPriority.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(234, 27);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(27, 13);
            label6.TabIndex = 14;
            label6.Text = "گروه";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel3.Controls.Add(cmbGroup, 0, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 30);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new System.Drawing.Size(225, 26);
            tableLayoutPanel3.TabIndex = 16;
            // 
            // cmbGroup
            // 
            cmbGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbGroup.EditValue = "";
            cmbGroup.Location = new System.Drawing.Point(3, 3);
            cmbGroup.Name = "cmbGroup";
            cmbGroup.Properties.AllowMultiSelect = true;
            cmbGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbGroup.Properties.DisplayMember = "OUName";
            cmbGroup.Properties.ValueMember = "OUName";
            cmbGroup.Size = new System.Drawing.Size(219, 20);
            cmbGroup.TabIndex = 288;
            // 
            // bsNotification
            // 
            bsNotification.CurrentChanged += bsNotification_CurrentChanged;
            // 
            // erpNewNotification
            // 
            erpNewNotification.ContainerControl = this;
            // 
            // NewNotification
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1137, 697);
            Controls.Add(tableLayoutPanel1);
            Name = "NewNotification";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "ایجاد پیام جدید";
            Load += NewNotification_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcNotification).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvNotification).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cmbGroup.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsNotification).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpNewNotification).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gcNotification;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNotification;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnSaveNCRReport;
        private DevExpress.XtraEditors.SimpleButton btnDeleteNCRReport;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraRichEdit.RichEditControl txtMessageBody;
        private FarsiLibrary.Win.Controls.FADatePicker txtNotificationDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.BindingSource bsNotification;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider erpNewNotification;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}