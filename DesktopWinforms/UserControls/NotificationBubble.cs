using PSPublicMessagingAPI.Desktop.Presenter.Presenter;
using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.Desktop.Services;
using PSPublicMessagingAPI.Desktop.ViewModels;
using PSPublicMessagingAPI.Desktop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSPublicMessagingAPI.Domain.Notifications;
using AutoMapper;
using DesktopWinforms.Models;

namespace DesktopWinforms.UserControls
{
    public partial class NotificationBubble : UserControl
    {
        public NotificationViewModel Notification { get; set; }
        IMainViewPresenter Presenter;
        IMapper _mapper;
        MainWindow parent;
        private readonly ICommunicationApplicationController _communicationService;
        private readonly IActiveDirectoryService _activeDirectoryService;
        private readonly IFontService _fontService;
        public NotificationBubble(IMainViewPresenter Presenter, NotificationViewModel notification, MainWindow parent, ICommunicationApplicationController communicationService, IActiveDirectoryService activeDirectoryService, IMapper mapper, IFontService fontService)
        {
            this.Presenter = Presenter;
            this.Notification = notification;
            this.parent = parent;
            _communicationService = communicationService;
            _activeDirectoryService = activeDirectoryService;
            InitializeComponent();
            _mapper = mapper;
            btnMarkAsRead.Enabled = Notification.NotificationStatus == NotificationStatus.New;
            _fontService = fontService;
            _fontService = fontService;
            List<Control> allControls = GetAllControls(this);
            allControls.ForEach(k => k.Font = new Font(_fontService.pfc.Families[0], k.Font.Size));
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

        private async void btnMarkAsRead_Click(object sender, EventArgs e)
        {
            var notifToSave = _mapper.Map<NotificationViewModel, NotificationDto>(Notification);
            var notif = await _communicationService.SetNotificationStatusAsync(notifToSave);
            this.Notification = _mapper.Map<NotificationDto, NotificationViewModel>(await _communicationService.GetNotificationByIdAsync(notif)); ;
            btnMarkAsRead.Enabled = this.Notification.NotificationStatus != NotificationStatus.Read;
        }

        private async void btnVisit_Click(object sender, EventArgs e)
        {

            var notifToSave = _mapper.Map<NotificationViewModel, NotificationDto>(Notification);
            //Presenter.GetType().GetMethod(Notification.PossibleActionMethodToCall).Invoke(Presenter, new object[] { parent, Notification.MethodParameter });
            var notif = await _communicationService.SetNotificationStatusAsync(notifToSave);
            this.Notification = _mapper.Map< NotificationDto, NotificationViewModel>(await _communicationService.GetNotificationByIdAsync(notif)); ;
            btnMarkAsRead.Enabled = this.Notification.NotificationStatus != NotificationStatus.Read;
            var msg = new PSPublicMessagingAPI.Desktop.Views.Message(this.Notification, _communicationService, _activeDirectoryService, _mapper, _fontService);
            msg.Show();
        }

        private void NotificationBubble_Load(object sender, EventArgs e)
        {


            lblTitle.Text = Notification.NotificationTitle;
            lblModule.Text = Notification.PossibleActionModuleName;
            lblSender.Text = Notification.PossibleActionFormName;
            lblDate.Text = Notification.NotificationDatePersian;
            lblTime.Text = Notification.NotificationTimePersian;
            lblStatus.Text = Notification.NotificationStatusText;
            lblPriority.Text = Notification.NotificationPriorityText;
            lblMessage.Text = Notification.NotificationText;
            svgImageBox4.SvgImage = DevExpress.Images.ImageResourceCache.Default.GetSvgImage(Notification.NotificationPriorityIcon.ToLower());
            if (Notification.PossibleActionModuleName == "پیام عمومی")
            {
                svgImageBox3.Visible = false;
                lblStatus.Visible = false;
                label3.Visible = false;
                btnMarkAsRead.Visible = false;
            }
            else
            {
                svgImageBox3.Visible = true;
                lblStatus.Visible = true;
                label3.Visible = true;
                btnMarkAsRead.Visible = true;
                svgImageBox3.SvgImage = DevExpress.Images.ImageResourceCache.Default.GetSvgImage(Notification.NotificationStatusIcon.ToLower());

            }
        }
        private NotificationViewModel mapToViewModel(NotificationDto notif)
        {
            return _mapper.Map<NotificationDto, NotificationViewModel>(notif);

        }
    }
}
