using Desktop.Views.Shared;
using DevExpress.XtraEditors;
using PSPublicMessagingAPI.Desktop.Models;
using PSPublicMessagingAPI.Desktop.Presenter.Presenter;
using PSPublicMessagingAPI.Desktop.Presenter.View;
using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.Desktop.Services;
using PSPublicMessagingAPI.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using AutoMapper;
using DesktopWinforms.Models;
using DesktopWinforms.UserControls;
using PSPublicMessagingAPI.Domain.Notifications;
using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using static DevExpress.Data.Filtering.Helpers.SubExprHelper.ThreadHoppingFiltering;
using PSPublicMessagingAPI.Desktop.Consumers;
using MassTransit;
using PSPublicMessagingAPI.Contract;
using DevExpress.Utils.MVVM.Services;
using PSPublicMessagingAPI.SharedToastMessage;
using PSPublicMessagingAPI.SharedToastMessage.Models;
using PSPublicMessagingAPI.SharedToastMessage.Services;

namespace PSPublicMessagingAPI.Desktop.Views
{
    public enum MessagesListStatus
    {
        None,
        New,
        Read,
        All
    }
    public partial class MainWindow : ViewBase, IMainView//, IConsumer<NotificationCreatedEvent>
    {
        private ConnectionFactory _factory;
        private IConnection _connection;
        private IModel _channel;
        


        private IMainViewPresenter _presenter;
        private IToastService _toastService;
        private IActiveDirectoryService _activeDirectoryService;
        public SynchronizationContext _uiSyncContext = null;
        private readonly IMapper _mapper;
        private ICommunicationApplicationController _communicationAppController;
        public List<NotificationViewModel> NotificationList { get; set; }
        public List<NotificationViewModel> FilteredNotificationList { get; set; }
        public MessagesListStatus CurrentStatus { get; set; }
        private Dispatcher _dispatcher;

        // ShellViewModel shellViewModel;
        IFontService _fontService;
        IConfigurationManagerService _configurationManagerService;
        NotificationCreatedConsumer _consumer;
        public MainWindow(ICommunicationApplicationController communicationAppController, IToastService toastService, IActiveDirectoryService activeDirectoryService, IMapper mapper, NotificationCreatedConsumer consumer, IFontService fontService, IConfigurationManagerService configurationManagerService, Dispatcher dispatcher) : base(toastService)
        {
            InitializeComponent();
            _uiSyncContext = SynchronizationContext.Current;
            _consumer = consumer;
            _consumer.MessageReceived += _consumer_MessageReceived; ;
            _configurationManagerService = configurationManagerService;
            SilentMode = _configurationManagerService.Silent;
            btnSilent.Checked = SilentMode;
            this.svgLogo.SvgImage = global::PSPublicMessagingAPI.DesktopWinforms.Properties.Resources.LOGO;
            _fontService = fontService;
            List<Control> allControls = GetAllControls(this);

            //lblUserName.Font = _fontService.font;
            allControls.ForEach(k => k.Font = new Font(_fontService.pfc.Families[0], k.Font.Size));
            // svgLogo.SvgImage = DevExpress.Utils.Svg.SvgImage.FromResources( "LOGO.svg", typeof(MainWindow).Assembly);
            erpMain.ContainerControl = this;
            _communicationAppController = communicationAppController;
            _toastService = toastService;
            // this.shellViewModel = shellViewModel;
            _dispatcher = dispatcher;
            //shellViewModel.StartListening();
            //shellViewModel.MessageReceived += ShellViewModel_MessageReceived; ;
            _mapper = mapper;

            _activeDirectoryService = activeDirectoryService;
        }

      

        private List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {

                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }

