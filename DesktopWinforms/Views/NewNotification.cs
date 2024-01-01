using Desktop.Views.Shared;
using PSPublicMessagingAPI.Desktop.Models;
using PSPublicMessagingAPI.Desktop.Presenter.Presenter;
using PSPublicMessagingAPI.Desktop.Presenter.View;
using PSPublicMessagingAPI.Desktop.Services;
using PSPublicMessagingAPI.Desktop.ViewModels;
using PSPublicMessagingAPI.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using DesktopWinforms.Models;
using PSPublicMessagingAPI.SharedToastMessage;
using PSPublicMessagingAPI.SharedToastMessage.Models;
using PSPublicMessagingAPI.SharedToastMessage.Services;
using System.Threading;

namespace PSPublicMessagingAPI.Desktop.Views
{
    public partial class NewNotification : ViewBase, INewNotification
    {
        private INewNotificationPresenter _presenter;
        private IActiveDirectoryService _activeDirectoryService;
        private IToastService _toastService;
        private IMapper _mapper;
        public bool CanCancel
        {
            get => bsNotification.Current != null && (bsNotification.Current as NotificationViewModel).Id == Guid.Empty;

        }
        public bool CanNew
        {
            get => bsNotification.List.Count == 0 || bsNotification.Current != null && (bsNotification.Current as NotificationViewModel).Id != Guid.Empty;

        }
        public bool CanSend
        {
            get => bsNotification.Current != null && (bsNotification.Current as NotificationViewModel).Id != Guid.Empty && bsNotification.Current != null && (bsNotification.Current as NotificationViewModel).NotificationStatus == NotificationStatus.ReadyToPublish;

        }
        public NewNotification(IToastService toastService, IActiveDirectoryService activeDirectoryService, IMapper mapper) : base(toastService)
        {
            _toastService = toastService;
            _activeDirectoryService = activeDirectoryService;
            _mapper = mapper;
            InitializeComponent();
        }

        public INewNotificationPresenter Presenter
        {
            get
            {
                return _presenter;
            }
            set
            {
                if (_presenter == null)
                {
                    _presenter = value;
                }
            }
        }
        public IToastService ToastService
        {
            get
            {
                return _toastService;
            }
            set
            {
                if (_toastService == null)
                {
                    _toastService = value;
                }
            }
        }

        public NotificationDto SelectedNotification { get; private set; }
        public ObservableCollection<NotificationViewModel> NotificationList { get; private set; } = new ObservableCollection<NotificationViewModel>();
        public ObservableCollection<PossibleActionDto> PossibleActionList { get; private set; } = new ObservableCollection<PossibleActionDto>();
        public ObservableCollection<ClientActionDto> ClientActionList { get; private set; } = new ObservableCollection<ClientActionDto>();



