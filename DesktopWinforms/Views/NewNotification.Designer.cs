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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewNotification));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnNew = new DevExpress.XtraEditors.SimpleButton();
            btnSaveNCRReport = new DevExpress.XtraEditors.SimpleButton();
            btnDeleteNCRReport = new DevExpress.XtraEditors.SimpleButton();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            btnChangeStatus = new DevExpress.XtraEditors.SimpleButton();
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
            cmbPriority = new System.Windows.Forms.ComboBox();
            txtNotificationDateTime = new DevExpress.XtraEditors.DateEdit();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            cmbGroup = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            chbRead = new System.Windows.Forms.CheckBox();
            label6 = new System.Windows.Forms.Label();
            bsNotification = new System.Windows.Forms.BindingSource(components);
            erpNewNotification = new System.Windows.Forms.ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcNotification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvNotification).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtNotificationDateTime.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNotificationDateTime.Properties.CalendarTimeProperties).BeginInit();
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
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.9999924F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0000038F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
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
            tableLayoutPanel4.Controls.Add(btnClose, 6, 0);
            tableLayoutPanel4.Controls.Add(btnChangeStatus, 4, 0);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 637);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.Size = new System.Drawing.Size(1131, 57);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnCancel.ImageOptions.Image");
            btnCancel.Location = new System.Drawing.Point(678, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(108, 50);
            btnCancel.TabIndex = 98;
            btnCancel.Text = "لغو   ";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnNew
            // 
            btnNew.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnNew.ImageOptions.Image");
            btnNew.Location = new System.Drawing.Point(792, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(108, 50);
            btnNew.TabIndex = 97;
            btnNew.Text = "جدید   ";
            btnNew.Click += btnNew_Click;
            // 
            // btnSaveNCRReport
            // 
            btnSaveNCRReport.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSaveNCRReport.ImageOptions.Image");
            btnSaveNCRReport.Location = new System.Drawing.Point(1020, 3);
            btnSaveNCRReport.Name = "btnSaveNCRReport";
            btnSaveNCRReport.Size = new System.Drawing.Size(108, 50);
            btnSaveNCRReport.TabIndex = 3;
            btnSaveNCRReport.Text = "   ارسال";
            btnSaveNCRReport.Click += btnSave_Click;
            // 
            // btnDeleteNCRReport
            // 
            btnDeleteNCRReport.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnDeleteNCRReport.ImageOptions.Image");
            btnDeleteNCRReport.Location = new System.Drawing.Point(906, 3);
            btnDeleteNCRReport.Name = "btnDeleteNCRReport";
            btnDeleteNCRReport.Size = new System.Drawing.Size(108, 50);
            btnDeleteNCRReport.TabIndex = 4;
            btnDeleteNCRReport.Text = "حذف   ";
            btnDeleteNCRReport.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnClose.ImageOptions.Image");
            btnClose.Location = new System.Drawing.Point(3, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(108, 50);
            btnClose.TabIndex = 6;
            btnClose.Text = "خروج   ";
            btnClose.Click += btnClose_Click;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnChangeStatus.ImageOptions.Image");
            btnChangeStatus.Location = new System.Drawing.Point(551, 3);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new System.Drawing.Size(121, 50);
            btnChangeStatus.TabIndex = 99;
            btnChangeStatus.Text = "تغییر وضعیت";
            btnChangeStatus.Click += btnChangeStatus_Click;
            // 
            // gcNotification
            // 
            gcNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            gcNotification.Location = new System.Drawing.Point(3, 320);
            gcNotification.MainView = gvNotification;
            gcNotification.Name = "gcNotification";
            gcNotification.Size = new System.Drawing.Size(1131, 311);
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
            tableLayoutPanel2.Controls.Add(cmbPriority, 1, 1);
            tableLayoutPanel2.Controls.Add(txtNotificationDateTime, 3, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(label5, 2, 1);
            tableLayoutPanel2.Controls.Add(cmbGroup, 7, 1);
            tableLayoutPanel2.Controls.Add(chbRead, 4, 1);
            tableLayoutPanel2.Controls.Add(label6, 6, 1);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new System.Drawing.Size(1131, 311);
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
            txtTitle.Size = new System.Drawing.Size(1063, 21);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(1083, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 13);
            label2.TabIndex = 2;
            label2.Text = "متن پیام";
            // 
            // txtMessageBody
            // 
            tableLayoutPanel2.SetColumnSpan(txtMessageBody, 7);
            txtMessageBody.Dock = System.Windows.Forms.DockStyle.Fill;
            txtMessageBody.Location = new System.Drawing.Point(3, 57);
            txtMessageBody.Name = "txtMessageBody";
            txtMessageBody.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            txtMessageBody.Size = new System.Drawing.Size(1063, 231);
            txtMessageBody.TabIndex = 3;
            // 
            // cmbPriority
            // 
            cmbPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbPriority.Location = new System.Drawing.Point(848, 30);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new System.Drawing.Size(218, 21);
            cmbPriority.TabIndex = 13;
            // 
            // txtNotificationDateTime
            // 
            txtNotificationDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            txtNotificationDateTime.EditValue = null;
            txtNotificationDateTime.Location = new System.Drawing.Point(570, 30);
            txtNotificationDateTime.Name = "txtNotificationDateTime";
            txtNotificationDateTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtNotificationDateTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtNotificationDateTime.Properties.CalendarTimeProperties.MaskSettings.Set("culture", "fa-IR");
            txtNotificationDateTime.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            txtNotificationDateTime.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            txtNotificationDateTime.Size = new System.Drawing.Size(218, 20);
            txtNotificationDateTime.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(1072, 27);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 13);
            label4.TabIndex = 5;
            label4.Text = "اولویت پیام";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(794, 27);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(48, 13);
            label5.TabIndex = 6;
            label5.Text = "تاریخ پیام";
            // 
            // cmbGroup
            // 
            cmbGroup.EditValue = "";
            cmbGroup.Location = new System.Drawing.Point(58, 30);
            cmbGroup.Name = "cmbGroup";
            cmbGroup.Properties.AllowMultiSelect = true;
            cmbGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbGroup.Properties.DisplayMember = "OUName";
            cmbGroup.Properties.ValueMember = "OUName";
            cmbGroup.Size = new System.Drawing.Size(164, 20);
            cmbGroup.TabIndex = 288;
            // 
            // chbRead
            // 
            chbRead.AutoSize = true;
            chbRead.Location = new System.Drawing.Point(484, 30);
            chbRead.Name = "chbRead";
            chbRead.Size = new System.Drawing.Size(80, 17);
            chbRead.TabIndex = 290;
            chbRead.Text = "خوانده شده";
            chbRead.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(228, 27);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(27, 13);
            label6.TabIndex = 14;
            label6.Text = "گروه";
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
            ((System.ComponentModel.ISupportInitialize)txtNotificationDateTime.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNotificationDateTime.Properties).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraRichEdit.RichEditControl txtMessageBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.BindingSource bsNotification;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider erpNewNotification;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.DateEdit txtNotificationDateTime;
        private System.Windows.Forms.CheckBox chbRead;
        private DevExpress.XtraEditors.SimpleButton btnChangeStatus;
    }
}