            return list;
        }
        private List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }
        public void _consumer_MessageReceived(object sender, PropertyChangedEventArgs e)
        {
            NotificationViewModel message = _consumer.Notification;
            
            if (message.Id == Guid.Empty)
            {

                return;
            }
          
            if (message.NotificationStatus == NotificationStatus.ReadyToPublish)
            {
                return;
            }
            if ((!string.IsNullOrEmpty(message.TargetGroup) && message.TargetGroup.Split(new char[',']).Select(x => x.Trim()).Where(x => !String.IsNullOrEmpty(x)).Count() > 0) ||
                (!string.IsNullOrEmpty(message.TargetGroup) && message.TargetGroup.Split(new char[',']).Select(x => x.Trim()).Where(x => !String.IsNullOrEmpty(x)).Any(x => x == _activeDirectoryService.OU)))
            {

                if (_configurationManagerService.Silent)
                {
                    _consumer.StaThreadWrapper(() =>
                    {
                        ShowMessage(message.NotificationText, ToastType.Info);
                    });
                    //_dispatcher.Invoke(() => ShowMessage(message.NotificationText, ToastType.Info));
                }
                else
                {
                    _dispatcher.Invoke(() =>
                    {
                        var msg = new Message(message, _communicationAppController, _activeDirectoryService, _mapper, _fontService);
                        msg.TopMost = true;
                        msg.Show();
                    }, DispatcherPriority.Render);

                }
                _dispatcher.Invoke(() => AddNewNotification(message.NotificationDate, _activeDirectoryService.CurrentUser, message));


            }
        }


        public IMainViewPresenter Presenter
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

        public string UserName { get; private set; }
        public bool SilentMode { get; private set; }

        private void LoadNotifications(string user)
        {

            if (this.mainContainer.Panel2.Controls.ContainsKey("flpNotification"))
            {
                this.mainContainer.Panel2.Controls.Find("flpNotification", false)[0].Controls.Clear();
            }


            FilteredNotificationList = CurrentStatus != MessagesListStatus.All ? NotificationList.Where(x => x.NotificationStatus == (NotificationStatus)CurrentStatus).ToList() : NotificationList;
            foreach (var item in FilteredNotificationList)
            {
                NotificationBubble notificationBubble = new NotificationBubble(_presenter, item, this, _communicationAppController, _activeDirectoryService, _mapper, _fontService);


                if (this.mainContainer.Panel2.Controls.ContainsKey("flpNotification"))
                {
                    this.mainContainer.Panel2.Controls.Find("flpNotification", false)[0].Controls.Add(notificationBubble);
                    (this.mainContainer.Panel2.Controls.Find("flpNotification", false)[0] as FlowLayoutPanel).SetFlowBreak(notificationBubble, true);
                }
            }
        }

        private void AddNewNotification(DateTime dateTime, string user, NotificationViewModel notif)
        {
            if (NotificationList == null)
            {
                return;
            }
            if ( NotificationList.Any(x => x.Id == notif.Id))
            {
                NotificationList = NotificationList.Where(x => x.Id != notif.Id).ToList();

            }
            NotificationList.Add(notif);
            LoadNotifications(user);

        }
        protected override void ShowMessage(string message, ToastType toastType)
        {
            _toastService.ToastMessage = new Toast()
            {
                Message = message,
                ToastType = toastType
            };
            var notify = new ToastMessageView(_toastService);
            notify.Show();
        }

        public void Run()
        {
            ShowDialog();
        }
        private async void MainWindow_Load(object sender, EventArgs e)
        {
            

            mnuMainMenu.Visible = !String.IsNullOrEmpty(_activeDirectoryService.CurrentUser);

            if (!String.IsNullOrEmpty(_activeDirectoryService.CurrentUser))
            {
                var roles = await _activeDirectoryService.GetUserRoles(_activeDirectoryService.CurrentUser);
                mnuCreateMessage.Visibility = roles != null && roles.Any() ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
                mainContainer.IsSplitterFixed = true;
                mainContainer.FixedPanel = SplitFixedPanel.Panel2;
                NotificationList = _mapper.Map<List<NotificationDto>, List<NotificationViewModel>>(await _communicationAppController.GetUserUnreadNotificationsAsync(_activeDirectoryService.CurrentUser, _activeDirectoryService.OU));
                LoadNotifications(_activeDirectoryService.CurrentUser);
            }
            else
            {
                mainContainer.IsSplitterFixed = true;
                mainContainer.FixedPanel = SplitFixedPanel.Panel1;
                string[] userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split(new Char[] { '\\' });
                txtUserName.Text = userName.Length == 2 ? userName[1] : "";
            }
            //mnuMainMenu.Visible = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                return;
            }
            if (_activeDirectoryService.LoginToActiveDirectoryUser(txtUserName.Text.Trim().ToLower(), txtPassword.Text.Trim()) != null)
            {
                mainContainer.IsSplitterFixed = true;
                mainContainer.FixedPanel = SplitFixedPanel.Panel2;
                mnuMainMenu.Visible = !String.IsNullOrEmpty(_activeDirectoryService.CurrentUser);
                var roles = await _activeDirectoryService.GetUserRoles(_activeDirectoryService.CurrentUser);
                mnuCreateMessage.Visibility = roles != null && roles.Any() ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
                NotificationList = _mapper.Map<List<NotificationDto>, List<NotificationViewModel>>(await _communicationAppController.GetUserUnreadNotificationsAsync(_activeDirectoryService.CurrentUser, _activeDirectoryService.OU));
                LoadNotifications(_activeDirectoryService.CurrentUser);
                //mnuCreateMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }

        private bool IsValid()
        {
            if (String.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                erpMain.SetError(txtUserName, "لطفا آدرس را وارد کنید");
                return false;
            }
            if (String.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                erpMain.SetError(txtPassword, "لطفا آدرس را وارد کنید");
                return false;
            }
            return true;
        }

        private void mnuExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _configurationManagerService.UserName = String.Empty;
            _configurationManagerService.Password = String.Empty;
            mainContainer.IsSplitterFixed = true;
            mainContainer.FixedPanel = SplitFixedPanel.Panel1;
            mnuMainMenu.Visible = String.IsNullOrEmpty(_activeDirectoryService.CurrentUser);
        }

        private async void mnuAllMessages_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CurrentStatus = MessagesListStatus.All;
            NotificationList = _mapper.Map<List<NotificationDto>, List<NotificationViewModel>>(await _communicationAppController.GetAllNotificationsByUsernameAsync(_activeDirectoryService.CurrentUser, _activeDirectoryService.OU));
            this.mainContainer.Panel2.Controls.Find("flpNotification", false)[0].Controls.Clear();
            foreach (var item in NotificationList)
            {
                NotificationBubble notificationBubble = new NotificationBubble(_presenter, item, this, _communicationAppController, _activeDirectoryService, _mapper, _fontService);


                if (this.mainContainer.Panel2.Controls.ContainsKey("flpNotification"))
                {
                    this.mainContainer.Panel2.Controls.Find("flpNotification", false)[0].Controls.Add(notificationBubble);
                    (this.mainContainer.Panel2.Controls.Find("flpNotification", false)[0] as FlowLayoutPanel).SetFlowBreak(notificationBubble, true);
                }
            }
        }

        private async void mnuReadMessages_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CurrentStatus = MessagesListStatus.Read;
            NotificationList = _mapper.Map<List<NotificationDto>, List<NotificationViewModel>>(await _communicationAppController.GetNotificationsByStatusAsync(_activeDirectoryService.CurrentUser, _activeDirectoryService.OU, NotificationStatus.Read));
            this.mainContainer.Panel2.Controls.Find("flpNotification", false)[0].Controls.Clear();
            foreach (var item in NotificationList)
            {
                NotificationBubble notificationBubble = new NotificationBubble(_presenter, item, this, _communicationAppController, _activeDirectoryService, _mapper, _fontService);


                if (this.mainContainer.Panel2.Controls.ContainsKey("flpNotification"))
                {
                    this.mainContainer.Panel2.Controls.Find("flpNotification", false)[0].Controls.Add(notificationBubble);
                    (this.mainContainer.Panel2.Controls.Find("flpNotification", false)[0] as FlowLayoutPanel).SetFlowBreak(notificationBubble, true);
                }
            }
        }

        private async void mnuNewMessages_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CurrentStatus = MessagesListStatus.New;
            NotificationList = _mapper.Map<List<NotificationDto>, List<NotificationViewModel>>(await _communicationAppController.GetNotificationsByStatusAsync(_activeDirectoryService.CurrentUser, _activeDirectoryService.OU, NotificationStatus.New));
            this.mainContainer.Panel2.Controls.Find("flpNotification", false)[0].Controls.Clear();
            foreach (var item in NotificationList)
            {
                NotificationBubble notificationBubble = new NotificationBubble(_presenter, item, this, _communicationAppController, _activeDirectoryService, _mapper, _fontService);


                if (this.mainContainer.Panel2.Controls.ContainsKey("flpNotification"))
                {
                    this.mainContainer.Panel2.Controls.Find("flpNotification", false)[0].Controls.Add(notificationBubble);
                    (this.mainContainer.Panel2.Controls.Find("flpNotification", false)[0] as FlowLayoutPanel).SetFlowBreak(notificationBubble, true);
                }
            }
        }

        private void mnuAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            About window = new About(_fontService, _configurationManagerService);
            window.Show();
        }

        private void btnSilent_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _configurationManagerService.Silent = btnSilent.Checked;
            SilentMode = btnSilent.Checked;
        }

        private void mnuCreateMessage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _presenter.RunCreateNewNotification();
        }
    }
}