        public void Run()
        {
            Show();


        }
        private void BindToControls()
        {
            txtTitle.DataBindings.Add("Text", bsNotification, "NotificationTitle", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMessageBody.DataBindings.Add("Text", bsNotification, "NotificationText", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNotificationDateTime.DataBindings.Add("Text", bsNotification, "NotificationDate", true, DataSourceUpdateMode.OnPropertyChanged);
            // cmbPriority.DataBindings.Add("SelectedIndex", bsNotification, "NotificationPriority");
            cmbGroup.DataBindings.Add("EditValue", bsNotification, "TargetGroup", true, DataSourceUpdateMode.OnPropertyChanged);
            // cmbStatus.DataBindings.Add("SelectedIndex", bsNotification, "NotificationStatus");


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid(false))
            {
                SelectedNotification = _mapper.Map<NotificationViewModel, NotificationDto>((bsNotification.Current as NotificationViewModel));
                SelectedNotification.PossibleActionId = PossibleActionList.FirstOrDefault(x => x.PossibleActionName.ToLower() == "publicmessage").Id; // Set to public Messages
                SelectedNotification.NotificationPriority = (NotificationPriority)cmbPriority.SelectedIndex;
                SelectedNotification.NotificationStatus = NotificationStatus.New;
                SelectedNotification.ClientGroup = "-";
                SelectedNotification.ClientFullName = "-";
                SelectedNotification.ClientUserName = "-";
                SelectedNotification.LastModifierUser = "-";
                SelectedNotification.MethodParameter = "{}";
                SelectedNotification.TargetClientFullName = "-";
                SelectedNotification.TargetClientUserName = "-";
                SelectedNotification.TargetClientGroup = "-";
                SelectedNotification.Id = Guid.NewGuid();

                Guid result = await _presenter.SaveNotification(SelectedNotification);
                if (result != Guid.Empty)
                {
                    NotificationViewModel newNotification = _mapper.Map<NotificationDto, NotificationViewModel>(_presenter.GetNotificationById(result));
                    if (bsNotification.List.Cast<NotificationViewModel>().Any(x => x.Id == result))
                    {
                        bsNotification.RemoveCurrent();
                    }

                    bsNotification.Add(newNotification);
                    bsNotification.DataSource = new ObservableCollection<NotificationViewModel>(bsNotification.List.Cast<NotificationViewModel>().Where(x => x.Id != Guid.Empty));
                    var ind = bsNotification.IndexOf(newNotification);
                    bsNotification.Position = ind;

                    ShowMessage("عملیات با موفقیت انجام شد", ToastType.Success);
                }
                else
                {
                    ShowMessage("خطایی رخ داد", ToastType.Error);
                }
            }
        }

        private bool IsValid(bool isSend)
        {

            erpNewNotification.Clear();
            //if (String.IsNullOrEmpty(txtReportNumber.Text.Trim()))
            //{
            //    erpNonConformity.SetError(txtReportNumber, "لطفا شماره گزارش را وارد کنید ");
            //    return false;
            //}
            if (!DateTime.TryParse(txtNotificationDateTime.DateTime.ToString(), out DateTime date))
            {
                erpNewNotification.SetError(txtNotificationDateTime, "لطفا تاریخ را وارد کنید ");
                return false;
            }
            if (String.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                erpNewNotification.SetError(txtTitle, "لطفا عنوان را وارد کنید ");
                return false;
            }
            if (String.IsNullOrEmpty(txtMessageBody.Text.Trim()))
            {
                erpNewNotification.SetError(txtMessageBody, "لطفا متن پیام را وارد کنید ");
                return false;
            }

            if (cmbGroup.EditValue == null)
            {
                erpNewNotification.SetError(cmbGroup, "لطفا گروه ارسال پیام را وارد کنید ");
                return false;
            }


            return true;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(bsNotification.Current is null))
            {
                if (MessageBox.Show("آیا از حذف این مورد اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Guid result = await _presenter.RemoveNotification((bsNotification.Current as NotificationViewModel).Id);
                    if (result != Guid.Empty)
                    {
                        bsNotification.RemoveCurrent();
                        ShowMessage("عملیات با موفقیت انجام شد", ToastType.Success);
                    }
                    else
                    {
                        ShowMessage("خطایی رخ داد", ToastType.Error);
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (bsNotification.List.Cast<NotificationViewModel>().Any(x => Guid.Empty == x.Id))
            {
                bsNotification.RemoveAt(bsNotification.IndexOf(bsNotification.List.Cast<NotificationViewModel>().FirstOrDefault(x => Guid.Empty == x.Id)));

            }
            bsNotification.AddNew();
            //  (bsNotification.Current as NotificationViewModel).NotificationId = Guid.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (bsNotification.List.Cast<NotificationViewModel>().Any(x => Guid.Empty == x.Id))
            {
                bsNotification.RemoveAt(bsNotification.IndexOf(bsNotification.List.Cast<NotificationViewModel>().FirstOrDefault(x => Guid.Empty == x.Id)));

            }
        }



        private async void NewNotification_Load(object sender, EventArgs e)
        {

            var priorityList = Enum.GetValues(typeof(NotificationPriority)).Cast<NotificationPriority>().ToList();
            priorityList.Insert(0, 0);
            PossibleActionList = new ObservableCollection<PossibleActionDto>(await _presenter.GetAllPossibleActions());
            NotificationList = new ObservableCollection<NotificationViewModel>(_mapper.Map<List<NotificationDto>, List<NotificationViewModel>>(await _presenter.GetAllNotifications()));
            cmbPriority.DataSource = priorityList;




            bsNotification.DataSource = new ObservableCollection<NotificationViewModel>(NotificationList); //);
            bsNotification.Sort = "NotificationDate DESC";
            cmbGroup.Properties.DataSource = _activeDirectoryService.ActiveDirectoryUsers.Where(x => !String.IsNullOrEmpty(x.OUName)).GroupBy(x => x.OUName).OrderBy(x => x.Key).Select((x, i) => new { OUName = x.Key, OUID = i + 1 }).ToList();
            BindToControls();
            gcNotification.DataSource = bsNotification;
            btnCancel.Enabled = CanCancel;
            btnNew.Enabled = CanNew;



        }

        private void bsNotification_CurrentChanged(object sender, EventArgs e)
        {
            btnCancel.Enabled = CanCancel;
            btnNew.Enabled = CanNew;

            if (bsNotification.Current != null)
            {

                cmbPriority.SelectedIndex = (int)(bsNotification.Current as NotificationViewModel).NotificationPriority;
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (IsValid(true))
            {
                SelectedNotification = _mapper.Map<NotificationViewModel, NotificationDto>((bsNotification.Current as NotificationViewModel));

                SelectedNotification.Id = (bsNotification.Current as NotificationViewModel).Id;
                SelectedNotification.ChangeStatus(NotificationStatus.New);
                SelectedNotification.LastModifierUser = "-";
                SelectedNotification.MethodParameter = "{}";
                //SelectedNotification.NotificationPriority = (NotificationPriority)cmbPriority.SelectedIndex;

                Guid result = await _presenter.SetNotificationStatus(SelectedNotification);
                if (result != Guid.Empty)
                {
                    NotificationViewModel newNotification = _mapper.Map<NotificationDto, NotificationViewModel>(_presenter.GetNotificationById(result));
                    if (bsNotification.List.Cast<NotificationViewModel>().Any(x => x.Id == result))
                    {
                        bsNotification.RemoveCurrent();
                    }

                    bsNotification.Add(newNotification);
                    var ind = bsNotification.IndexOf(newNotification);
                    bsNotification.Position = ind;

                    ShowMessage("عملیات با موفقیت انجام شد", ToastType.Success);
                }
                else
                {
                    ShowMessage("خطایی رخ داد", ToastType.Error);
                }
            }
        }

        private async void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (IsValid(true))
            {
                SelectedNotification = _mapper.Map<NotificationViewModel, NotificationDto>((bsNotification.Current as NotificationViewModel));

                SelectedNotification.Id = (bsNotification.Current as NotificationViewModel).Id;
                SelectedNotification.ChangeStatus(chbRead.Checked ? NotificationStatus.Read : NotificationStatus.New);
                SelectedNotification.LastModifierUser = "-";
                SelectedNotification.MethodParameter = "{}";
                //SelectedNotification.NotificationPriority = (NotificationPriority)cmbPriority.SelectedIndex;

                Guid result = await _presenter.SetNotificationStatus(SelectedNotification);
                if (result != Guid.Empty)
                {
                    NotificationViewModel newNotification = _mapper.Map<NotificationDto, NotificationViewModel>(_presenter.GetNotificationById(result));
                    if (bsNotification.List.Cast<NotificationViewModel>().Any(x => x.Id == result))
                    {
                        bsNotification.RemoveCurrent();
                    }

                    bsNotification.Add(newNotification);
                    var ind = bsNotification.IndexOf(newNotification);
                    bsNotification.Position = ind;

                    ShowMessage("عملیات با موفقیت انجام شد", ToastType.Success);
                }
                else
                {
                    ShowMessage("خطایی رخ داد", ToastType.Error);
                }
            }
        }
    }
}
